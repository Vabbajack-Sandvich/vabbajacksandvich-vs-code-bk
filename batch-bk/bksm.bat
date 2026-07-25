rem------------
rem this makes a time stamp dated folder for when the
rem back up was made. this is to keep time revisions
rem of the config file

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

rem set basep=d:\zonide\tf2-custom\

set basep=D:\zonide\gamebackups\scrapmechanic\

set "finalpath=%basep%%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

rem echo %finalpath4%

rem pause

md %finalpath4%

xcopy "C:\Users\zonid\AppData\Roaming\Axolot Games\Scrap Mechanic\User\" %finalpath4% /f /h /r /y /j /d /e