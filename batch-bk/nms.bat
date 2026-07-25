rem no mans sky save back up with revision folder back up per run
rem C:\Users\Dragon\AppData\Roaming\HelloGames\NMS

rem D:\zonide\gamebackups\nomanssky

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=D:\zonide\gamebackups\nomanssky\

set "finalpath=%basep%%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

echo %finalpath4%

rem pause

md %finalpath4%

rem pause

xcopy "C:\Users\Dragon\AppData\Roaming\HelloGames" %finalpath4% /f /h /r /y /j /d /e
