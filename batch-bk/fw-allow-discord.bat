rem C:\Users\zonid\AppData\Local\Discord
for /R "C:\Users\zonid\AppData\Local\Discord\" %%G in (*.exe) DO (

netsh advfirewall firewall add rule name="AWB EXE %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB EXE %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

for /R "C:\Users\zonid\AppData\Local\Discord\" %%G in (*.dll) DO (

netsh advfirewall firewall add rule name="AWB DLL %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB DLL %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

