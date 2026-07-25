rem 3-3-2025
rem this is for ffmpeg
rem this does a lot
rem this:
rem goes through every mp4 in the directory
rem that the batch file is ran in
rem it uses a quality setting
rem preserving quality
rem and copying the frame rate and aspect
rem of the original video
rem this removes the meta data of the file
rem this runs on ultrafast so, it should be fast
rem turns up the gamma by .1
rem turns up the saturation by .3
rem adds an output extention of _ff
rem for filtered file

rem this works
rem for %%f in (*.mp4) do ffmpeg -i "%%f" -c copy -c:v libx264 -crf 20 -preset ultrafast -map_metadata -1 -vf eq=gamma=1.1:saturation=1.3 "%%~nf_ff.mp4"

for %%f in (*.mp4) do ffmpeg -i "%%f" -c copy -c:v libx264 -crf 20 -preset ultrafast -map_metadata -1 -vf eq=gamma=1.2:saturation=1.5 "%%~nf_ff.mp4"
