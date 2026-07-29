setlocal EnableDelayedExpansion
@echo off

@rem robocopy doesnt like \ at the end of paths
@rem xcopy likes \ at the end sometimes lol

@rem 2026-07-04-21-43-54-PM
@rem repo non repo update
@rem this copies the files
@rem this also updates the vabbajacksandich.vb
@rem first make a timed stamped
@rem folder back up in the master folder

@rem by using a temp folder
@rem and coping all the versions
@rem over top of the one in the folder
@rem from all the sources
@rem using latest date
@rem then copying the updated one
@rem back to the master folder
@rem them copying that one
@rem in to all of the other folders
@rem this all works on the latest date thing using xcopy

@rem ===================================================


@rem ===================================================

@rem xcopy "%sourcepath%\%filename%" "%finalpath%" /f /h /r /y /j /d /e
@rem xcopy "%sourcepath%" "%finalpath%" /f /h /r /y /j /d /e
@rem xcopy "%sourcepath%" "%destinationpath%" /f /h /r /y /j /d /e

@rem ===================================================
rem echo "==================================================="

@rem source
set "sourcepath=C:\cmdbatshortcuts"
@rem set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\cmdbatshortcuts"

rem @rem destination
rem @rem vabbajacksandvich-vs-code-bk
rem set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\batch-stuff\cmdbatshortcuts"
rem 
rem echo "==================================================="
rem echo "sourcepath - !sourcepath!"
rem echo "destinationpath - !destinationpath!"
rem md "!destinationpath!"
rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
rem echo "==================================================="
rem @rem pause

@rem destination
@rem non repo
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff\cmdbatshortcuts"

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="
@rem pause
@@rem pause

@rem ===================================================
@rem source
set "sourcepath=C:\ffmpeg-batch"
@rem destination
@rem git ffmpeg batch repo
set "destinationpath=C:\zonide\zip\CODE\git\vabbajack-sandvich-ffmpeg-batch-2"
@@rem pause
echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="
@rem pause

@rem destination
@rem non repo
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff\ffmpeg-batch"

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="
@rem pause

rem @rem destination
rem @rem vabbajacksandvich-vs-code-bk
rem set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\batch-stuff\ffmpeg-batch"
rem 
rem echo "==================================================="
rem echo "sourcepath - !sourcepath!"
rem echo "destinationpath - !destinationpath!"
rem md "!destinationpath!"
rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
rem echo "==================================================="
rem @rem pause

@rem destination
@rem vabbajacksandvich-vs-code-bk
@rem set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
@rem pause

@rem ===================================================

@rem source
set "sourcepath=C:\ffmpeg-batch\revisions"

@rem destination
@rem git ffmpeg batch repo
set "destinationpath=C:\zonide\zip\CODE\git\vabbajack-sandvich-ffmpeg-batch-2\revisions"
@@rem pause

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="
@rem pause

@rem destination
@rem non repo
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff\ffmpeg-batch\revisions"
@rem paus

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="
@rem pause

@rem source
@rem non repo
set "sourcepath=C:\batch-scraps"

@rem destination
@rem non repo
@rem C:\batch-scraps
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff\batch-scraps"
@rem paus

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="

rem @rem destination
rem @rem code bk
rem set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\batch-stuff\ffmpeg\revisions"
rem @@rem pause
rem 
rem echo "==================================================="
rem echo "sourcepath - !sourcepath!"
rem echo "destinationpath - !destinationpath!"
rem md "!destinationpath!"
rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
rem echo "==================================================="
rem @rem pause

rem ================================================================

rem ================================================================

@rem ===================================================
@rem copy the repo batches to non-repo batch-stuff repo-bk
@rem ===================================================
@rem 2026-07-14-13-08-44-PM
@rem moved this up to before the copy from non-repo to batch-bk
@rem ===================================================
@rem this copies batch-stuff from non-repo to batch-bk
@rem changing to copying to non-repo batch-stuff repo-bk
@rem ===================================================
@rem ===================================================
@rem 2026-07-07-07-43-27-AM
@rem adding a thing to copy the batch files
@rem from
@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\
@rem to
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\
@rem so that they are updated with everything else when i run this
@rem ===================================================
@rem needs \ at the end
@rem destination
@rem git ffmpeg batch repo
@rem set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk"
@rem for rename
@rem set "destinationpath=%%~nf-2thirdslowerpitchspeed.mp3"
@rem set "destionationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk"
@rem set "destionationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\repo-bk"
@rem set "destionationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\batch-stuff\repo-bk"
@rem source
set "sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk"
set "destionationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff\repo-bk"
cd "!sourcepath!"
md "!destinationpath!"
for %%f in (*.bat) do (
set "filesourcepath=%%f"
@rem set "destionationpath=%%~nf_rename.mp3"
echo "==================================================="
echo "copying repo batches to batch-bk\batch-stuff\repo-bk"
echo "==================================================="
echo "file source - !filesourcepath!"
echo "file destination - !destionationpath!"
@rem xcopy "!filesourcepath!" "!destionationpath!" /f /h /r /y /j /d
robocopy "!sourcepath!" "!destinationpath!" /XO
echo "==================================================="
@rem pause
)
@rem ===================================================

@rem ===================================================
@rem 2026-07-14-12-07-19-PM
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\repo-bk
@rem repo-vabbajacksandvich-module-version-update.bat
@rem repo-general-repo-update.bat
@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt
@rem repo-non-repo-make-time-stamped-bk-vabbajacksandvich-master.bat
@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt
@rem ===================================================
@rem 2026-07-14-12-09-12-PM
@rem just copy
@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt
@rem to
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\batch-stuff\repo-bk
echo "==================================================="
echo "copying code-repo-folders.txt to non-repo batch-stuff\repo-bk"
echo "==================================================="
@rem xcopy "C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt" "C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\batch-stuff\repo-bk" /f /h /r /y /j /d
@rem xcopy "C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt" "C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff\repo-bk" /f /h /r /y /j /d
robocopy "C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt" "C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff\repo-bk" /XO
echo "==================================================="
@rem ===================================================
@rem ===================================================
rem ================================================================
rem coping the whole batch-stuff from non-repo to code-bk
rem ================================================================

@rem source
set "sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\batch-stuff"

@rem destination
@rem git ffmpeg batch repo
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\batch-bk\batch-stuff"
@@rem pause

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="
@rem pause

rem ================================================================

@rem source
set "sourcepath=C:\zonide\zip\music"

@rem destination
@rem non repo
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\music"

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO
echo "==================================================="
@@rem pause

@rem ===================================================

@rem this makes a time stamp dated folder for when the
@rem back up was made. this is to keep time revisions
@rem of the config file

@rem set mydate=%date:/=%

echo "==================================================="

set "mydateformat=!date:~10,4!!date:~6,3!/!date:~4,2!"
echo "!mydateformat!"
set "mydate=!mydateformat:/=-!"
echo "!mydate!"
@@rem pause
@rem exit /b
set "mytime=!time::=!"
set "mytimestamp=!mydate: =_!_!mytime:.=_!"
set "mytimestamp=!mytimestamp: =!"

@rem set "destinationpath=d:\zonide\tf2-custom"
@rem set "destinationpath=D:\zonide\gaming-stuff\tf2\tf2-custom"
@rem set "sourcepath=C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom"

@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster
@rem vabbajacksandvich.vb
@rem set srcp=C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\

@rem source
@rem non repo
set "sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster"

@rem destination
@rem code bk
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-bk"

@rem this allows you to set a specific file if you want to
@rem without changing anything else otherwise
set "filename=vabbajacksandvich.vb"
set "finalpath=!destinationpath!!mytimestamp!"
set "finalpath=!finalpath: =_!"
echo "!finalpath!"
set "finalpath=!finalpath:__=_!"
echo "!finalpath!"
set "finalpath=!finalpath:_=-!"
echo "!finalpath!"
md "!finalpath!"

@rem xcopy "!sourcepath!\!filename!" "!finalpath!" /f /h /r /y /j /d
robocopy "!sourcepath!" "!destinationpath!" /XO
@rem pause

@rem non repo
@rem source
set "sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-bk"

@rem code bk
@rem destination
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\zVabbajackSandvichModuleMaster-bk"

echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /E /XO

echo "==================================================="
@rem pause

@rem ===================================================


@rem explorer !finalpath!

@rem explorer D:\zonide\gaming-stuff\tf2\tf2-custom\

@rem pause

@rem ===================================================

@rem 2026-07-04-22-43-42-PM
@rem using zfile style path itterator
@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\
@rem code-repo-folders.txt

@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt

@rem setlocal EnableDelayedExpansion

@rem make sure that the paths end in \
@rem "C:\farts" is correct
@rem "C:\farts" is incorrect
@rem set "zdestpath=C:\zonide\non-zip\music"
@rem C:\zonide\non-zip\2\
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\

@rem source
@rem non repo
set "zsrcpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio"
echo "zsrcpath !zsrcpath!"
set "zfile=code-repo-folders.txt"
echo "zfile !zfile!"

@rem destination
@rem vabbajacksandvich-vs-code-bk
set "zdestpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk"

@rem set "zdestpath=C:\test"

echo "==================================================="
echo "zdestpath !zdestpath!"
set "zsrcfilepath=!zsrcpath!!zfile!"
echo "zsrcfilepath !zsrcfilepath!"
echo "==================================================="

cd "!zsrcpath!"

for /f "usebackq delims=" %%a in ("!zsrcfilepath!") do (
    @rem this is where it reads the files
	@rem then performs commands on each file name
	@rem using %%a
	echo "%%a"
	@rem move /y "%%a" "!zdestpath!"
	@rem xcopy "%%a" "%zdestpath%" /f /h /r /y /j /d
	
	@rem destiation
	echo "==================================================="
	@rem xcopy "%%a" "!zdestpath!%%a" /f /h /r /y /j /d /i /e
	robocopy "%%a" "!zdestpath!%%a" /E /XO
	echo "==================================================="
	@rem pause
)

@rem pause
@rem ===================================================
@rem 2026-07-27-18-07-36-PM
@rem ===================================================
@rem updated test to zonide and runs in c:\zonide
@rem just copying the zonide.exe and the zonide.ahk
@rem from c:\zonide
@rem to the code ahk folder C:\zonide\zip\CODE\ahk
@rem going to be using the c:\zonide\zonide.ahk
@rem as the main working file
@rem with the ones in CODE and other spots as secondary
@rem working backups
@rem ===================================================
@rem non repo
@rem source
echo "==================================================="
echo "==================================================="
echo "zonide.ahk zonide.exe move"
echo "==================================================="
@rem robocopy source destination filename
@rem robocopy doesnt use slashes at the end
@rem correct
@rem C:\zonide
@rem incorrect
@rem C:\zonide\
set "sourcepath=C:\zonide"
set "zfilename=zonide.ahk"
@rem code bk
@rem destination
set "destinationpath=C:\zonide\zip\CODE\ahk"
cd !sourcepath!
echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d
@rem zonide.ahk
robocopy "!sourcepath!" "!destinationpath!" "!zfilename!" /XO
set "zfilename=zonide.exe"
echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem zonide.exe
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d
robocopy "!sourcepath!" "!destinationpath!" "!zfilename!" /XO

echo "==================================================="
echo "==================================================="
@rem pause
@rem ===================================================

@rem ===================================================
@rem 2026-07-14-19-52-51-PM
@rem adding ahk back up
@rem copying from
@rem C:\zonide\zip\CODE\ahk
@rem to
@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\ahk
@rem then from there to
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\ahk
@rem ===================================================
@rem ===================================================
@rem non repo
@rem source
set "sourcepath=C:\zonide\zip\CODE\ahk"
@rem code bk
@rem destination
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\ahk"
cd !sourcepath!
echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /XO
echo "==================================================="
echo "==================================================="
@rem pause
@rem ===================================================

@rem ===================================================
@rem also seperating the bk ahk folder in to
@rem an outward folder called ahk-bk
@rem then copying from
@rem C:\zonide\zip\CODE\ahk-bk
@rem to
@rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\ahk-bk
@rem ===================================================
@rem ===================================================
@rem non repo
@rem source
set "sourcepath=C:\zonide\zip\CODE\ahk-bk"
@rem code bk
@rem destination
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\ahk-bk"
cd !sourcepath!
echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /XO
echo "==================================================="
@@rem pause
@rem ===================================================

@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\ahk-bk

@rem then copying ahk and ahk-bk from non repo
@rem to code-bk
@rem i put an ahk-bk-old folder in non repo that
@rem doesnt get backed up and is a manual copy paste
@rem the later versions will be auto copied with
@rem this batch file

@rem ===================================================
@rem non repo
@rem source
set "sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\ahk"
@rem code bk
@rem destination
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\ahk"
cd !sourcepath!
echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /XO
echo "==================================================="
@@rem pause
@rem ===================================================

@rem ===================================================
@rem non repo
@rem source
set "sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\ahk-bk"
@rem code bk
@rem destination
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\ahk-bk"
cd !sourcepath!
echo "==================================================="
echo "sourcepath - !sourcepath!"
echo "destinationpath - !destinationpath!"
md "!destinationpath!"
@rem xcopy "!sourcepath!" "!destinationpath!" /f /h /r /y /j /d /e
robocopy "!sourcepath!" "!destinationpath!" /XO
echo "==================================================="
@@rem pause
@rem ===================================================


@@rem pause

