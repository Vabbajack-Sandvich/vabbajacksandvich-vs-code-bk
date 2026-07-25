rem 5-28-2024
rem this converts all files in the C:\vc\ directory
rem using ffmpeg
rem chdir /D d:
cd C:\vc

rem --------------------------------------

rem started with the shrinking bat
rem vcc

rem 20 was way to high at 5 megs bitrate
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 20 -preset ultrafast -vf scale=480:270 "%%~nf_uf_shrunk%%~xf"

rem this speeds up every mp4 in vc 4x

for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18 -preset ultrafast -r 60 -filter_complex "[0:v]setpts=0.125*PTS[v];[0:a]atempo=8.0[a]" -map "[v]" -map "[a]" "%%~nf_8x%%~xf"
