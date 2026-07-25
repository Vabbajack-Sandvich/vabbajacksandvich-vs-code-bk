rem 2026-06-19-01-32-49-AM

rem this converts every m4a in to mp3
rem then deletes the m4a
rem then converts the mp3 to the slower version

cd C:\vc

rem this converts every m4a in to mp3
for %%f in (*.m4a) do (
ffmpeg -y -i "%%f" "%%~nf_c.mp3"
timeout /t 2 /nobreak
rem delete m4a
del /f /q "%%f"

)

timeout /t 2 /nobreak
rem pause

rem then converts the mp3 to the slower version
for %%f in (*.mp3) do (
rem ffmpeg -i input.wav -af asetrate=44100*0.8,aresample=44100 output.wav
ffmpeg -i "%%f" -af asetrate=44100*0.67,aresample=44100 "%%~nf_2thirdslowerpitchspeed.mp3"
timeout /t 2 /nobreak
rem pause
rem move to temp
rem move /y "%%f" "c:\vc\t"

)

