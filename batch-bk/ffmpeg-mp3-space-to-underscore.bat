rem 2026-06-19-11-38-49-AM
rem mp3
rem space to dash
cd c:\vc
rem cd c:\vc\t

rem !variable:search=replace!
setlocal enabledelayedexpansion

for %%f in ("*.mp3") do (
set "filename=%%f"
echo "!filename!"
set "filename=!filename: =-!"
echo "!filename!"
ren "%%f" "!filename!"

)
