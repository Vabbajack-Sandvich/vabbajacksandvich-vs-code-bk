ipconfig /flushdns

rem making this disable the wifi too
netsh interface set interface "Wi-Fi" enable

timeout /t 3 /nobreak

rem enable ethernet
netsh interface set interface "Ethernet" enable

rem wait for it to enable
timeout /t 3 /nobreak

rem call enet.bat
call C:\enet2.bat

timeout /t 3 /nobreak

rem call C:\enet3.bat

rem timeout /t 4 /nobreak
rem pause

rem call ncpa.cpl
