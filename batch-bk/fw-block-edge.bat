rem for blocking eveything edge related
rem C:\Program Files (x86)\Microsoft

for /R "C:\Program Files (x86)\Microsoft\" %%G in (*.exe) DO (

netsh advfirewall firewall add rule name="BWB EXE %%G" dir=in action=block program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB EXE %%G" dir=out action=block program="%%G" enable=yes profile=any

)

for /R "C:\Program Files (x86)\Microsoft\" %%G in (*.dll) DO (

netsh advfirewall firewall add rule name="BWB DLL %%G" dir=in action=block program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB DLL %%G" dir=out action=block program="%%G" enable=yes profile=any

)

