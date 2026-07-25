rem 2026-06-14-00-07-11-AM
setlocal enabledelayedexpansion
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

rem /F            Force deleting of read-only files.
rem /Q            Quiet mode, do not ask if ok to delete on global wildcard

for /r %%f in (*.m4a) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
rem pause
rem timeout /t 1 /nobreak
del /f /q "%%f"
rem pause
)

for /r %%f in (*.mp4) do (
ffmpeg -y -i "%%f" "%%~nf.mp3"
rem pause
rem timeout /t 1 /nobreak
del /f /q "%%f"
rem pause
)

rem 2026-06-23-06-40-00-AM

rem ==========================================
rem 2026-06-23-06-27-00-AM
rem ==========================================
rem mp3
rem -.mp3 to .mp3
rem _.mp3 to .mp3
rem space.mp3 to .mp3
rem ==========================================
rem removing by setting to null:
rem (128kbit_AAC) - has space in front
rem (360p_25fps_h264-96kbit_aac)
rem (360p_25fps_h264-96kbit_AAC)
rem (720p_25fps_h264-128kbit_aac)
rem (720p_25fps_h264-128kbit_AAC)
rem (1080p_25fps_H264-128kbit_AAC)
rem ==========================================
rem convert to space:
rem dash
rem underscore
rem parenthesis ( )
rem brackets [ ]
rem '
rem ==========================================

rem remove double space
rem space to dash

rem setlocal enabledelayedexpansion
rem %variable:search=replace%

rem cd c:\vc
rem cd c:\vc\t

rem dash and underscore to space then remove double space Z times incase of 4 spaces then convert to either underscore or dash

rem clear zfilenames
set "zfilename="

for %%f in ("*.mp3") do (

set "zfilename=%%f"
rem echo "zfilename !zfilename!"
rem ==========================================
rem setting to null:
rem (128kbit_AAC) to null
set "zfilename=!zfilename:(128kbit_AAC)=!"
rem echo "zfilename !zfilename!"
rem template for copy pasting
rem rem to null
rem set "zfilename=!zfilename:=!"
rem echo "zfilename !zfilename!"
rem (360p_25fps_h264-96kbit_aac) to null
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_aac)=!"
rem echo "zfilename !zfilename!"
rem (360p_25fps_h264-96kbit_AAC) to null
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_AAC)=!"
rem echo "zfilename !zfilename!"
rem (720p_25fps_h264-128kbit_aac) to null
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_aac)=!"
rem echo "zfilename !zfilename!"
rem (720p_25fps_h264-128kbit_AAC) to null
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_AAC)=!"
rem echo "zfilename !zfilename!"
rem (1080p_25fps_H264-128kbit_AAC)to null
set "zfilename=!zfilename:(1080p_25fps_H264-128kbit_AAC)=!"
rem echo "zfilename !zfilename!"
rem ==========================================
rem converting to space:
rem dash to space
set "zfilename=!zfilename:-= !"
rem echo "zfilename !zfilename!"
rem underscore to space
set "zfilename=!zfilename:_= !"
rem echo "zfilename !zfilename!"
rem ( to space
set "zfilename=!zfilename:(= !"
rem echo "zfilename !zfilename!"
rem ) to space
set "zfilename=!zfilename:)= !"
rem echo "zfilename !zfilename!"
rem [ to space
set "zfilename=!zfilename:[= !"
rem echo "zfilename !zfilename!"
rem ] to space
set "zfilename=!zfilename:]= !"
rem echo "zfilename !zfilename!"
rem ' to space
set "zfilename=!zfilename:'= !"
rem echo "zfilename !zfilename!"

rem removes up to 5 double spaces just incase
	FOR /L %%i IN (1,1,5) DO (
		rem double space to single space Z
		set "zfilename=!zfilename:  = !"
		echo "zfilename %%i !zfilename!"
	)
	
rem space to dash
set "zfilename=!zfilename: =-!"
rem echo "zfilename !zfilename!"

rem -.mp3 to .mp3
set "zfilename=!zfilename:-.mp3=.mp3!"
rem echo "zfilename !zfilename!"
rem _.mp3 to .mp3
set "zfilename=!zfilename:_.mp3=.mp3!"
rem echo "zfilename !zfilename!"
rem space.mp3 to .mp3
set "zfilename=!zfilename: .mp3=.mp3!"
rem echo "zfilename !zfilename!"

rem rename file
ren "%%f" "!zfilename!"
rem pause
rem clear zfilenames
set "zfilename="

)
