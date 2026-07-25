rem this converts every webp in to jpg

rem chdir /D d:
cd C:\vc

for %%f in (*.webp) do (
ffmpeg  -y -i "%%f" -codec copy "%%~nf.jpg"
)
