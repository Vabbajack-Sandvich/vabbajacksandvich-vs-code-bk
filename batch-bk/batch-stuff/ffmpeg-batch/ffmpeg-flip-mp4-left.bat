
rem 2026-06-10-10-28-51-AM
rem converts every video to 90 degrees left
rem ffmpeg -i input.mp4 -vf "transpose=1" -c:a copy output.mp4
rem transpose
rem 1 right
rem 2 left

cd c:\vc

for %%f in (*.mp4) do (
rem ffmpeg -i input.mp4 -vf "transpose=1" -c:a copy output.mp4
ffmpeg -i "%%f" -vf "transpose=2" -c:a copy "%%~nf_left.mp4"
timeout /t 2 /nobreak
)
