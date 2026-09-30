rem 2026-09-25-15-36-35-PM
rem asus
rem wifi only
rem connect to local home network

ipconfig /flushdns

netsh interface set interface "Wi-Fi" enable

netsh interface set interface "Ethernet" disable

timeout /t 2 /nobreak

call aenet-lan.bat

rem pause
