rem ------------------------------------------
rem ------------
rem this makes a time stamp dated folder for when the
rem back up was made. this is to keep time revisions
rem of the config file

rem set mydate=%date:/=%

set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%

echo %mydateformat%

set mydate=%mydateformat:/=-%

echo %mydate%

rem pause

rem exit /b

set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

rem set basep=d:\zonide\tf2-custom\
set basep=D:\zonide\gaming-stuff\tf2\tf2-custom\

set "finalpath=%basep%%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

echo %finalpath4%

md %finalpath4%

pause

rem xcopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\cfg\" %finalpath4% /f /h /r /y /j /d

rem xcopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\" %finalpath4% /f /h /r /y /j /d /e

xcopy "D:\SteamLibrary\steamapps\common\Team Fortress 2\tf\custom\" %finalpath4% /f /h /r /y /j /d /e

explorer %finalpath4%

rem explorer D:\zonide\gaming-stuff\tf2\tf2-custom\

rem pause