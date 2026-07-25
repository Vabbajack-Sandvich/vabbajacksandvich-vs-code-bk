rem this is from msi pov
rem copy batch files from d:\zonide to D:\
rem copy batch files from D:\ to d:\zonide

rem from there to z:\

rem mapped adminlt c:\zonide to local z drive

rem ------------------------------------------
rem copy bat updates
xcopy d:\zonide\*.bat D:\ /f /h /r /y /d

xcopy d:\*.bat D:\zonide\ /f /h /r /y /d

xcopy d:\zonide\*.bat e:\zonide /f /h /r /y /d

rem xcopy d:\zonide\*.bat Z:\ /f /h /r /y /d

xcopy d:\zonide\*.bat \\adminlt\zonide\ /f /h /r /y /d

pause