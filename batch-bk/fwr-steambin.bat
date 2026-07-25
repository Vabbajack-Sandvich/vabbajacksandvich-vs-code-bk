for %%G in ("C:\Program Files (x86)\Steam\bin\*.exe") do (

netsh advfirewall firewall add rule name="AWB EXE %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB EXE %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

for %%G in ("C:\Program Files (x86)\Steam\bin\*.dll") do (

netsh advfirewall firewall add rule name="AWB DLL %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="AWB DLL %%G" dir=out action=allow program="%%G" enable=yes profile=any

)
