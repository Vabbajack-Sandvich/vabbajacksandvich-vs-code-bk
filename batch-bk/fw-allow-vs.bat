rem D:\Program Files\Microsoft Visual Studio

for /R "D:\Program Files\Microsoft Visual Studio\" %%G in (*.exe) DO (

netsh advfirewall firewall add rule name="AWB EXE %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB EXE %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

for /R "D:\Program Files\Microsoft Visual Studio\" %%G in (*.dll) DO (

netsh advfirewall firewall add rule name="AWB DLL %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB DLL %%G" dir=out action=allow program="%%G" enable=yes profile=any

)
