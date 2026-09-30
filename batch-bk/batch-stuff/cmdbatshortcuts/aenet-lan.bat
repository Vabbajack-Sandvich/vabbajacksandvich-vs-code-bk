
netsh interface ipv4 set address name="Wi-Fi" static 192.168.18.125 255.255.255.0 192.168.18.1

netsh interface ipv4 delete dnsserver name="Wi-Fi" all
netsh interface ipv6 delete dnsserver name="Wi-Fi" all

netsh interface ipv4 add dnsserver name="Wi-Fi" 8.8.8.8 index=1

netsh wlan connect ssid=ShaynePLuisA-2.4G name=ShaynePLuisA-2.4G interface=Wi-Fi
