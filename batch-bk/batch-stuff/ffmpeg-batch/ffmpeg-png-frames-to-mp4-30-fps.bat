rem 2026-06-25-04-21-07-AM
rem frames to video

rem tldr
rem this is intended for one video
rem frame dump source
rem name_frame_####.png format
rem ffmpeg-mp4-extract-each-frame-vsync.bat
rem mp4 frame dump batch outputs
rem that anyway


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
rem name_frame_####.png format
rem which the frame dumping batch
rem file does output to anyway

@echo off

cd c:\vc

setlocal enabledelayedexpansion

for %%f in (*.png) do (

rem echo "%%~nf_frame_%04d.png"
rem echo "frame_%04d.png"
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
rem %%04d.png
rem so it can be passed to
rem the ffmpeg command
rem from the loop
set "filename=!filename!_frame_%%04d.png"
echo "!filename!"

rem ffmpeg -framerate 60 -y -i "%%~nf_frame_%04d.png" -c:v libx264 -pix_fmt yuv420p %%~nf_frame-to-vid.mp4

ffmpeg -framerate 30 -y -i "!filename!" -c:v libx264 -pix_fmt yuv420p %%~nf_frame-to-vid-30-fps.mp4

rem timeout /t 1 /nobreak
rem timeout /t 2 /nobreak

echo Loop broken!
GOTO EndOfLoop

)

:EndOfLoop
echo You are now outside the loop.