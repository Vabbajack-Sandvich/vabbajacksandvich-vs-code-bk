rem this converts every m4a in to mp4

rem chdir /D d:
cd C:\vc

for %%f in (*.m4a) do (
ffmpeg  -y -i "%%f" -codec copy "%%~nf.mp4"
)
