# image-classificator

Background worker with graphical user interface for classifying images dropped in a folder. This project consists of two parts:

1. **ImageClassificatorCLI** - Python command line executable which can be run via console and which is used by the graphical part below
1. **ImageClassificator** - Graphical windows application for easy configuration of the command line interface

## Installation and running

1. Download and install the Visual C++ Redistributables from https://aka.ms/vs/17/release/vc_redist.x64.exe
1. Download and extract the latest release of this software from https://github.com/hilderonny/image-classificator/releases


## Development setup

1. Install Visual Studio Community 2022 from https://learn.microsoft.com/en-us/visualstudio/releases/2022/release-notes
1. Select
	1. Workload **.NET Desktop** with *Windows App SDK C# Templates*
	1. Workload **Python**
	1. Component **Windows 10 SDK (10.0.190412.0)**
1. Install Python 3.11 from https://www.python.org/downloads/windows/ into the **./ImageClassificatorCLI/python** folder
1. Open the solution **ImageClassificator/ImageClassificator.sln**
1. Right click on the solution in the solution explorer and run **Restore NuGet Packages**
1. Open Terminal in the folder **./ImageClassificatorCLI/python** of the repository and run `.\python install -r ..\requirements.txt`
