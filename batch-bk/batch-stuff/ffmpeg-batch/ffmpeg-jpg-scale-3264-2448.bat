rem 2026-11-08-19-26-04-PM
rem rescale all jpgs to size
rem ffmpeg -i input.jpg -vf scale=800:600 output.jpg

@echo off

cd c:\vc
md mpts

setlocal enabledelayedexpansion

for %%f in (*.jpg) do (
rem set filename=%%~nf.jpg
set filename=%%f
echo !filename!
ffmpeg -i "!filename!" -vf scale=3264:2248 "C:\vc\mpts\%%~nf-scaled.jpg"
)
