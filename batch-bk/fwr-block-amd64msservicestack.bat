rem C:\Windows\WinSxS\amd64_microsoft-windows-servicingstack_31bf3856ad364e35_10.0.19041.5853_none_7de3a0ec7cad0695

rem for blocking eveything tiworker related

for /R "C:\Windows\WinSxS\amd64_microsoft-windows-servicingstack_31bf3856ad364e35_10.0.19041.5853_none_7de3a0ec7cad0695\" %%G in (*.exe) DO (

netsh advfirewall firewall add rule name="BWB EXE %%G" dir=in action=block program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB EXE %%G" dir=out action=block program="%%G" enable=yes profile=any

)

for /R "C:\Windows\WinSxS\amd64_microsoft-windows-servicingstack_31bf3856ad364e35_10.0.19041.5853_none_7de3a0ec7cad0695e\" %%G in (*.dll) DO (

netsh advfirewall firewall add rule name="BWB DLL %%G" dir=in action=block program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB DLL %%G" dir=out action=block program="%%G" enable=yes profile=any

)

