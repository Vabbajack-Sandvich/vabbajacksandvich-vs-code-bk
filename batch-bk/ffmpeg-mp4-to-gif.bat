rem this converts every mp4 in to gif
rem 2026-06-04-11-20-14-AM
cd C:\vc

for %%f in (*.mp4) do ffmpeg -y -i "%%f" "%%~nf.gif"

