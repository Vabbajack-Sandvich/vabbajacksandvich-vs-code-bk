rem 2026-07-02-10-09-49-AM
rem scans c:\vc\ for pngs with a 1 pass loop
rem this expects there to only be 1 png and 1 mp3
rem to make 1 mp4
rem this makes it so you dont have to manually
rem rename the picture file path
rem and just copy and paste the mp3 and the png
rem into c:\vc\

rem call c.bat
@echo off
setlocal enabledelayedexpansion
rem cd C:\zonide\zip\music\
rem call ffmpeg-mp3-zonide-66666-remix-2.bat
rem call c.bat
rem set /p "choice=Enter destination path (or press Enter for [%choice%]): "
rem Don't fret, precious, I'm here
rem Step away from the window and go back to sleep
rem Safe from pain and truth and choice and other poison devils
rem See, they don't give a fuck about you, like I do

rem =======================================
rem 2026-07-02-08-31-47-AM
rem =======================================
rem nevermind im not doing the fucking prompt thing
rem im updating the add image batch file
rem to scan for png one time in a loop
rem exit the loop at the end
rem expecting 1 pass for 1 png file
rem then matching batch around that
rem basically copy and paste with that one change
rem keeping this as a structure for later use
rem =======================================
rem set /p "imagepath=Enter destination path [%imagepath%]): "
rem echo imagepath - %imagepath%
rem pause
rem =======================================
rem =======================================
rem =======================================
rem =======================================

rem 2026-06-26-20-06-35-PM
rem this adds a picture to an mp3
rem and converts it to an mp4
rem base wip command
rem ffmpeg -loop 1 -i image.jpg -i input.mp3 -c:v libx264 -tune stillimage -c:a aac -b:a 192k -pix_fmt yuv420p -shortest output.mp4

rem this adds the same image to every mp3
rem in c:\vc\

rem @echo off

rem setlocal enabledelayedexpansion

rem default
rem set "pic=C:\vc\image.png"
rem set "pic=C:\vc\music-remix-zonide-quake-ii-soundtrack-0.png"
rem set "pic=music-remix-zonide-marilyn-manson-antichrist-superstar-full-album-1996-text-0.png"
rem set "pic=in-this-moment-sex-metal-barbie-2-6db_2thirdslowerpitchspeed_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-2-6db-0.png"

rem copy paste
rem set "pic="
set "pic=marilyn-manson-antichrist-superstar-full-album-second-pass_winamp-eq-highbass-verylow320-midhigh-dip-highhigh-thirdpass-0.png"
rem set "pic=apc-passive-0.png"

cd C:\vc

rem scans for 1 png file by looping
rem but exiting at the end
for %%f in (*.png) do (
set "imagefile=%%f"
echo "imagefile - !imagefile!"
for %%f in (*.mp3) do (
set "mp3file=%%f"
echo "mp3file - !mp3file!"
set "mp3filenoextention=%%~nf"
echo "mp3filenoextention - !mp3filenoextention!"

rem siv
rem single image video
rem ffmpeg -loop 1 -i "!pic!" -i "%%f" -c:v libx264 -tune stillimage -c:a aac -b:a 192k -pix_fmt yuv420p -shortest "%%~nf_siv.mp4"

ffmpeg -loop 1 -i "!imagefile!" -i "!mp3file!" -c:v libx264 -tune stillimage -c:a aac -b:a 192k -pix_fmt yuv420p -shortest "!mp3filenoextention!"_siv.mp4"
)

echo Loop broken!
GOTO EndOfLoop

)

:EndOfLoop
echo You are now outside the loop.
echo well, at least you would be immune
echo in a zombie apocalypse
pause
