rem this is for
rem disabling the ethernet
rem enabling the wifi and connecting

rem disable ethernet
netsh interface set interface Ethernet disable

rem enable wifi
netsh interface set interface Wi-Fi enable

rem pause

rem wait for it to enable
timeout /t 2 /nobreak

rem pause

call enet.bat

rem pause

rem connect
netsh wlan connect ssid=ShaynePluisA name=ShaynePluisA interface=Wi-Fi

rem pause