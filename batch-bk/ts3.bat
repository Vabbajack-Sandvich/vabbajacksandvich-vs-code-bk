chdir /d D:
cd D:\
cls
rem ts.bat
rem sets up the cmd prompt to run main.exe
rem main.exe is speech to text from a wav file
rem located in d:\ts\
rem this uses audacity to re-record the same ts file
rem and export it everytime to d:\ts\ts.wav
rem it runs the program and outputs to
rem D:\ts\ts.wav.txt
rem this one defrags the wav file using defraggler
rem command line

rem ---- defrag the wav file
chdir /d c:
cd c:\PROGRA~1\Defraggler\
df D:\ts\ts.wav

rem ---- run the transcription program
chdir /d D:
cd D:\zonide\CODE\cpp\whisper.cpp-1.5.5\out\build\x64-Debug\bin
rem main --grammar-penalty 50 -bo 1 -bs 1 -sow -l en -pp -t 11 -p 1 -otxt d:\ts\ts.wav
rem main --grammar-penalty 10 -bo 1 -bs 1 -l en -pp -t 11 -p 1 -otxt -ocsv d:\ts\ts.wav
rem main --grammar-penalty 100 -bo 5 -bs 5 -l en -pp -t 11 -p 1 -otxt -ocsv d:\ts\ts.wav
main --grammar-penalty 0 -bo 1 -bs 1 -l en -pp -t 11 -p 1 -otxt -ocsv d:\ts\ts.wav
pause