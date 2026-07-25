rem C:\Program Files\Google\Chrome
for /R "C:\Program Files\Google\Chrome\" %%G in (*.exe) DO (

netsh advfirewall firewall add rule name="AWB EXE %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB EXE %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem for %%G in ("C:\Program Files (x86)\Steam\*.dll") do (
for /R "C:\Program Files\Google\Chrome\" %%G in (*.dll) DO (

netsh advfirewall firewall add rule name="AWB DLL %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB DLL %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

