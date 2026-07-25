rem ------------------------------------------
rem this makes a time stamp backup folder

rem new
rem this removes the fucking day from the time stamp
rem and reorders the date
rem this needs to be added to all the backup batch files
rem this should be made the new default to make new ones from also

rem echo %date%

set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%

echo %mydateformat%

set mydate=%mydateformat:/=-%

echo %mydate%

rem pause

rem exit /b

rem old
rem set mydate=%date:/=%

rem old unchanged
set mytime=%time::=%

set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=D:\zonide\ahk\bk\

set "finalpath=%basep%%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

echo %finalpath4%

rem exit /b

md %finalpath4%

set finalpath5=%finalpath4%

echo %finalpath5%

rem set the ahkfiles path to wherever the ahkfiles are

set ahkfiles=D:\zonide\ahk\test.ahk

xcopy %ahkfiles% %finalpath5% /f /h /r /y /j /d

rem pause

explorer %finalpath5%
