
rem netsh interface ipv4 set address name="Ethernet" static 192.168.18.215 255.255.255.0 192.168.18.1

netsh interface ipv4 set address name="Ethernet" static 192.168.18.124 255.255.255.0 192.168.18.1

netsh interface ipv4 delete dnsserver name="Ethernet" all
netsh interface ipv6 delete dnsserver name="Ethernet" all

rem netsh interface ipv4 add dnsserver name="Ethernet" 192.168.18.1 index=1

netsh interface ipv4 add dnsserver name="Ethernet" 8.8.8.8 index=1

rem for wifi

rem netsh interface ipv4 set address name="Wi-Fi" static 192.168.18.122 255.255.255.0 192.168.18.1

rem netsh interface ipv4 delete dnsserver "Wi-Fi" all
rem netsh interface ipv6 delete dnsserver "Wi-Fi" all

rem netsh interface ipv4 add dnsserver "Wi-Fi" 192.168.18.1 index=1

rem ip

rem pause
