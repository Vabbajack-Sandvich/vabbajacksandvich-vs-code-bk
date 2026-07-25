rem ------------
rem this makes a time stamp dated folder for when the
rem back up was made. this is to keep time revisions
rem of the config file

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

rem set basep=d:\zonide\tf2-custom\

set basep=D:\zonide\gaming-stuff\tf2\

set "finalpath=%basep%%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

echo %finalpath4%

rem pause

md %finalpath4%

rem set "finalpath5=%finalpath4%\custom.cfg"

set "finalpath5=%finalpath4%\mycustom\"

rem echo %finalpath5%

rem pause

md %finalpath5%

rem pause

rem xcopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\cfg\custom.cfg" %finalpath5% /f /h /r /y /j /d

rem pause

xcopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\" %finalpath5% /f /h /r /y /j /d /e

rem adding this much later to copy the config file for video settings
rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg

set "finalpath6=%finalpath4%\cfg\"

md %finalpath6%

xcopy "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\config.cfg" %finalpath6% /f /h /r /y /j /d

rem pause