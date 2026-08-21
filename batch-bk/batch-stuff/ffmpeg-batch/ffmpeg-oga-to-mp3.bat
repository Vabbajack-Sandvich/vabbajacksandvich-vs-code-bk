rem 2026-08-18-05-36-20-AM
rem this converts every oga in to mp3
cd C:\vc

for %%f in (*.oga) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
)
