rem 2026-06-22-00-59-46-AM
rem ffmpeg-mp4-extract-each-frame-vsync
rem output at 30 fps
rem png

cd C:\vc


rem specific frame
rem ffmpeg -i input.mp4 -vf "fps=1" frame_%04d.png
rem Change to fps=1/60 to extract exactly one frame per minute.
rem Change to fps=5 to extract exactly 5 frames per second.

rem all frames
rem Using -vsync passthrough (or -fps_mode passthrough in newer versions) ensures that variable frame rate videos do not generate duplicate or dropped frames.
rem frame_%04d.png: The sequential naming pattern for your output files. %04d acts as a 4-digit zero-padded placeholder, resulting in filenames like frame_0001.png, frame_0002.png, etc. Change it to %05d if you expect more than 10,000 frames.
rem The -q:v 2 flag controls the JPEG quality (where 2 is excellent quality and 31 is worst
rem ffmpeg -i input.mp4 -vsync passthrough frame_%04d.png

rem default syntax thing to work from if i need other switches later
rem ffmpeg -y -i "%%f" -c:v libx264 -crf 30 -preset ultrafast -r 30 -filter_complex "[0:v]setpts=1.5*PTS[v];[0:a]atempo=0.5[a]" -map "[v]" -map "[a]" "%%~nf_halfslowerspeed.mp4"

rem testing
rem ffmpeg -y -i "Shnitzel.mp4" -vsync passthrough "frame_%04d.png"

rem 2026-06-25-04-51-50-AM
rem note: not sure why this doesnt
rem need double percents on %04d
rem it might? if it screws up
rem thats probably why

for %%f in (*.mp4) do (

ffmpeg -y -i "%%f" -vsync passthrough "%%nf_frame_%04d.png"

timeout /t 2 /nobreak
rem pause
rem move to temp
rem move /y "%%f" "c:\vc\t"

)
