
chdir /D: d:
cd C:\vc

rem ffmpeg -y -ss 10 -i "%%f" -vcodec copy -acodec copy -crf 20 -preset ultrafast -r 60 "%%~nf_uf_trimmed%%~xf"

for %%f in (*.mp4) do (

ffmpeg -y -ss 5 -i "%%f" -crf 18 -preset ultrafast -r 60 "%%~nf_uf_tr%%~xf"
rem ffmpeg -y -i "%%f" -crf 18 -preset ultrafast -r 60 -aspect 4:3 "%%~nf_uf_tr%%~xf"

)

rem ffmpeg -y -ss 10 -i "%%f" -vcodec copy -acodec copy -crf 20 -preset ultrafast -r 60 "%%~nf_uf_trimmed%%~xf"

for %%f in (*.mkv) do (

ffmpeg -y -ss 9 -i "%%f" -crf 18 -preset ultrafast -r 60 "%%~nf_uf_tr%%~xf"

)
