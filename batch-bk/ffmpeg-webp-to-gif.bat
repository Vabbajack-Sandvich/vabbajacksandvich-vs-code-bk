rem this converts every webp in to gif

rem chdir /D d:
cd C:\vc

for %%f in (*.webp) do (
ffmpeg  -y -i "%%f" -loop 0 "%%~nf.gif"
)
