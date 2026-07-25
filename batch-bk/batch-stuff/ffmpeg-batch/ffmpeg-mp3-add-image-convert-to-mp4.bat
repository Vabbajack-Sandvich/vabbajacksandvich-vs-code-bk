rem 2026-06-26-20-06-35-PM
rem this adds a picture to an mp3
rem and converts it to an mp4
rem base wip command
rem ffmpeg -loop 1 -i image.jpg -i input.mp3 -c:v libx264 -tune stillimage -c:a aac -b:a 192k -pix_fmt yuv420p -shortest output.mp4

rem this adds the same image to every mp3
rem in c:\vc\

@echo off

setlocal enabledelayedexpansion

rem default
rem set "pic=C:\vc\image.png"
rem set "pic=C:\vc\music-remix-zonide-quake-ii-soundtrack-0.png"
rem set "pic=music-remix-zonide-marilyn-manson-antichrist-superstar-full-album-1996-text-0.png"
rem set "pic=in-this-moment-sex-metal-barbie-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db-0.png"

rem copy paste
rem set "pic="
set "pic=marilyn-manson-antichrist-superstar-full-album-second-pass_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-thirdpass-0.png"
rem set "pic=filter-the-crystal-method-trip-like-i-do-remix-2-6db-2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db-2nd.png"
rem set "pic=filter-the-crystal-method-trip-like-i-do-remix-2-6db-2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db.png"
rem set "pic=apc-passive-0.png"
rem set "pic=gnufuzz-Whisper-To-Me-Louise-2-6db-2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db-0.png"
rem set "pic=clutch-electric-worry-2-6db-2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db.png"
rem set "pic=A-Perfect-Circle-Weak-And-Powerless-2-6db-2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db.png"
rem set "pic=Pet-2-6db-2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db-0.png"
rem set "pic=marilyn-manson-antichrist-superstar-full-album-second-pass_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-secondpass-0.png"
rem set "pic=leo-moracchioli-stressed-out-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db-0.png"
rem set "pic=leo-moracchioli-take-me-to-church-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db.png"
rem set "pic=hellyeah-moth-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db.png"
rem set "pic=funny-eddie-lawerence-the-old-philosopher-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db-2-6db-0.png"
rem set "pic=algal-the-bard-system-of-a-down-aerials-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db-0.png"
rem set "pic=meri-amber-gods-2-6db-2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-12db-0.png"
rem set "pic=in-this-moment-big-bad-wolf-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db-6db-0.png"
rem set "pic=harp-twins-my-immortal-evanescence-end-edit-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db-6db-0.png"

cd C:\vc

for %%f in (*.mp3) do (
rem siv
rem single image video
ffmpeg -loop 1 -i "!pic!" -i "%%f" -c:v libx264 -tune stillimage -c:a aac -b:a 192k -pix_fmt yuv420p -shortest "%%~nf_siv.mp4"
)
