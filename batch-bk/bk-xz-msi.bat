rem this is to copy the music both ways from and to the usb drive and from downloads to the music folder
xcopy D:\downloads\*.mp3 d:\zonide\music /f /h /r /y /d /e
rem xcopy e:\zonide\music d:\zonide\music /f /h /r /y /d /e
xcopy d:\zonide\music e:\zonide\music /f /h /r /y /d /e

rem feet that have been cooked in feet

rem ------------------------------------------
rem game backups
xcopy C:\Users\Dragon\Documents\MyGame~1\ D:\zonide\gamebackups\mygame~1 /e /f /h /r /y /j /d
rem ------------------------------------------
rem ------------
rem this makes a time stamp dated folder for when the
rem back up was made. this is to keep time revisions
rem of the config file

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=d:\zonide\tf2-custom\

set "finalpath=%basep%%mytimestamp%"

set finalpath2=%finalpath: =_%

echo %finalpath2%

set finalpath3=%finalpath2:__=_%

echo %finalpath3%

set finalpath4=%finalpath3:_=-%

echo %finalpath4%

md %finalpath4%

rem xcopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\cfg\" %finalpath4% /f /h /r /y /j /d

xcopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\" %finalpath4% /f /h /r /y /j /d /e

rem pause
rem ------------------------------------------
rem game backup - ark
rem D:\SteamLibrary\steamapps\common\ARK Survival Evolved Dedicated Server\ShooterGame\Saved
rem D:\SteamLibrary\steamapps\common\ARKSur~1\ShooterGame\Saved\
rem D:\zonide\gamebackups\ark\saved\

xcopy "D:\SteamLibrary\steamapps\common\ARK Survival Evolved Dedicated Server\ShooterGame\Saved\" "D:\zonide\gamebackups\ark\saved\" /e /f /h /r /y /j /d
rem ------------------------------------------
rem C:\Users\Dragon\AppData\Roaming\7DaysToDie

xcopy "C:\Users\Dragon\AppData\Roaming\7DaysToDie" "D:\zonide\gamebackups\7DaysToDie\" /e /f /h /r /y /j /d

rem ------------------------------------------
rem C:\Users\Dragon\AppData\Roaming\Axolot Games\Scrap Mechanic\User
rem D:\zonide\gamebackups\scrapmechanic

xcopy "C:\Users\Dragon\AppData\Roaming\Axolot Games\Scrap Mechanic\User" "D:\zonide\gamebackups\scrapmechanic" /e /f /h /r /y /j /d

rem ------------------------------------------
rem copy code to zonide back up
rem ------------------------------------------
xcopy C:\Users\Dragon\source D:\zonide\CODE\visualstudio\source-bk\source /e /f /h /r /y /j /d

rem satisfactory backup
rem C:\Users\Dragon\AppData\Local\FactoryGame
rem D:\zonide\gamebackups\my games\FactoryGame
xcopy C:\Users\Dragon\AppData\Local\FactoryGame D:\zonide\gamebackups\mygame~1\FactoryGame /e /f /h /r /y /j /d

rem no mans sky save back up with revision folder back up per run
rem C:\Users\Dragon\AppData\Roaming\HelloGames\NMS

rem D:\zonide\gamebackups\nomanssky

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

rem ------------------------------------------
rem copy the zonide folder to the usb drive
rem xcopy D:\zonide f:\zonide /e /f /h /r /y /j /d
rem xcopy D:\zonide\music c:\zonide\music /e /f /h /r /y /j /d
xcopy D:\zonide e:\zonide /e /f /h /r /y /j /d
