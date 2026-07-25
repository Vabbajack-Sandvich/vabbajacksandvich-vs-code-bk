rem this converts every m4a in to mp3
@echo off
setlocal enabledelayedexpansion

cd C:\vc

for %%f in (*.m4a) do (
echo "file - %%f"
ffmpeg -y -i "%%f" "%%~nf.mp3"
echo "deleting - %%f"
del /f /q "%%f"
)
