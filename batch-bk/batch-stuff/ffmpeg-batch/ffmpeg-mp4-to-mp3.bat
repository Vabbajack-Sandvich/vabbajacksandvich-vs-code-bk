rem 2026-06-30-05-56-15-AM
rem changes all mp4 to mp3 in directory
rem chdir /D d:

rem 2026-07-14-20-45-04-PM
rem updating this to use the lame encoder
rem apparently the mp3s from mp4s from previous
rem conversions without the lame encoder
rem still use aac and ffmpeg doesnt like it
rem when dealing with mp3s
rem ffmpeg -i input.mp4 -vn -c:a libmp3lame output.mp3

cd C:\vc
rem cd C:\downloads
for %%f in (*.mp4) do (
rem ffmpeg -y -i "%%f" "%%~nf.mp3"
ffmpeg -y -i "%%f" -vn -c:a libmp3lame "%%~nf.mp3"
)
