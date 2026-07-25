rem changes all mp4 to mp3 in directory
chdir /D d:
cd D:\vc
rem pause
rem cd D:\downloads
for %%f in (*.mp4) do ffmpeg -i "%%f" -vn -c:a libmp3lame -qscale:a 4 "%%~nf.mp3"
pause
