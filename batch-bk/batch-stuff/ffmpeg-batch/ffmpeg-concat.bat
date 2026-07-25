rem 5-28-2024
rem this is for concating cuts
rem this converts all files in the C:\vc\ directory
rem using ffmpeg
rem chdir /D d:
cd C:\vc
rem decided against defragging
rem its going to get uploaded and deleted anyway
rem for defraggling the files first
rem i added C:\progra~1\defraggler
rem to the system path
rem for %%f in (*.mp4) do df "%%f"

rem file to be cut
rem 2024-05-28 08-24-14.mp4

rem first cut
rem ffmpeg -y -i "2024-05-28 08-24-14.mp4" -c:v libx264 -crf 18 -preset ultrafast -ss 00:00:00 -t 00:05:00 "2024-05-28-08-24-14_uf_converted-1.mp4"

rem second cut
rem ffmpeg -y -i "2024-05-28 08-24-14.mp4" -c:v libx264 -crf 18 -preset ultrafast -ss 00:05:37 -t 00:11:33 "2024-05-28-08-24-14_uf_converted-2.mp4"

rem make list of cuts
(for %%i in (*.mp4) do @echo file '%%i') > mylist.txt

rem this is to make sure that the files are in order
pause

rem concat cuts
rem ffmpeg -f concat -safe 0 -i mylist.txt -c:v libx264 -crf 18 -preset ultrafast -c copy "uf_concat.mp4"
ffmpeg -f concat -safe 0 -i mylist.txt -c:v libx264 -crf 18 -preset ultrafast -c copy "_ufcc.mp4"

pause