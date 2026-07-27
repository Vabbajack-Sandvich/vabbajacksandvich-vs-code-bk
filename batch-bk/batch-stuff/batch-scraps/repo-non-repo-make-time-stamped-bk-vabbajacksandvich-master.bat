rem 2026-07-04-21-43-54-PM
rem repo non repo update
rem this copies the files
rem this also updates the vabbajacksandich.vb
rem first make a timed stamped
rem folder back up in the master folder

rem by using a temp folder
rem and coping all the versions
rem over top of the one in the folder
rem from all the sources
rem using latest date
rem then copying the updated one
rem back to the master folder
rem them copying that one
rem in to all of the other folders
rem this all works on the latest date thing using xcopy

rem from:
rem C:\cmdbatshortcuts
rem C:\ffmpeg-batch
rem C:\zonide\zip\music

rem ===================================================
rem this makes a time stamp dated folder for when the
rem back up was made. this is to keep time revisions
rem of the config file

@echo off

rem set mydate=%date:/=%

set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%
echo %mydateformat%
set mydate=%mydateformat:/=-%
echo %mydate%
rem pause
rem exit /b
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%
set mytimestamp=%mytimestamp: =%

rem set destinationpath=d:\zonide\tf2-custom\
rem set "destinationpath=D:\zonide\gaming-stuff\tf2\tf2-custom\"
rem set "sourcepath=C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\"

set destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-bk\
rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster
rem vabbajacksandvich.vb
rem set srcp=C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\
set sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster\


rem this allows you to set a specific file if you want to
rem without changing anything else otherwise
set "filename=vabbajacksandvich.vb"
set "finalpath=%destinationpath%%mytimestamp%"
set finalpath=%finalpath: =_%
echo %finalpath%
set finalpath=%finalpath:__=_%
echo %finalpath%
set finalpath=%finalpath:_=-%
echo %finalpath%
md %finalpath%

rem pause

rem xcopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\cfg\" %finalpath% /f /h /r /y /j /d

rem 2026-07-04-21-56-48-PM
rem oops
rem fixing the /e switch
rem that copies everyting
rem xcopy "%sourcepath%" "%finalpath%" /f /h /r /y /j /d /e
rem xcopy "%sourcepath%" "%finalpath%" /f /h /r /y /j /d
xcopy "%sourcepath%\%filename%" "%finalpath%" /f /h /r /y /j /d

explorer %finalpath%

rem explorer D:\zonide\gaming-stuff\tf2\tf2-custom\

rem pause