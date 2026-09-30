rem this is for
rem disabling the ethernet
rem enabling the wifi and connecting

rem disable ethernet
netsh interface set interface Ethernet disable

rem enable wifi
netsh interface set interface Wi-Fi disable

rem wait for it to disable
timeout /t 2 /nobreak

rem old working version
rem REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 0219066D76EE /f

rem adding this for random mac address
REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 0219066F76FE /f

timeout /t 2 /nobreak

rem enable wifi
netsh interface set interface Wi-Fi enable

rem pause

rem wait for it to enable
timeout /t 2 /nobreak

rem pause

call enet.bat

rem pause

rem connect
rem netsh wlan connect ssid=ShaynePLuisA name=ShaynePLuisA interface=Wi-Fi
netsh wlan connect ssid=ShaynePLuisA-2.4G name=ShaynePLuisA-2.4G interface=Wi-Fi

rem pause