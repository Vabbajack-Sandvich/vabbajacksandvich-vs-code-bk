
rem 2025-10-21-07-46-23-AM

rem to use this, copy whatever version that has been changed in to the main module folder

rem this backs up every module in every project folder that uses it to its own back up folder

rem then copies the main module vabbajacksandvich.vb to every project folder that uses it

rem from D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster

rem master file directory
rem D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster

rem ==========================================
rem projects that dont use vabbajacksandvich.vb or zonide.vb
rem ==========================================

rem D:\zonide\code\visualstudio\Craft-Notes-0
rem D:\zonide\code\visualstudio\File-Renamer
rem D:\zonide\code\visualstudio\KeepOnlyDuplicates
rem D:\zonide\code\visualstudio\zConCat
rem D:\zonide\code\visualstudio\zRemote

rem ==========================================
rem projects that do use the module
rem ==========================================

rem D:\zonide\code\visualstudio\gLog
rem D:\zonide\code\visualstudio\Machine-Set-Calculator
rem D:\zonide\code\visualstudio\Title-incrementor
rem D:\zonide\code\visualstudio\zBlocker
rem D:\zonide\code\visualstudio\zCodeGen
rem D:\zonide\code\visualstudio\zFile
rem D:\zonide\code\visualstudio\zFilter
rem D:\zonide\code\visualstudio\zLineCombine
rem D:\zonide\code\visualstudio\zOblivionQuestCompare
rem D:\zonide\code\visualstudio\zProcess
rem D:\zonide\code\visualstudio\zTf2Script
rem D:\zonide\code\visualstudio\ShutDownTimer

rem ==========================================
rem copy and paste from generic timestamp consolidated
rem ==========================================

rem set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%
rem set mydate=%mydateformat:/=-%
rem set mytime=%time::=%
rem set mytimestamp=%mydate: =_%_%mytime:.=_%
rem set basep=D:\zonide\ahk\bk\
rem set "finalpath=%basep%%mytimestamp%"
rem set finalpath2=%finalpath: =_%
rem set finalpath3=%finalpath2:__=_%
rem set finalpath4=%finalpath3:_=-%
rem rem exit /b
rem md %finalpath4%
rem rem set the ahkfiles path to wherever the ahkfiles are
rem set ahkfiles=D:\zonide\ahk\test.ahk
rem xcopy %ahkfiles% %finalpath4% /f /h /r /y /j /d
rem rem pause
rem rem explorer %finalpath5%

rem putting the module backups in their own section in
rem under the main backup thing

set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%
set mydate=%mydateformat:/=-%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

rem should only need the above part once and just change the rest
rem for each one

rem D:\zonide\code\visualstudio\gLog
rem D:\zonide\CODE\visualstudio-backups\gLog-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\gLog-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\gLog\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\Machine-Set-Calculator
rem D:\zonide\CODE\visualstudio-backups\Machine-Set-Calculator-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\Machine-Set-Calculator-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\Machine-Set-Calculator\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\Title-incrementor
rem D:\zonide\CODE\visualstudio-backups\title-incrementor-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\title-incrementor-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\Title-incrementor\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zBlocker
rem D:\zonide\CODE\visualstudio-backups\zBlocker-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zBlocker-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zBlocker\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zCodeGen
rem D:\zonide\CODE\visualstudio-backups\zCodeGen-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zCodeGen-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zCodeGen\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zFile
rem D:\zonide\CODE\visualstudio-backups\zFile-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zFile-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zFile\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zFilter
rem D:\zonide\CODE\visualstudio-backups\zFilter-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zFilter-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zFilter\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zLineCombine
rem D:\zonide\CODE\visualstudio-backups\zLineCombine-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zLineCombine-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zLineCombine\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zOblivionQuestCompare
rem D:\zonide\CODE\visualstudio-backups\zOblivionQuestCompare-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zOblivionQuestCompare-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zOblivionQuestCompare\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zProcess
rem D:\zonide\CODE\visualstudio-backups\zProcess-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zProcess-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zProcess\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zTf2Script
rem D:\zonide\CODE\visualstudio-backups\zTf2Script-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\zTf2Script-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zTf2Script\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\ShutDownTimer
rem D:\zonide\CODE\visualstudio-backups\ShutDownTimer-bk\vabbajacksandvich
set basep=D:\zonide\CODE\visualstudio-backups\ShutDownTimer-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\ShutDownTimer\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem making a back up for the main module too just in case
rem from D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster
set basep=D:\zonide\CODE\visualstudio-backups\zVabbajackSandvichModuleMaster-bk\vabbajacksandvich\
set "finalpath=%basep%%mytimestamp%"
set finalpath2=%finalpath: =_%
set finalpath3=%finalpath2:__=_%
set finalpath4=%finalpath3:_=-%
md %finalpath4%
set modulesource=D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb
xcopy %modulesource% %finalpath4% /f /h /r /y /j /d

rem explorer D:\zonide\CODE\visualstudio-backups

rem now to copy the main module in to each project folder from the main module folder

rem D:\zonide\code\visualstudio\gLog
set outpath=D:\zonide\code\visualstudio\gLog\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\Machine-Set-Calculator
set outpath=D:\zonide\code\visualstudio\Machine-Set-Calculator\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\Title-incrementor
set outpath=D:\zonide\code\visualstudio\Title-incrementor\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zBlocker
set outpath=D:\zonide\code\visualstudio\zBlocker\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zCodeGen
set outpath=D:\zonide\code\visualstudio\zCodeGen\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zFile
set outpath=D:\zonide\code\visualstudio\zFile\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zFilter
set outpath=D:\zonide\code\visualstudio\zFilter\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zLineCombine
set outpath=D:\zonide\code\visualstudio\zLineCombine\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zOblivionQuestCompare
set outpath=D:\zonide\code\visualstudio\zOblivionQuestCompare\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zProcess
set outpath=D:\zonide\code\visualstudio\zProcess\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\zTf2Script
set outpath=D:\zonide\code\visualstudio\zTf2Script\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

rem D:\zonide\code\visualstudio\ShutDownTimer
set outpath=D:\zonide\code\visualstudio\ShutDownTimer\
xcopy "D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster\vabbajacksandvich.vb" %outpath% /f /h /r /y /j /d

explorer D:\zonide\CODE\visualstudio-backups

explorer D:\zonide\code\visualstudio\zVabbajackSandvichModuleMaster

