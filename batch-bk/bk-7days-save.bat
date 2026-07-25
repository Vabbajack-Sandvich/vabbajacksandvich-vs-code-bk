rem ------------
rem this makes a time stamp dated folder for when the
rem back up was made. this is to keep time revisions
rem of the config file

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

rem set basep=d:\zonide\tf2-custom\

rem set basep=D:\zonide\gaming-stuff\tf2\

rem for 7 days to die save folder

set basep=D:\zonide\gamebackups\7days\

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

rem for 7 days to die this is the contents of
rem C:\Users\zonid\AppData\Roaming\7DaysToDie\Saves
rem the save folder itself

xcopy "C:\Users\zonid\AppData\Roaming\7DaysToDie\Saves\" %finalpath4% /f /h /r /y /j /d /e

rem pause

explorer %finalpath4%