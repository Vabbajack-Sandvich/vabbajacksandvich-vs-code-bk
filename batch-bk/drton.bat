rem drt.bat
rem drt stands for disable real time
rem 5-13-2024-1416
rem this uses cmd LOL to run a power shell command
rem powershell Set-MpPreference -DisableRealtimeMonitoring $true
rem which disables realtime protection

rem powershell Set-MpPreference -DisableRealtimeMonitoring $true > D:\drt.txt

powershell Set-MpPreference -DisableRealtimeMonitoring $false

rem pause
