rem 2026-06-23-12-00-04-PM
rem works with auto hot key test.ahk
rem zfilelist.txt from test.exe based file lists
rem you can use wild cards to seach directories
rem like *blah*.mp3 will return all files with blah that are .mp3 files in zfilelist
rem using control shift f and specifying
rem the paths and search in the input boxes
rem checks any file type

rem meant as structure
rem to be changed as needed
rem for the zfile directory
rem that you have to change manually
rem this makes executing commmands on
rem just a specific file list search

rem 2026-06-30-05-26-00-AM
rem just tested multi wild card
rem it works
rem *bare*-2
rem results in zfilelist.txt containing:

@echo off

setlocal EnableDelayedExpansion

rem make sure that the paths end in \
rem "C:\farts\" is correct
rem "C:\farts" is incorrect
set "zsrcpath=C:\zonide\non-zip\music\"
echo "zsrcpath !zsrcpath!"
set "zfile=zfilelist.txt"
echo "zfile !zfile!"
rem set "zdestpath=C:\zonide\non-zip\music\"
rem C:\zonide\non-zip\2
set "zdestpath=C:\zonide\non-zip\2\"
echo "zdestpath !zdestpath!"
set "zsrcfilepath=!zsrcpath!!zfile!"
echo "zsrcfilepath !zsrcfilepath!"

cd !zsrcpath!

for /f "usebackq delims=" %%a in ("!zsrcfilepath!") do (
    rem this is where it reads the files
	rem then performs commands on each file name
	rem using %%a
	echo %%a
	move /y "%%a" "!zdestpath!"

)
