
rem 2026-06-14-01-11-43-AM

rem this goes through each sub directory
rem in C:\zonide\non-zip\music and dumps the files in to C:\zonide\non-zip\music

rem to use this:
rem copy and paste a directory in
rem C:\zonide\non-zip\music
rem if you dont have a C:\zonide\non-zip\music folder
rem make one or rename C:\zonide\non-zip\music to
rem whatever folder you want

rem /D is for directories
rem /R is for sub directories
rem /Y is for disabling prompting

cd C:\zonide\non-zip\music

for /D %%a in (*) do (
for /R %%f in (*.*) do (
move /Y "%%f" "C:\zonide\non-zip\music"
rem timeout /t 1 /nobreak
)
rem timeout /t 1 /nobreak
)

rem 2026-06-14-01-46-58-AM
rem adding delete mp4s
rem for /r %%f in (*.mp4) do (
rem del /f /q "%%f"
rem )

rem 2026-06-14-00-07-11-AM
rem update music folder
rem convert m4a to mp3
rem delete m4a
rem C:\zonide\non-zip\music
rem this converts every m4a in to mp3
rem goes through sub directories
rem this also dumps the converted
rem mp3s in to the music folder

cd C:\zonide\non-zip\music
explorer C:\zonide\non-zip\music
rem /r does subdirectories
for /r %%f in (*.m4a) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
rem /F            Force deleting of read-only files.
rem /Q            Quiet mode, do not ask if ok to delete on global wildcard
rem pause
rem timeout /t 1 /nobreak
del /f /q "%%f"
rem pause
)

rem adding convert and delete mp4s

cd C:\zonide\non-zip\music
explorer C:\zonide\non-zip\music
rem /r does subdirectories
for /r %%f in (*.mp4) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
rem /F            Force deleting of read-only files.
rem /Q            Quiet mode, do not ask if ok to delete on global wildcard
rem pause
rem timeout /t 1 /nobreak
del /f /q "%%f"
rem pause
)

