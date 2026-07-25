rem this is from msi pov
rem copy batch files from d:\zonide to D:\ and reversed
rem then from there to \\adminlt\c\zonide

rem ------------------------------------------
rem copy bat updates

xcopy d:\zonide\*.bat D:\ /f /h /r /y /d

xcopy d:\*.bat D:\zonide\ /f /h /r /y /d

rem xcopy d:\*.bat \\adminlt\c\zonide /f /h /r /y /d

rem xcopy \\adminlt\c\zonide\*.bat \\adminlt\f\zonide /f /h /r /y /d





