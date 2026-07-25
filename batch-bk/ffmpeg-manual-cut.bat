rem 5-28-2024
rem this converts all files in the C:\vc\ directory
rem using ffmpeg
chdir /D: d:
cd C:\vc
rem decided against defragging
rem its going to get uploaded and deleted anyway
rem for defraggling the files first
rem i added C:\progra~1\defraggler
rem to the system path
rem for %%f in (*.mp4) do df "%%f"
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18  -ss 00:00:00 -t 00:15:00 "%%~nf_converted%%~xf"
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18 -preset veryfast -ss 00:00:00 -t 00:15:00 "%%~nf_converted%%~xf"
rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -crf 18 -preset ultrafast -ss 00:00:00 -t 00:15:00 "%%~nf_uf_converted%%~xf"

rem seeks on inputs go before inputs
rem -ss before -i

rem this is the one i use for chopping the end off
rem just change the time thing
for %%f in (*.mp4) do ffmpeg -y -ss 00:00:00 -to 00:04:44 -i "%%f" -c:v libx264 -crf 18 -preset ultrafast "%%~uf_t%%~xf"
