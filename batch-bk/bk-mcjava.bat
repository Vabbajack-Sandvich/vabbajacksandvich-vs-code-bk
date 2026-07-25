rem ------------------------------------------
rem this makes a time stamp dated folder for when the
rem back up was made. this is to keep time revisions
rem of the config file

rem this backs up minecraft java saves

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=D:\zonide\gamebackups\minecraft-java\

set "finalpath=%basep%%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

echo %finalpath4%

md %finalpath4%

rem set the gamefiles path to wherever the gamefiles are

set gamefiles=C:\Users\zonid\AppData\Roaming\.minecraft\saves\

xcopy %gamefiles% %finalpath4% /f /h /r /y /j /d /e

pause