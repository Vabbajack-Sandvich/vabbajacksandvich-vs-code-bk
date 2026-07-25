rem ================================================
rem 2026-07-07-07-58-17-AM
rem make a batch that makes a time stamped text file
rem and outputs the output of this to the text file
rem as a log
rem ================================================

set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%
echo %mydateformat%
set mydate=%mydateformat:/=-%
echo %mydate%
rem pause
rem exit /b
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%
set mytimestamp=%mytimestamp: =%

call c.bat
call nr.bat
rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk
rem in folder
rem call repo-general-repo-update.bat > %mytimestamp%.txt
rem in specified foler

set "specifiedfolder=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\repo-update-logs\"

rem call "repo-general-repo-update.bat" > "%specifiedfolder%%mytimestamp%.txt"

rem call "repo-general-repo-update.bat" > "%specifiedfolder%%mytimestamp%.txt 2>&1" 

rem just call the batch in the cmd thing
call repo-general-repo-update.bat

