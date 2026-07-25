rem 5-11-2024-1511

rem the working editable version is in the D:\ directory
rem the others are backups or previous versions

rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\custom\mycustom\resource\ui
rem D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile
rem need a temp empty folder to copy the one from the tf2 folder in to
rem need a second temp folder that holds the one to be copied
rem name it like tf2-from-temp
rem name the second one tf2-to-temp
rem copy the one from the tf2 folder in to the first temp folder
rem copy the "to" one in to the tf2 folder from the "to" folder
rem copy the one that was copied first from the tf2-from-temp folder
rem in to the "to" folder
rem this should rotate the 2 files everytime using a batch command in the run window
rem this could act as a template to copy 2 files every time
rem it also seems like it could be expanded to more than 1 file in the cycle
rem the down side is read writes on the disk
rem but laziness
rem and not wanting to fucking change the slashes in the scoreboard.res file everytime
rem after having to do it manually everytime

rem trying robocopy to move instead of copy
rem xcopy "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\custom\mycustom\resource\ui" "" /f /h /r /y /j /d /e
rem xcopy "" "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\custom\mycustom\resource\ui" /f /h /r /y /j /d /e
rem xcopy "" "" /f /h /r /y /j /d /e

rem /mov is files only
rem /move is files and directories
rem robocopy from_folder to_folder files_to_copy /MOV
rem robocopy "" "" "" /MOV

rem tf2-from-temp
rem "D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-from-temp"
rem D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-from-temp

rem tf2-to-temp
rem "D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-to-temp"
rem D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-to-temp

rem i think it has to be progra~1

rem C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\resource\ui


robocopy "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\resource\ui" "D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-from-temp" "scoreboard.res" /MOV
rem pause
robocopy "D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-to-temp" "C:\Progra~2\Steam\steamapps\common\Teamfo~1\tf\custom\mycustom\resource\ui" "scoreboard.res" /MOV
rem pause
robocopy "D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-from-temp" "D:\zonide\gaming-stuff\tf2\scoreboard-swapout-batchfile\tf2-to-temp" "scoreboard.res" /MOV
rem pause

