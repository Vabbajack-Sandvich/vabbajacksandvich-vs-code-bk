rem 3-7-2025
rem this combines 4 videos in a 2x2 grid
rem the videos have to be the same
rem resolution and framerate
rem 1920 1080

rem chdir /D d:
cd C:\vc

rem make working copies manually
rem leave the orginals
rem rename the working copies 1 2 3 4

rem not sure if i need to specify the scale

rem ffmpeg -i 1.mp4 -i 2.mp4 -i 3.mp4 -i 4.mp4 -filter_complex "[0:v][1:v]hstack=inputs=2[top];[2:v][3:v]hstack=inputs=2[bottom];[top][bottom]vstack=inputs=2[v]" -map "[v]" out-2x2.mp4


rem doesnt work
rem ffmpeg -i 1.mp4 -i 2.mp4 -i 3.mp4 -i 4.mp4 -c:v libx264 -crf 20 -preset ultrafast -r 60 -vf "scale=1920:1080" -filter_complex "[0:v][1:v]hstack=inputs=2[top];[2:v][3:v]hstack=inputs=2[bottom];[top][bottom]vstack=inputs=2[v]" -map "[v]" out-2x2.mp4

ffmpeg -i 1.mp4 -i 2.mp4 -i 3.mp4 -i 4.mp4 -c:v libx264 -crf 20 -preset ultrafast -r 60 -filter_complex "[0:v][1:v]hstack=inputs=2[top];[2:v][3:v]hstack=inputs=2[bottom];[top][bottom]vstack=inputs=2[v]" -map "[v]" out-2x2.mp4