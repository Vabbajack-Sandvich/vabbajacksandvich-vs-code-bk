rem 5-28-2024
rem this is for concating cuts
rem this converts all files in the d:\vc\ directory
rem using ffmpeg
chdir /D: d:
cd D:\vc
rem decided against defragging
rem its going to get uploaded and deleted anyway
rem for defraggling the files first
rem i added C:\progra~1\defraggler
rem to the system path
rem for %%f in (*.mp4) do df "%%f"

rem file to be cut
rem 2024-05-28 08-24-14.mp4

rem seeks on inputs go before inputs
rem -ss before -i

rem first cut
ffmpeg -y -ss 00:00:00 -t 00:05:00 -i "2024-05-28 08-24-14.mp4" -c:v libx264 -crf 18 -preset ultrafast "2024-05-28-08-24-14_uf_trimmed-1.mp4"

rem second cut
ffmpeg -y -ss 00:05:37 -t 00:11:33 -i "2024-05-28 08-24-14.mp4" -c:v libx264 -crf 18 -preset ultrafast "2024-05-28-08-24-14_uf_trimmed-2.mp4"

rem make list of cuts
rem (for %%i in (*.mp4) do @echo file '%%i') > mylist.txt

rem concat cuts
rem ffmpeg -f concat -i mylist.txt -c:v libx264 -crf 18 -preset ultrafast -c copy "2024-05-28-08-24-14_uf_converted-2.mp4"
