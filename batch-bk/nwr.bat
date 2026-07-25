rem network reset
netsh int ip reset
netsh winsock reset
ipconfig /release
ipconfig /renew
ipconfig /flushdns
ipconfig /registerdns
NETSH winsock reset catalog
NETSH int ipv4 reset reset.log
NETSH int ipv6 reset reset.log
netsh interface ipv4 set address name="Ethernet" static 182.166.12.149 255.255.255.0 182.166.12.254
pause
