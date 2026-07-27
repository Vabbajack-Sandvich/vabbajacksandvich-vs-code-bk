rem 2026-07-27-10-08-44-AM
rem changes all png to jpg in directory
rem chdir /D d:

cd C:\vc
rem cd C:\downloads
for %%f in (*.png) do (
rem ffmpeg -y -i "%%f" "%%~nf.mp3"
echo "file - %%f"
ffmpeg -y -i "%%f" "%%~nf.jpg"
)

