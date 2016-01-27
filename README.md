# ${1:Project Name}

bCoach Assistant was my IB Computer Science portfolio project, which I designed and developed throughout the course. The idea was to develop a program that would enable my school's coach to analyse basketball games and training sessions by recording them and then having the program process the recordings. The program would then automatically calculate certain variables, such as dribbling frequency and heat zones on the court, as well as allowing frame-by-frame replay.

## Installation

In principle, the program should work fine as long as it is compiled correctly, with all the required dll's present. Due to github's 100MB size limit, three dll's required by openCV are not present. I have not tested the program without these dll's, but I suspect they are required for the program to run. The files are: 

bCoach Assistant/bin/Debug/x86/ufft32_55.dll
bCoach Assistant/bin/Debug/x86/nppi32_55.dll
bCoach Assistant/bin/Debug/x86/opencv_gpufilters290.dll

The latest version of OpenCV should include those files. You may download it from here: http://sourceforge.net/projects/opencvlibrary/files/opencv-win/

## Usage

See this video for usage: https://www.youtube.com/watch?v=631n1Yq8ohE

## Contributing

I no longer maintain this project, and I know of no active repositories that do so. Feel free to pick it up and continue developing it, just stick to the license below.

## License

bCoach Assistant is distributed under the GNU GPL v3 license. Moreover, EmguCV is distributed under a GNU GPL v3 license while OpenCV is distributed under a BSD license.
