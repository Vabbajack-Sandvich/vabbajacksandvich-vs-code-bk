rem 4-3-2025
rem this reencodes all mp4s in the directory
rem 480 270

rem chdir /D d:
cd C:\vc

for %%f in (*.mp4) do ffmpeg -i "%%f" -c:a copy -c:v libx264 -crf 20 -preset ultrafast -r 60 -vf "scale=480:270" "%%~nf_480_270%%~xf"
