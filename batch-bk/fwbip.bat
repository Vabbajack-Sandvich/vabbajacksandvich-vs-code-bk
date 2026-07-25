netsh advfirewall firewall add rule name="block 172.64.145.54" dir=in action=block remoteip="172.64.145.54"
netsh advfirewall firewall add rule name="block 172.64.145.54" dir=out action=block remoteip="172.64.145.54"
