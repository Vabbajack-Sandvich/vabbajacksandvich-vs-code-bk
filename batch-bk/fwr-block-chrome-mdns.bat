rem C:\Program Files\Google\Chrome

rem netsh advfirewall firewall add rule name="AWB EXE %%G" dir=in action=allow program="%%G" enable=yes profile=any
rem netsh advfirewall firewall add rule name="Block HTTP Outbound" protocol=TCP dir=out localport=80 action=block

for /R "C:\Program Files\Google\Chrome\" %%G in (*.exe) DO (
netsh advfirewall firewall add rule name="BWB-EXE-TCP-5353 %%G" protocol=TCP dir=in localport=5353 action=block program="%%G"
netsh advfirewall firewall add rule name="BWB-EXE-TCP-5353 %%G" protocol=TCP dir=out localport=5353 action=block program="%%G"
netsh advfirewall firewall add rule name="BWB-EXE-UDP-5353 %%G" protocol=UDP dir=in localport=5353 action=block program="%%G"
netsh advfirewall firewall add rule name="BWB-EXE-UDP-5353 %%G" protocol=UDP dir=out localport=5353 action=block program="%%G"
)

for /R "C:\Program Files\Google\Chrome\" %%G in (*.dll) DO (
netsh advfirewall firewall add rule name="BWB-DLL-TCP-5353 %%G" protocol=TCP dir=in localport=5353 action=block program="%%G"
netsh advfirewall firewall add rule name="BWB-DLL-TCP-5353 %%G" protocol=TCP dir=out localport=5353 action=block program="%%G"
netsh advfirewall firewall add rule name="BWB-DLL-UDP-5353 %%G" protocol=UDP dir=in localport=5353 action=block program="%%G"
netsh advfirewall firewall add rule name="BWB-DLL-UDP-5353 %%G" protocol=UDP dir=out localport=5353 action=block program="%%G"
)
