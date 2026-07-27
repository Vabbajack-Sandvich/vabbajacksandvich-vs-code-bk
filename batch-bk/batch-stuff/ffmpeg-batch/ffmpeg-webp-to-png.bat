rem 2026-07-27-10-08-44-AM
rem changes all webp to png in directory
rem chdir /D d:

cd C:\vc
rem cd C:\downloads
for %%f in (*.webp) do (
rem ffmpeg -y -i "%%f" "%%~nf.mp3"
echo "file - %%f"
ffmpeg -y -i "%%f" "%%~nf.png"
)

