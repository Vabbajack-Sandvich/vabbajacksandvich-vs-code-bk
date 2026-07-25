

rem feet that have been cooked in feet

rem this is just a game back up that backs up the my games folder
rem ------------------------------------------
rem game backups
rem old
rem xcopy C:\Users\Dragon\Documents\MyGame~1\ D:\zonide\gamebackups\mygame~1 /e /f /h /r /y /j /d
rem ------------------------------------------

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=D:\zonide\gamebackups\mygame~1\Oblivion\

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

rem xcopy "C:\Users\Dragon\Documents\My Games\Oblivion\" %finalpath4% /f /h /r /y /j /d /e
xcopy "C:\Users\zonid\Documents\My Games\Oblivion\" %finalpath4% /f /h /r /y /j /d /e
