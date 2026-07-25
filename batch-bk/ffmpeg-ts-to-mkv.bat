rem this converts every mkv in to mp4

rem chdir /D d:
cd C:\vc

rem example
rem ffmpeg -i LostInTranslation.mkv -codec copy LostInTranslation.mp4

rem for %%f in (*.mp4) do ffmpeg -y -i "%%f" -c:v libx264 -b:v 340k -preset ultrafast -vf scale=640:464 "%%~nf_shrunk%%~xf"

rem for %%f in (*.mp4) do ffmpeg  -y -i "%%f" -codec copy "%%~nf.mkv"

for %%f in (*.ts) do ffmpeg  -y -i "%%f" -codec copy "%%~nf.mkv"
