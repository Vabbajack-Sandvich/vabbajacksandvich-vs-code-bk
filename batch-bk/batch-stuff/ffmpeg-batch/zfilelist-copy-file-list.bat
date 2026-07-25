@rem 2026-06-23-12-00-04-PM
@rem works with auto hot key test.ahk
@rem zfilelist.txt from test.exe based file lists
@rem you can use wild cards to seach directories
@rem like *blah*.mp3 will return all files with blah that are .mp3 files in zfilelist
@rem using control shift f and specifying
@rem the paths and search in the input boxes
@rem checks any file type

@rem meant as structure
@rem to be changed as needed
@rem for the zfile directory
@rem that you have to change manually
@rem this makes executing commmands on
@rem just a specific file list search

@rem 2026-06-30-05-26-00-AM
@rem just tested multi wild card
@rem it works
@rem *bare*-2
@rem results in zfilelist.txt containing:

@rem 2026-07-17-04-28-59-AM
@rem this does the same as the move batch
@rem but copies the files instead

@echo off

setlocal EnableDelayedExpansion

@rem ================================================
@rem 2026-07-13-14-17-25-PM
@rem updating this for ease of use and adding mkdir for destination
@rem ================================================
@rem make sure that the paths end in \
@rem "C:\farts\" is correct
@rem "C:\farts" is incorrect
@rem ================================================
@rem copy and pasteble defaults
@rem 
@rem set "zsrcpath=C:\zonide\non-zip\music\"
@rem echo "zsrcpath !zsrcpath!"
@rem 
@rem set "zdestpath=C:\zonide\non-zip\2\"
@rem echo "zdestpath !zdestpath!"
@rem 
@rem set "zfile=zfilelist.txt"
@rem echo "zfile !zfile!"
@rem ================================================

@rem ================================================
@rem          change these
@rem ================================================

@rem set "zsrcpath=C:\zonide\non-zip\music\"
@rem set "zsrcpath=C:\zonide\non-zip\music\1\"
set "zsrcpath=C:\vc\"
echo "zsrcpath !zsrcpath!"

@rem set "zdestpath=C:\zonide\non-zip\2\"
set "zdestpath=C:\zonide\non-zip\music\2\"
@rem this uses C:\vc\t as default
@rem not that its useful but as an example
set "zdestpath=C:\vc\t\"
echo "zdestpath !zdestpath!"

set "zfile=zfilelist.txt"
echo "zfile !zfile!"
@rem ================================================
@rem ================================================

set "zsrcfilepath=!zsrcpath!!zfile!"
echo "zsrcfilepath !zsrcfilepath!"

@rem this is easier than checking
@rem it will just fail and progress if its there already
@rem and it will make it automatically if its not
@rem without an if statement check

mkdir !destpath!

cd !zsrcpath!

for /f "usebackq delims=" %%a in ("!zsrcfilepath!") do (
    @rem this is where it reads the files
	@rem then performs commands on each file name
	@rem using %%a
	echo %%a
	@rem move /y "%%a" "!zdestpath!"
	xcopy "!zsrcpath!" "!zdestpath!" /f /h /r /y /j /d /e

)

call bool.bat
pause
