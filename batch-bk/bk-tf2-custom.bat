rem ===================================================
rem 2026-07-04-22-01-52-PM updating this
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
set "destinationpath=D:\zonide\gaming-stuff\tf2\tf2-custom\"
set "sourcepath=C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\"
rem this allows you to set a specific file if you want to
rem without changing anything else otherwise
set "filename="
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