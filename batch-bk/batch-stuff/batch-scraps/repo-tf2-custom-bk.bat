setlocal EnableDelayedExpansion
@rem @echo off

@rem ===================================================

@rem this makes a time stamp dated folder for when the
@rem back up was made. this is to keep time revisions
@rem of the config file

@rem set mydate=%date:/=%

echo "==================================================="

set "mydateformat=!date:~10,4!!date:~6,3!/!date:~4,2!"
echo "!mydateformat!"
set "mydate=!mydateformat:/=-!"
echo "!mydate!"
@@rem pause
@rem exit /b
set "mytime=!time::=!"
set "mytimestamp=!mydate: =_!_!mytime:.=_!"
set "mytimestamp=!mytimestamp: =!"


@rem ====================================
@rem ====================================
@rem 2026-08-02-19-07-10-PM
@rem new tf2 custom repo update
@rem source
@rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\custom
@rem destination
@rem using timetamp
@rem source
@rem non repo
@rem set "sourcepath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster"
set "sourcepath=C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\custom"

@rem destination
@rem non repo
@rem set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-bk"
set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\junk\gaming-stuff\tf2-custom"

@rem this allows you to set a specific file if you want to
@rem without changing anything else otherwise
@rem set "filename=vabbajacksandvich.vb"
@rem set "finalpath=!destinationpath!!mytimestamp!"
set "finalpath=!destinationpath!\!mytimestamp!"
set "finalpath=!finalpath: =_!"
echo "!finalpath!"
set "finalpath=!finalpath:__=_!"
echo "!finalpath!"
set "finalpath=!finalpath:_=-!"
echo "!finalpath!"
md "!finalpath!"

@rem xcopy "!sourcepath!\!filename!" "!finalpath!" /f /h /r /y /j /d
robocopy "!sourcepath!" "!finalpath!" /XO /E

@rem then change the destination and source
@rem and just copy the new time stamp from
@rem the non repo over to the CODE-bk

@rem using a bk for the time stamp
robocopy "!sourcepath!" "!finalpath!" /XO /E

@rem then copying the live one over top
@rem of the one in custom
@rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\Team-Fortress-2-Custom-Config\bk
set "sourcepath=!finalpath!"

set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\Team-Fortress-2-Custom-Config\bk"

set "finalpath=!destinationpath!\!mytimestamp!"
set "finalpath=!finalpath: =_!"
echo "!finalpath!"
set "finalpath=!finalpath:__=_!"
echo "!finalpath!"
set "finalpath=!finalpath:_=-!"
echo "!finalpath!"
md "!finalpath!"

robocopy "!sourcepath!" "!finalpath!" /XO /E

set "sourcepath=!finalpath!"

set "destinationpath=C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\Team-Fortress-2-Custom-Config\custom"

@rem copy the code-bk bk time stamped version
@rem over the top of the base
@rem custom folder

robocopy "!sourcepath!" "!destinationpath!" /XO /E

@rem pause
@rem ====================================
@rem ====================================
