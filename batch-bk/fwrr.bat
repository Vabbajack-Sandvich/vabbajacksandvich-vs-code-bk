rem for /r "C:\Program Files (x86)\Steam\" %%G in (*.dll) do (
rem 
rem netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
rem netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any
rem 
rem )

rem for /r "C:\Program Files (x86)\Steam\" %%G in (*.exe) do (

rem netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
rem netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

rem )


for /r "C:\Program Files\Softdeluxe\Free Download Manager\" %%G in (*.exe) do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

for /r "C:\Program Files\Softdeluxe\Free Download Manager\" %%G in (*.dll) do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)