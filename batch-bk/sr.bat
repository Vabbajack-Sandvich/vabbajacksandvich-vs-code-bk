rem starts rust using steam app
rem but after copying the cfg file
rem to make sure they havent been changed
rem steam://rungameid/252490
rem this one uses /d which only copies changed Files
rem which would make sense
rem except unless for some reason i opened the file
rem which changes the date on it
rem xcopy "D:\zonide\gamebackups\rust\9-25-2023-0\cfg" "C:\Program Files (x86)\Steam\steamapps\common\Rust\cfg" /e /f /h /r /y /j /d
rem this one doesnt use /date
rem which means it should just copy everything everytime
rem xcopy "D:\zonide\gamebackups\rust\9-25-2023-0\cfg" "C:\Program Files (x86)\Steam\steamapps\common\Rust\cfg" /e /f /h /r /y /j
rem xcopy "D:\zonide\gamebackups\rust\10-7-2023-0\cfg" "C:\Program Files (x86)\Steam\steamapps\common\Rust\cfg" /e /f /h /r /y /j
rem xcopy "D:\zonide\gamebackups\rust\10-9-2023-0\cfg" "C:\Program Files (x86)\Steam\steamapps\common\Rust\cfg" /e /f /h /r /y /j
rem D:\zonide\gamebackups\rust\10-15-2023-0
rem xcopy "D:\zonide\gamebackups\rust\10-15-2023-0\cfg" "C:\Program Files (x86)\Steam\steamapps\common\Rust\cfg" /e /f /h /r /y /j
rem this just calls the start rust batch
chdir /D d:
cd D:\zonide\gaming-stuff\rust
call rust-start.bat
