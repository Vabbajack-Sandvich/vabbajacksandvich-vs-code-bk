rem update 6-19-2025
rem for copying source to C:\
rem old
rem xcopy "C:\zonide\ffmpeg-stuff\vc-batch-source" "C:\" /f /h /r /y /j /d
rem this copies the source files to the d drive
rem but only ones with changes
rem leaving any updates in either directory
rem while copying any updates to and from both spots
rem this will copy all batch files and is for a sync update only
rem you have to remove any non ffmpeg batch files

rem xcopy "C:\zonide\ffmpeg-stuff\ffmpeg-batch\*.bat" "C:\" /f /h /r /y /j /d
rem xcopy "C:\*.bat" "C:\zonide\ffmpeg-stuff\ffmpeg-batch" /f /h /r /y /j /d

rem this only copies updates from the source directory to the d drive
xcopy "C:\zonide\ffmpeg-stuff\ffmpeg-batch" "C:\" /f /h /r /y /j /d
pause