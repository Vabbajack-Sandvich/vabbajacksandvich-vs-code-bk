rem ts.bat
rem sets up the cmd prompt to run main.exe
rem main.exe is speech to text from a wav file
rem located in d:\ts\
rem this uses audacity to re-record the same ts file
rem and export it everytime to d:\ts\ts.wav
rem it runs the program and outputs to
rem D:\ts\ts.wav.txt

chdir /d D:
cd D:\zonide\CODE\cpp\whisper.cpp-1.5.5\out\build\x64-Debug\bin
main -t 8 -otxt d:\ts\ts.wav
pause