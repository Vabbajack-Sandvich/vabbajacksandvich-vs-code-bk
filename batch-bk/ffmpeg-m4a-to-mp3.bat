rem this converts every m4a in to mp3
cd C:\vc

for %%f in (*.m4a) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
)
