rem =========================================
rem 2026-11-08-02-58-04-AM
rem updating to 6 fps
rem 250 ms per frame
rem for jpg to mp4
rem note
rem use
rem ffmpeg-jpg-images-rename-to-name-frame-0000.bat
rem with jpg files in c:\vc
rem to name them in the proper format first
rem =========================================
rem 2026-11-08-00-42-49-AM
rem editing this to be for compressing images
rem in to a video using 2 frames per second
rem so that way it takes a whole folder
rem of images and makes it so you can
rem store them as a video
rem then i can extract the frames later
rem at 2 fps it should be 1 frame every 500 ms
rem 1 frame every half second
rem should have a cool time lapse effect
rem if the images are sorted by date
rem =========================================
rem 2026-06-25-04-21-07-AM
rem frames to video
rem =========================================
rem tldr
rem this is intended for one video
rem frame dump source
rem name_frame_####.jpg format
rem ffmpeg-mp4-extract-each-frame-vsync.bat
rem mp4 frame dump batch outputs
rem that anyway
rem =========================================
rem this runs a file loop once
rem then breaks it after it runs
rem it does this to easily get the
rem first file name
rem then break it down by removing
rem _frame_0001 from %%~nf
rem which just leaves the file name
rem prefix itsself
rem kind of "cheating"
rem but it works
rem this means it is intended to only do
rem one video from one source of frames
rem this just makes it so you dont have
rem to edit the batch file
rem and can copy and paste a whole
rem frame dumped video in
rem name_frame_####.jpg format
rem which the frame dumping batch
rem file does output to anyway

@echo off

cd c:\vc

setlocal enabledelayedexpansion

for %%f in (*.jpg) do (

rem echo "%%~nf_frame_%04d.jpg"
rem echo "frame_%04d.jpg"
rem set filename=%%f
rem echo !filename!
rem set filename=!filename: =-!
rem echo !filename!

set filename=%%~nf
echo !filename!
rem have to remove the _frame_0001 from %%~nf
rem setting to null
set "filename=!filename:_frame_0001=!"
echo "!filename!"
rem double %% fixed this
rem %%04d.jpg
rem so it can be passed to
rem the ffmpeg command
rem from the loop
set "filename=!filename!_frame_%%04d.jpg"
echo "!filename!"

rem ffmpeg -framerate 60 -y -i "%%~nf_frame_%04d.jpg" -c:v libx264 -pix_fmt yuv420p %%~nf_frame-to-vid.mp4

ffmpeg -framerate 6 -y -i "!filename!" -c:v libx264 -pix_fmt yuv420p %%~nf_frame-to-vid-6-fps.mp4

rem timeout /t 1 /nobreak
rem timeout /t 2 /nobreak

echo Loop broken!
GOTO EndOfLoop

)

:EndOfLoop
echo You are now outside the loop.