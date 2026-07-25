
rem outs

netsh advfirewall firewall add rule name="BWB System DLL cdp" dir=out action=block program="c:\windows\system32\cdp.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL cdprt" dir=out action=block program="c:\windows\system32\cdprt.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL cdpsvc" dir=out action=block program="c:\windows\system32\cdpsvc.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL cdpusersvc" dir=out action=block program="c:\windows\system32\cdpusersvc.dll" enable=yes profile=any

netsh advfirewall firewall add rule name="BWB System DLL wpnapps" dir=out action=block program="c:\windows\system32\wpnapps.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL wpnclient" dir=out action=block program="c:\windows\system32\wpnclient.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL wpncore" dir=out action=block program="c:\windows\system32\wpncore.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL wpninprc" dir=out action=block program="c:\windows\system32\wpninprc.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL wpnservice" dir=out action=block program="c:\windows\system32\wpnservice.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL WpnUserService" dir=out action=block program="c:\windows\system32\WpnUserService.dll" enable=yes profile=any

rem ins

netsh advfirewall firewall add rule name="BWB System DLL cdp" dir=in action=block program="c:\windows\system32\cdp.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL cdprt" dir=in action=block program="c:\windows\system32\cdprt.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL cdpsvc" dir=in action=block program="c:\windows\system32\cdpsvc.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL cdpusersvc" dir=in action=block program="c:\windows\system32\cdpusersvc.dll" enable=yes profile=any

netsh advfirewall firewall add rule name="BWB System DLL wpnapps" dir=in action=block program="c:\windows\system32\wpnapps.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL wpnclient" dir=in action=block program="c:\windows\system32\wpnclient.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL wpncore" dir=in action=block program="c:\windows\system32\wpncore.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL wpninprc" dir=in action=block program="c:\windows\system32\wpninprc.dll" enable=yes profile=any
netsh advfirewall firewall add rule name="BWB System DLL WpnUserService" dir=in action=block program="c:\windows\system32\WpnUserService.dll" enable=yes profile=any

