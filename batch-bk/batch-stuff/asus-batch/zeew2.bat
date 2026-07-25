
rem disable ethernet
netsh interface set interface Ethernet disable
netsh interface set interface Wi-Fi disable
rem wait for it to disable
timeout /t 2 /nobreak
rem generate random mac command
REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 027F325A9019 /f
rem wait to make sure it executed
timeout /t 2 /nobreak
rem enable wifi
netsh interface set interface Wi-Fi enable
rem wait to make sure it enabled
timeout /t 2 /nobreak
rem random ip command for the wifi adapter
netsh interface ipv4 set address name=Wi-Fi static 192.168.18.162 255.255.255.0 192.168.18.1
rem connect
netsh wlan connect ssid=ShaynePLuisA-2.4G name=ShaynePLuisA-2.4G interface=Wi-Fi