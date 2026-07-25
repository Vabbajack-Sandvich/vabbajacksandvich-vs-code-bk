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

