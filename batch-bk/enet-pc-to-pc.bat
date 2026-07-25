rem this sets the wi-fi direct default gateway after i turn it on
netsh interface ipv4 set address name="Ethernet" static 192.168.1.10 255.255.255.0 192.168.1.1
netsh interface ipv4 delete dnsserver "Ethernet" all
netsh interface ipv6 delete dnsserver "Ethernet" all
netsh interface ipv4 add dnsserver "Ethernet" 192.168.1.1 index=1
pause
