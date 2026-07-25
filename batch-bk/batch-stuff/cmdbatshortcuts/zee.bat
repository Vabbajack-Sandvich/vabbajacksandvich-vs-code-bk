ipconfig /flushdns

rem making this disable the wifi too
netsh interface set interface "Wi-Fi" disable

rem enable ethernet
netsh interface set interface "Ethernet" enable

rem wait for it to enable
timeout /t 2 /nobreak

rem call enet.bat
call C:\enet2.bat

rem pause