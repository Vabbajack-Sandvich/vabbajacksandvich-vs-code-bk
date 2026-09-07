rem this converts every opus to mp3

rem chdir /D d:
cd C:\vc

rem example
rem ffmpeg -i LostInTranslation.opus -codec copy LostInTranslation.mp3

rem for %%f in (*.mp3) do ffmpeg -y -i "%%f" -c:v libx264 -b:v 340k -preset ultrafast -vf scale=640:464 "%%~nf_shrunk%%~xf"

rem for %%f in (*.mp3) do ffmpeg  -y -i "%%f" -codec copy "%%~nf.opus"

for %%f in (*.opus) do (
@rem ffmpeg  -y -i "%%f" -codec copy "%%~nf.mp3"
@rem ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "%%~nf-md.mp3"
ffmpeg  -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame -q:a 0 "%%~nf.mp3"
@rem pause
@rem delete original opus
echo "deleting - %%f"
del /f /q "%%f"
timeout /t 1 /nobreak
)
