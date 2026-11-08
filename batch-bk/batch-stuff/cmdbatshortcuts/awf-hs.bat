rem this disables both now

rem disable wifi
netsh interface set interface Wi-Fi disable

rem disable ethernet
netsh interface set interface Ethernet disable

rem pause

timeout /t 5 /nobreak

rem enable wifi
netsh interface set interface Wi-Fi enable

timeout /t 5 /nobreak

netsh interface ipv4 set address name="Wi-Fi" static 192.168.137.110 255.255.255.0 192.168.137.1

netsh interface ipv4 delete dnsserver name="Wi-Fi" all

netsh interface ipv6 delete dnsserver name="Wi-Fi" all

netsh interface ipv4 add dnsserver name="Wi-Fi" 8.8.8.8 index=1

timeout /t 3 /nobreak

rem netsh wlan connect ssid=Xfinity-I824 name=Xfinity-I824 interface=Wi-Fi

rem enable wifi
rem netsh interface set interface Wi-Fi enable

timeout /t 5 /nobreak

netsh wlan connect ssid=Xfinity-1824 name=Xfinity-1824 interface=Wi-Fi
