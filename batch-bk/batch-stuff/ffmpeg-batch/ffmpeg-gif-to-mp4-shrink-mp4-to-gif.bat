


rem ================================
rem to shrink
rem use zaspect to reduce the resolution
rem and or frame rate or bit rate
rem ================================



rem 2026-06-10-04-19-31-AM
rem version 2
rem just adding everything to just the one
rem this means that it will not do the same copies of the same conversion files
rem it also means it will easily do 1 copy and paste of multiple gifs to vc all at once

cd c:\vc

for %%f in (*.gif) do (
ffmpeg -i "%%f" -movflags faststart -pix_fmt yuv420p -vf "scale=trunc(iw/2)*2:trunc(ih/2)*2" "%%~nf_conv.mp4"
timeout /t 2 /nobreak
rem ffmpeg -y -i "%%~nf_conv.mp4" -c:v libx264 -b:v 500k -crf 30 -preset fast -vf scale=240:427 -r 24 "%%~nf_shrunk.mp4"
rem to shrink
rem use zaspect to reduce the resolution
ffmpeg -y -i "%%~nf_conv.mp4" -c:v libx264 -b:v 500k -crf 25 -preset fast -vf scale=380:674 -r 30 "%%~nf_shrunk.mp4"
timeout /t 2 /nobreak
ffmpeg -i "%%~nf_shrunk.mp4" "%%~nf_conv.gif"
timeout /t 2 /nobreak
)
