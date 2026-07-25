rem 5-28-2024
rem this converts all files in the d:\vc\ directory
rem using ffmpeg
chdir /D d:
cd D:\vc
rem decided against defragging
rem its going to get uploaded and deleted anyway
rem for defraggling the files first
rem i added C:\progra~1\defraggler
rem to the system path
rem for %%f in (*.mp4) do df "%%f"
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18  -ss 00:00:00 -t 00:15:00 "%%~nf_converted%%~xf"
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18 -preset veryfast -ss 00:00:00 -t 00:15:00 "%%~nf_converted%%~xf"
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18 -preset ultrafast -ss 00:00:00 -t 00:15:00 "%%~nf_uf_converted%%~xf"

rem raw shrink command with no loop
rem ffmpeg -y -i "D:\video-edits\weed\20220715_102852.mp4" -vf scale=960:540 -c:v libx264 -c:a copy -b:v 500K "D:\video-edits\weed\20220715_102852_shrink.mp4"

rem this worked for a 3 minute video at 2.66 gigs
rem and got it down to 12.7 megs without horrible quality
rem this is for shrinking the video for discord
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18 -preset ultrafast -vf scale=960:540 -c:a copy -b:v 500K "%%~nf_uf_shrunk%%~xf"
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 40 -preset ultrafast -vf scale=960:540 "%%~nf_uf_shrunk%%~xf"

rem trying 35 for better quality
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 35 -preset ultrafast -vf scale=960:540 "%%~nf_uf_shrunk%%~xf"

rem dont want to go below 35
rem so i think im going to go to 20
rem then try to shrink the resolution more
rem so its higher quality but less pixels
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 20 -preset ultrafast -vf scale=480:270 "%%~nf_uf_shrunk%%~xf"

rem --------------------------------------
rem this is the working one
rem any other should be vartions of this one
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 30 -preset ultrafast -vf scale=480:270 "%%~nf_uf_shrunk%%~xf"
rem --------------------------------------

rem 20 was way to high at 5 megs bitrate

rem this is for 1920 1080
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 20 -preset ultrafast -vf scale=480:270 "%%~nf_shrunk%%~xf"

rem this is for the bugs bunny video
rem w 640 h 464
rem w 512 h 372
rem made the file twice the size lol
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 20 -preset ultrafast -vf scale=512:372 "%%~nf_shrunk%%~xf"

rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -b:v 340k -preset ultrafast -vf scale=640:464 "%%~nf_shrunk%%~xf"

rem for %%f in (*.mkv) do ffmpeg -y -i "%%f" -c:v libx264 -b:v 340k -preset ultrafast -vf scale=640:464 "%%~nf_shrunk%%~xf"

rem higher quality shrink
rem for %%f in (*.mkv) do ffmpeg -y -i "%%f" -c:v libx264 -b:v 800k -crf 25 -preset slow -vf scale=640:464 -r 60 "%%~nf_shrunk%%~xf"

rem this works really well to preserve quality with small file size at 60 fps
rem for clips around 1 min

for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -b:v 500k -crf 25 -preset slow -vf scale=640:464 -r 60 "%%~nf_shrunk%%~xf"



