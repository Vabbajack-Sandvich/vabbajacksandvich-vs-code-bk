rem 2026-06-19-01-32-49-AM
rem have to guess the bitrate this way
rem wont work right
rem ffmpeg -i input.mp3 -filter:a "asetrate=22050" output.mp3

rem this converts every m4a in to mp3
rem then converts the mp4 to the slower version
rem then converts it back to mp3

cd C:\vc

rem this converts every m4a in to mp3
for %%f in (*.m4a) do (
ffmpeg -y -i "%%f" "%%~nf_c.mp3"
timeout /t 2 /nobreak
rem delete m4a
del /f /q "%%f"

)

timeout /t 2 /nobreak
rem pause

rem then converts the mp4 to the slower version
for %%f in (*.mp3) do (
rem atempo=0.25 - quarter lower slower speed
rem atempo=0.5 - half lower slower speed
rem atempo=0.67 - 2 thirds lower slower speed
rem atempo=1 - normal speed
rem atempo=1.5 - faster higher speed
rem atempo=2 - double faster higher speed
ffmpeg -y -i "%%f" -c:v libx264 -crf 20 -preset ultrafast -r 60 -filter_complex "[0:a]atempo=0.67[a]" -map "[a]" "%%~nf_2thirdslowerspeed.mp3"
timeout /t 2 /nobreak
rem pause
rem move to temp
rem move /y "%%f" "c:\vc\t"

)

timeout /t 2 /nobreak
rem pause

