rem 2026-06-14-00-07-11-AM
setlocal enabledelayedexpansion
cd C:\zonide\non-zip\music
explorer C:\zonide\non-zip\music
for /r %%f in (*.m4a) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
del /f /q "%%f"
)
for /r %%f in (*.mp4) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
del /f /q "%%f"
)
set "zfilename="
for %%f in ("*.mp3") do (
set "zfilename=%%f"
set "zfilename=!zfilename:(128kbit_AAC)=!"
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_aac)=!"
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_AAC)=!"
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_aac)=!"
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_AAC)=!"
set "zfilename=!zfilename:(1080p_25fps_H264-128kbit_AAC)=!"
set "zfilename=!zfilename:-= !"
set "zfilename=!zfilename:_= !"
set "zfilename=!zfilename:(= !"
set "zfilename=!zfilename:)= !"
set "zfilename=!zfilename:[= !"
set "zfilename=!zfilename:]= !"
set "zfilename=!zfilename:'= !"
	FOR /L %%i IN (1,1,5) DO (
		rem double space to single space Z
		set "zfilename=!zfilename:  = !"
		echo "zfilename %%i !zfilename!"
	)
set "zfilename=!zfilename: =-!"
set "zfilename=!zfilename:-.mp3=.mp3!"
set "zfilename=!zfilename:_.mp3=.mp3!"
set "zfilename=!zfilename: .mp3=.mp3!"
ren "%%f" "!zfilename!"
set "zfilename="
)
cd C:\zonide\non-zip\2
explorer C:\zonide\non-zip\2
for /r %%f in (*.m4a) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
del /f /q "%%f"
)
for /r %%f in (*.mp4) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
del /f /q "%%f"
)
set "zfilename="
for %%f in ("*.mp3") do (
set "zfilename=%%f"
set "zfilename=!zfilename:(128kbit_AAC)=!"
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_aac)=!"
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_AAC)=!"
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_aac)=!"
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_AAC)=!"
set "zfilename=!zfilename:(1080p_25fps_H264-128kbit_AAC)=!"
set "zfilename=!zfilename:-= !"
set "zfilename=!zfilename:_= !"
set "zfilename=!zfilename:(= !"
set "zfilename=!zfilename:)= !"
set "zfilename=!zfilename:[= !"
set "zfilename=!zfilename:]= !"
	FOR /L %%i IN (1,1,5) DO (
		rem double space to single space Z
		set "zfilename=!zfilename:  = !"
		echo "zfilename %%i !zfilename!"
	)
set "zfilename=!zfilename: =-!"
set "zfilename=!zfilename:-.mp3=.mp3!"
set "zfilename=!zfilename:_.mp3=.mp3!"
set "zfilename=!zfilename: .mp3=.mp3!"
ren "%%f" "!zfilename!"
set "zfilename="
)
