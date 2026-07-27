rem 2026-06-30-05-56-15-AM
rem changes all jfif to png in directory
rem chdir /D d:

cd C:\vc
rem cd C:\downloads
for %%f in (*.jfif) do (
rem ffmpeg -y -i "%%f" "%%~nf.mp3"
echo "file - %%f"
ffmpeg -y -i "%%f" "%%~nf.png"
)

