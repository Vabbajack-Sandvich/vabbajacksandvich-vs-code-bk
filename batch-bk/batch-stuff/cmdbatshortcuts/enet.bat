rem this sets the wi-fi direct default gateway after i turn it on
rem netsh interface ipv4 set address name="Ethernet" static 192.166.121.148 255.255.255.0 192.166.121.254
rem netsh interface ipv4 set address name="Ethernet" static 182.166.12.140 255.255.255.0 182.166.12.254

rem netsh interface ipv4 set address name="Ethernet" static 181.156.111.88 255.255.255.0 181.156.111.254

rem netsh interface ipv4 set address name="Ethernet" static 171.136.121.58 255.255.255.0 171.136.121.254

rem netsh interface ipv4 set address name="Ethernet" static 171.126.131.148 255.255.255.0 171.126.131.254

rem netsh interface ipv4 set address name="Ethernet" static 131.116.111.186 255.255.255.0 131.116.111.254

rem 192.166.122.50
rem 192.166.12.150
rem 182.166.12.254
rem 181.156.11.254
rem 181.156.111.254
rem 171.136.121.60
rem 30 60
rem 171.126.131.254
rem 120 150
rem 131.116.111.254
rem 150 to 190

rem new internet default
rem 192.168.18.15
rem 192.168.18.1

netsh interface ipv4 set address name="Ethernet" static 192.168.18.87 255.255.255.0 192.168.18.1

rem clear all dns servers
rem to clear them all
rem because setting them doesnt work
rem only re adding them after clearing
rem them works consistantly
netsh interface ipv4 delete dnsserver "Ethernet" all
netsh interface ipv6 delete dnsserver "Ethernet" all

rem 74.40.74.40
rem 74.40.74.41
rem netsh interface ipv4 add dnsserver "Ethernet" 74.40.74.40 index=1
rem netsh interface ipv4 add dnsserver "Ethernet" 74.40.74.41 index=2

netsh interface ipv4 add dnsserver "Ethernet" 192.168.18.1 index=1
rem netsh interface ipv4 add dnsserver "Ethernet" 8.8.8.8 index=2

rem dns google
rem this works to set the dns for
rem only the first one
rem and occasionally adds it as a 3rd server
rem netsh interface ip set dns "Ethernet" static 8.8.8.8

rem for wifi

netsh interface ipv4 set address name="Wi-Fi" static 192.168.18.112 255.255.255.0 192.168.18.1

netsh interface ipv4 delete dnsserver "Wi-Fi" all
netsh interface ipv6 delete dnsserver "Wi-Fi" all

netsh interface ipv4 add dnsserver "Wi-Fi" 192.168.18.1 index=1
rem netsh interface ipv4 add dnsserver "Wi-Fi" 8.8.8.8 index=2

rem ip

rem pause
