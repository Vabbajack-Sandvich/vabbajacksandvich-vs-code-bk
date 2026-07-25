rem sr2
rem start rust 2
rem this just copies the cfg files
rem from the current edit directory
rem so that i can run the
rem global.exec keys.cfg
rem using the updated key binds
rem and not have to copy it manually
rem and not have to restart rust
rem while avoiding the added unwanted
rem keybinds that rust adds stupidly
rem xcopy "D:\zonide\gamebackups\rust\5-29-2024-0\cfg" "C:\Program Files (x86)\Steam\steamapps\common\Rust\cfg" /e /f /h /r /y /j

rem this moves the server-admin keys in to the rust folder

xcopy "D:\zonide\gamebackups\rust\admin-keys" "C:\Program Files (x86)\Steam\steamapps\common\Rust\cfg" /e /f /h /r /y /j

rem pause
