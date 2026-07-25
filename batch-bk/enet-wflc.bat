rem for wifi

netsh interface ipv4 set address name="Wi-Fi" static 192.168.100.20 255.255.255.0 192.168.100.1

netsh interface ipv4 delete dnsserver "Wi-Fi" all
netsh interface ipv6 delete dnsserver "Wi-Fi" all

netsh interface ipv4 add dnsserver "Wi-Fi" 192.168.100.1 index=1
netsh interface ipv4 add dnsserver "Wi-Fi" 192.168.100.10 index=2

ip
pause
