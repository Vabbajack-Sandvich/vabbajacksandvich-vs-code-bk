rem 2026-06-20-22-51-45-PM
rem cleaned up remarks
rem added notes

rem 2026-06-02-20-27-22-PM
rem chdir /D d:
rem cd D:\vc
cd c:\vc

rem bf = bframes = normal 2 or 3
rem -b:v 1m = bitrate = m megabits k kilobits
rem default
rem ffmpeg -y -i "%%f" -c:v libx264 -bf 10 -b:v 1m -crf 30 -preset fast -vf scale=1200:675 -r 30 "%%~nf_shrunk%%~xf"

rem when using zAspect
rem to shrink using aspect ratios
rem cant have odd numbers
rem 675 will error
rem 676 will not

for %%f in (*.mp4) do (

rem ffmpeg -y -i "%%f" -c:v libx264 -bf 10 -b:v 2M -crf 30 -preset fast -vf scale=500:890 -r 30 "%%~nf_shrunk%%~xf"
rem basically run the video through the same thing
rem but with the ffmpeg codec for 1920 1080
rem and 10 bframe if it will accept that
rem ffmpeg -y -i "%%f" -c:v libx264 -bf 10 -b:v 2M -crf 20 -preset fast -vf scale=1920:1080 -r 60 "%%~nf_shrunk%%~xf"
ffmpeg -y -i "%%f" -c:v libx264 -bf 10 -b:v 2M -crf 20 -preset fast -vf scale=1920:1080 -r 60 "%%~nf_shrunk%%~xf"

)
