rem 2026-06-19-01-32-49-AM
rem have to guess the bitrate this way
rem wont work right
rem ffmpeg -i input.mp3 -filter:a "asetrate=22050" output.mp3

rem this converts every m4a in to mp3
rem then converts the mp4 to the slower version
rem then converts it back to mp3

cd C:\vc

rem then converts the mp4 to the slower version
for %%f in (*.mp4) do (
rem =======================================
rem for audio		- atempo
rem atempo=0.5		- half lower slower speed
rem atempo=0.67		- 2 thirds lower slower speed
rem atempo=1		- normal speed
rem atempo=1.25		- quarter faster higher speed
rem atempo=1.5		- faster higher speed
rem atempo=1.67		- two thirds faster higher speed
rem atempo=2		- double faster higher speed
rem =======================================
rem for video		- setpts
rem the numbers go backward compared
rem to atempo
rem setpts=2.0		- half slower speed
rem setpts=1.67		- two thirds slower speed
rem setpts=1.5		- half slower speed
rem setpts=1.25		- quarter slower speed
rem setpts=1		- normal speed
rem setpts=0.5		- 2x faster speed
rem setpts=0.25		- 4x faster speed

rem ffmpeg -y -i "%%f" -c:v libx264 -crf 20 -preset ultrafast -r 60 -filter_complex "[0:a]atempo=0.67[a]" -map "[a]" "%%~nf_2thirdslowerspeed.mp3"

ffmpeg -y -i "%%f" -c:v libx264 -crf 30 -preset ultrafast -r 30 -filter_complex "[0:v]setpts=1.5*PTS[v];[0:a]atempo=0.5[a]" -map "[v]" -map "[a]" "%%~nf_halfslowerspeed.mp4"

timeout /t 2 /nobreak
rem pause
rem move to temp
rem move /y "%%f" "c:\vc\t"

)
