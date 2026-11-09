rem 2026-11-08-19-26-04-PM
rem rescale all jpgs to size
rem centers, add black bars, keeps aspect ratio

@echo off

cd c:\vc
md mpts

setlocal enabledelayedexpansion

for %%f in (*.jpg) do (
rem set filename=%%~nf.jpg
set filename=%%f
echo !filename!
ffmpeg -i "!filename!" -vf "scale=3264:2448:force_original_aspect_ratio=decrease,pad=3264:2448:(ow-iw)/2:(oh-ih)/2,setsar=1" "C:\vc\mpts\%%~nf.jpg"
)
