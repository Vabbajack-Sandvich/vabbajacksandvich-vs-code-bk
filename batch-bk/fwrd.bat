for %%G in ("C:\Program Files (x86)\Steam\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem C:\Program Files (x86)\Steam\bin\cef\cef.win7

for %%G in ("C:\Program Files (x86)\Steam\bin\cef\cef.win7\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem C:\Program Files (x86)\Steam\bin\cef\cef.win7x64

for %%G in ("C:\Program Files (x86)\Steam\bin\cef\cef.win7x64\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\bin


for %%G in ("C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\bin\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\bin\x64


for %%G in ("C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\bin\x64\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2

for %%G in ("C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\bin

for %%G in ("C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\bin\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

rem C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\bin\tools

for %%G in ("C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\bin\tools\*.dll") do (

netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=in action=allow program="%%G" enable=yes profile=any
netsh advfirewall firewall add rule name="Allowed With Batchfile %%G" dir=out action=allow program="%%G" enable=yes profile=any

)

