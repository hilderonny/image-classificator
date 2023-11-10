# image-classificator

Background worker for classifying images dropped in a folder.

## Setup

1. Install Python 3.11 from https://www.python.org/downloads/windows/
1. Clone the repository
1. Open Terminal in the root folder of the repository and run `pip install -r .\requirements.txt`

## Usage

```
python image-classificator.py [-h] --inputpath INPUTPATH --processingpath PROCESSINGPATH --outputpath OUTPUTPATH --mobilenetpath MOBILENETPATH [--language LANGUAGE] [--version]
```

### Options
- `-h`, `--help`: show this help message and exit
- `--inputpath INPUTPATH`, `-i INPUTPATH`: Directory where the images to process are obtained from. Must be writable.
- `--processingpath PROCESSINGPATH`, `-p PROCESSINGPATH`: Directory where the currently processed image gets stored. Must be writable.
- `--outputpath OUTPUTPATH`, `-o OUTPUTPATH`: Directory where the output JSON files will be stored. Must be writable.
- `--mobilenetpath MOBILENETPATH`, `-m MOBILENETPATH`: Directory where the MobileNetV3 Model and settings are stored.
- `--language LANGUAGE`, `-l LANGUAGE`: Language of the output tags. Can be `en` (default) or `de`.
- `--version`, `-v`: show program's version number and exit

## Example

```
python image-classificator.py -i ./data/input -p ./data/processing -o ./data/output -m ./mobilenet -l de
```