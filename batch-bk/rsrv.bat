rem D:\zonide\gamebackups\rust\rustserver_oxide
rem C:\rustserver_oxide\server
rem C:\rustserver_oxide\userdata
rem C:\rustserver_oxide\oxide
rem C:\rustserver_oxide\config

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=D:\zonide\gamebackups\rust\rustserver_oxide\

set "finalpath=%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

echo %finalpath4%

set finalpath5=%basep%%finalpath4%\

rem pause

md %finalpath5%

rem pause

rem xcopy "C:\rustserver_oxide\server" "D:\zonide\gamebackups\rust\rustserver_oxide\server" /e /f /h /r /y /j
rem xcopy "C:\rustserver_oxide\userdata" "D:\zonide\gamebackups\rust\rustserver_oxide\userdata" /e /f /h /r /y /j
rem xcopy "C:\rustserver_oxide\oxide" "D:\zonide\gamebackups\rust\rustserver_oxide\oxide" /e /f /h /r /y /j
rem xcopy "C:\rustserver_oxide\config" "D:\zonide\gamebackups\rust\rustserver_oxide\config" /e /f /h /r /y /j

xcopy "C:\rustserver_oxide\server" "D:\zonide\gamebackups\rust\tmpcopy\server" /e /f /h /r /y /j
xcopy "C:\rustserver_oxide\userdata" "D:\zonide\gamebackups\rust\tmpcopy\userdata" /e /f /h /r /y /j
xcopy "C:\rustserver_oxide\oxide" "D:\zonide\gamebackups\rust\tmpcopy\oxide" /e /f /h /r /y /j
xcopy "C:\rustserver_oxide\config" "D:\zonide\gamebackups\rust\tmpcopy\config" /e /f /h /r /y /j

rem pause

xcopy "D:\zonide\gamebackups\rust\tmpcopy" %finalpath5% /e /f /h /r /y /j

rem pause
