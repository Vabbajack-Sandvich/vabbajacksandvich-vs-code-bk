rem for wifi

netsh interface ipv4 set address name="Wi-Fi" static 192.168.66.100 255.255.255.0 192.168.166.1

netsh interface ipv4 delete dnsserver "Wi-Fi" all
netsh interface ipv6 delete dnsserver "Wi-Fi" all

netsh interface ipv4 add dnsserver "Wi-Fi" 192.168.66.1 index=1

ip
pause
