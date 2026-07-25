rem satisfactory backup
rem C:\Users\Dragon\AppData\Local\FactoryGame
rem D:\zonide\gamebackups\my games\FactoryGame

xcopy "C:\Users\Dragon\AppData\Local\FactoryGame" "D:\zonide\gamebackups\mygame~1\FactoryGame" /e /f /h /r /y /j /d

pause

rem C:\Users\Dragon\Documents\my games\FactoryGame\Screenshots
rem D:\zonide\gamebackups\my games\FactoryGame\Screenshots

rem xcopy C:\Users\Dragon\Documents\my games\FactoryGame\Screenshots D:\zonide\gamebackups\my games\FactoryGame\Screenshots /e /f /h /r /y /j /d

rem pause

rem satisfactory screen shot backup
rem C:\Users\Dragon\Documents\my games\FactoryGame\Screenshots
rem D:\zonide\screenshots\satisfactory

xcopy "C:\Users\Dragon\Documents\my games\FactoryGame\Screenshots" "D:\zonide\screenshots\satisfactory" /e /f /h /r /y /j /d

pause

del /s /q "C:\Users\Dragon\Documents\my games\FactoryGame\Screenshots\*.*"

rem move /y "C:\Users\Dragon\Documents\my games\FactoryGame\Screenshots" "D:\zonide\screenshots\satisfactory"

pause

rem C:\Progra~2\Steam\userdata\57126545\760\remote\526870\screenshots

xcopy "C:\Progra~2\Steam\userdata\57126545\760\remote\526870\screenshots" "D:\zonide\screenshots\satisfactory" /e /f /h /r /y /j /d

pause

del /s /q "C:\Progra~2\Steam\userdata\57126545\760\remote\526870\screenshots\*.*"

pause