rem 3-7-2025
rem this rencodes all mp4s in the directory
rem 3840 2160

chdir /D d:
cd D:\vc

for %%f in (*.mp4) do ffmpeg -i "%%f" -c:a copy -c:v libx264 -crf 20 -preset ultrafast -r 60 -vf "scale=3840:2160" "%%~nf_re%%~xf"

pause