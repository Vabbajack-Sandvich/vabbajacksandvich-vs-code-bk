rem 3-7-2025
rem this reencodes all mp4s in the directory
rem 960 540

rem chdir /D d:
cd C:\vc

for %%f in (*.mp4) do ffmpeg -i "%%f" -c:a copy -c:v libx264 -crf 20 -preset ultrafast -r 60 -vf "scale=960:540" "%%~nf_re%%~xf"
