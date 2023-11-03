PROGRAM_VERSION = '1.0.0'

import datetime
import shutil
import stat
import json
import time
import numpy

# Parse command line arguments
import argparse
parser = argparse.ArgumentParser()
parser.add_argument('--inputpath', '-i', type=str, action='store', required=True, help='Directory where the images to process are obtained from. Must be writable.')
parser.add_argument('--processingpath', '-p', type=str, action='store', required=True, help='Directory where the currently processed image gets stored. Must be writable.')
parser.add_argument('--outputpath', '-o', type=str, action='store', required=True, help='Directory where the output JSON files will be stored. Must be writable.')
parser.add_argument('--mobilenetpath', '-m', type=str, action='store', required=True, help='Directory where the MobileNetV3 Model and settingsa are stored.')
parser.add_argument('--language', '-l', type=str, default='en', action='store', help='Language of the output tags. Can be "en" (default) or "de".')
parser.add_argument('--version', '-v', action='version', version=PROGRAM_VERSION)
args = parser.parse_args()

# Check write access to directories
import sys
import os
INPUTPATH = args.inputpath
PROCESSINGPATH = args.processingpath
OUTPUTPATH = args.outputpath
if not os.access(INPUTPATH, os.R_OK | os.W_OK):
    sys.exit(f'ERROR: Cannot read and write input directory {INPUTPATH}')
if not os.access(PROCESSINGPATH, os.R_OK | os.W_OK):
    sys.exit(f'ERROR: Cannot read and write processing directory {PROCESSINGPATH}')
if not os.access(OUTPUTPATH, os.R_OK | os.W_OK):
    sys.exit(f'ERROR: Cannot read and write output directory {OUTPUTPATH}')

# Check existence of MobileNet files
MOBILENETPATH = args.mobilenetpath
LABELFILEPATH = os.path.join(MOBILENETPATH, f'imagenet.{args.language}.names')
KERASPATH = os.path.join(MOBILENETPATH, 'keras')
MODELFILEPATH = os.path.join(MOBILENETPATH, 'mobilenetv3large_model.h5')
CLASSINDEXFILEPATH = os.path.join(KERASPATH, 'imagenet_class_index.json')
if not os.access(MOBILENETPATH, os.R_OK):
    sys.exit(f'ERROR: Cannot read MobileNet directory {MOBILENETPATH}')
if not os.access(LABELFILEPATH, os.R_OK):
    sys.exit(f'ERROR: Cannot read MobileNet label file {LABELFILEPATH}')
if not os.access(KERASPATH, os.R_OK):
    sys.exit(f'ERROR: Cannot read Keras directory {KERASPATH}')
if not os.access(CLASSINDEXFILEPATH, os.R_OK):
    sys.exit(f'ERROR: Cannot read class index file {CLASSINDEXFILEPATH}')
if not os.access(MODELFILEPATH, os.R_OK):
    sys.exit(f'ERROR: Cannot read MobileNet model file {MODELFILEPATH}')

# Load classification labels
print(f'Loading labels for language {args.language}')
CLASSES = {}
with open(LABELFILEPATH, mode='r', encoding='utf-8') as f:
    for line in f.readlines():
        stripped_line = line.strip()
        id, text = stripped_line[:9], stripped_line[10:]
        CLASSES[id] = text

# Import TensorFlow and MobileNet
print('Loading TensorFlow and MobileNet V3')
os.environ['KERAS_HOME'] = os.path.join(KERASPATH)
from tensorflow.keras.preprocessing import image
from tensorflow.keras.models import load_model
from tensorflow.keras.applications.mobilenet_v3 import preprocess_input, decode_predictions

# Load MobileNet model
print('Loading model')
MODEL = load_model(MODELFILEPATH, compile=False)

def categorize_image(result, file_path):
    global MODEL
    img = image.load_img(file_path, target_size=(224, 224))
    imageArray = image.img_to_array(img)
    expandedImageArray = numpy.expand_dims(imageArray, axis=0)
    print("preprocess_input")
    preprocessedImage = preprocess_input(expandedImageArray)
    print("predict")
    predictions = MODEL.predict(preprocessedImage)
    print("decode_predictions")
    best_predictions = decode_predictions(predictions, top=10)[0]
    first_prediction = best_predictions[0]
    #result["predictions"] = [classes[prediction[0]] for prediction in best_predictions]
    result["predictions"] = [prediction[1] for prediction in best_predictions]
    result["class"] = first_prediction[0]
    result["name"] = CLASSES[first_prediction[0]]
    result["probability"] = float(first_prediction[2])

def process_file(file_path):
    start_time = datetime.datetime.now()
    result = {}
    try:
        print("Processing file " + file_path)
        categorize_image(result, file_path)
    except Exception as ex:
        print(ex)
        result["exception"] = str(ex)
    finally:
        print("Deleting file " + file_path)
        os.remove(file_path)
        pass
    end_time = datetime.datetime.now()
    result["duration"] = (end_time - start_time).total_seconds()
    return result

def check_and_process_files():
    #print("Checking for at least one file in " + INPUTPATH)
    file_was_processed = False
    for file_name in os.listdir(INPUTPATH):
        input_file_path = os.path.join(INPUTPATH, file_name)
        if os.path.isfile(input_file_path):
            try:
                # Erst mal Datei aus INPUT Verzeichnis bewegen, damit andere Prozesse diese nicht ebenfalls verarbeiten
                processing_file_path = os.path.join(PROCESSINGPATH, file_name)
                shutil.move(input_file_path, processing_file_path)
                os.chmod(processing_file_path, stat.S_IRWXU | stat.S_IRWXG | stat.S_IRWXO ) # Let the background process delete the file afterwards
                # Datei verarbeiten
                result = process_file(processing_file_path)
                json_result = json.dumps(result, indent=2)
                output_file_path = os.path.join(OUTPUTPATH, file_name + ".json")
                print("Writing output file " + output_file_path)
                output_file = os.open(output_file_path, os.O_RDWR|os.O_CREAT)
                os.write(output_file, str.encode(json_result))
                os.close(output_file)
                print(json_result)
                file_was_processed = True
                return file_was_processed # Let the program wait a moment and recheck the uplopad directory
            except Exception as ex:
                print(ex)
            finally: # Hat nicht geklappt. Eventuell hat ein anderer Prozess die Datei bereits weg geschnappt. Egal.
                return
    return file_was_processed


# Start processing
try:
    print('Ready and waiting for action')
    while True:
        file_was_processed = check_and_process_files()
        if file_was_processed == False:
            time.sleep(3)
finally:
    pass
