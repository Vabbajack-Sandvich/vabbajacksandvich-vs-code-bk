rem for blocking eveything libreoffice related

rem D:\Program Files\LibreOffice

call d.bat

for /R "D:\Program Files\LibreOffice\" %%G in (*.exe) DO (

netsh advfirewall firewall add rule name="BWB EXE %%G" dir=in action=block program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB EXE %%G" dir=out action=block program="%%G" enable=yes profile=any

)

for /R "D:\Program Files\LibreOffice\" %%G in (*.dll) DO (

netsh advfirewall firewall add rule name="BWB DLL %%G" dir=in action=block program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB DLL %%G" dir=out action=block program="%%G" enable=yes profile=any

)

