rem ================================================
rem 2026-08-21-08-49-08-AM
rem runs the 7days to die backup batch
rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\junk\bat\bk-7days.bat
rem ================================================

rem set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%
rem echo %mydateformat%
rem set mydate=%mydateformat:/=-%
rem echo %mydate%
rem rem pause
rem rem exit /b
rem set mytime=%time::=%
rem set mytimestamp=%mydate: =_%_%mytime:.=_%
rem set mytimestamp=%mytimestamp: =%

rem call c.bat
rem call nr.bat
rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk
rem in folder
rem call repo-general-repo-update.bat > %mytimestamp%.txt
rem in specified foler

rem set "specifiedfolder=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\repo-update-logs\"

rem call "repo-general-repo-update.bat" > "%specifiedfolder%%mytimestamp%.txt"

rem call "repo-general-repo-update.bat" > "%specifiedfolder%%mytimestamp%.txt 2>&1" 

rem just call the batch in the cmd thing
cd C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\junk\bat
call bk-7days.bat
