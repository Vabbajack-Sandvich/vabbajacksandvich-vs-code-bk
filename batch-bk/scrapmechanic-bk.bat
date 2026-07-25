rem scrap mechanic back up using time stamp file path iterations

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=D:\zonide\gamebackups\scrapmechanic\i-bk\

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

rem old one before computer fix
rem xcopy "C:\Users\Dragon\AppData\Roaming\Axolot Games\Scrap Mechanic\User" %finalpath4% /e /f /h /r /y /j /d

rem new one C:\Users\zonid\AppData\Roaming\Axolot Games\Scrap Mechanic\User
xcopy "C:\Users\zonid\AppData\Roaming\Axolot Games\Scrap Mechanic\User" %finalpath4% /e /f /h /r /y /j /d

pause