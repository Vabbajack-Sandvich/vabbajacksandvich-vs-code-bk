rem 2026-06-30-05-56-15-AM
rem changes all mp4 to mp3 in directory
rem chdir /D d:
cd C:\vc
rem cd C:\downloads
for %%f in (*.mp4) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
)
