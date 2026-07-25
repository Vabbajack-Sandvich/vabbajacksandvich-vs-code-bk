rem 2026-06-30-05-57-06-AM
rem changes all ogg to mp3 in directory
rem chdir /D d:
cd C:\vc
rem cd C:\downloads
for %%f in (*.ogg) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
)
