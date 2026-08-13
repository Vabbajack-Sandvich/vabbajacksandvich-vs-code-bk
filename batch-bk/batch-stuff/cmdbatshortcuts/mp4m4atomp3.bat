@rem ==========================================
@rem 2026-06-23-06-27-00-AM
@rem ==========================================
@rem mp3
@rem -.mp3 to .mp3
@rem _.mp3 to .mp3
@rem space.mp3 to .mp3
@rem ==========================================
@rem @removing by setting to null:
@rem (128kbit_AAC) - has space in front
@rem (360p_25fps_h264-96kbit_aac)
@rem (360p_25fps_h264-96kbit_AAC)
@rem (720p_25fps_h264-128kbit_aac)
@rem (720p_25fps_h264-128kbit_AAC)
@rem (1080p_25fps_H264-128kbit_AAC)
@rem ==========================================
@rem convert to space:
@rem dash
@rem underscore
@rem parenthesis ( )
@rem brackets [ ]
@rem '
@rem ==========================================

@rem @remove double space
@rem space to dash

setlocal enabledelayedexpansion

@echo off

@rem lol
@rem @echoof

@rem recho
@rem radda radda raaadaa

@rem %variable:search=replace%

cd c:\vc
@rem cd c:\vc\t

@rem doing the m4a name conversion
@rem redueces mp3 conversion name conflicts

@rem clear zfilenames
set "zfilename="

for %%f in ("*.m4a") do (

@rem echo "file - %%f"
@rem @rem pause

@rem 2026-07-12-07-41-51-AM
@rem formatting error
@rem "zfilename Tech-N9ne-Fragile-ft.-Kendrick-Lamar,-¡MAYDAY-&-Kendall-Morgan-Director-s-Cut.m4a"
@rem The syntax of the command is incorrect.

@rem ==========================================
set "zfilename=%%f"
echo "zfilename !zfilename!"
@rem ==========================================
@rem setting to modded string:
@rem ft. to ft
set "zfilename=!zfilename:ft.=ft!"
echo "zfilename !zfilename!"
@rem setting to removed dot:
@rem ft. to ft
set "zfilename=!zfilename:feat.=feat!"
echo "zfilename !zfilename!"
@rem setting to removed dot:
@rem & to and
set "zfilename=!zfilename:&=and!"
echo "zfilename !zfilename!"
@rem ==========================================
@rem setting to null:
@rem (128kbit_AAC) to null
set "zfilename=!zfilename:(128kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem template for copy pasting
@rem @rem to null
@rem set "zfilename=!zfilename:=!"
@rem echo "zfilename !zfilename!"
@rem (360p_25fps_h264-96kbit_aac) to null
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_aac)=!"
echo "zfilename !zfilename!"
@rem (360p_25fps_h264-96kbit_AAC) to null
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem (720p_25fps_h264-128kbit_aac) to null
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_aac)=!"
echo "zfilename !zfilename!"
@rem (720p_25fps_h264-128kbit_AAC) to null
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem (1080p_25fps_H264-128kbit_AAC)to null
set "zfilename=!zfilename:(1080p_25fps_H264-128kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem (Official Video)
set "zfilename=!zfilename:(Official Video)=!"
echo "zfilename !zfilename!"
@rem ==========================================
@rem converting to space:
@rem dash to space
set "zfilename=!zfilename:-= !"
echo "zfilename !zfilename!"
@rem underscore to space
set "zfilename=!zfilename:_= !"
echo "zfilename !zfilename!"
@rem ( to space
set "zfilename=!zfilename:(= !"
echo "zfilename !zfilename!"
@rem ) to space
set "zfilename=!zfilename:)= !"
echo "zfilename !zfilename!"
@rem [ to space
set "zfilename=!zfilename:[= !"
echo "zfilename !zfilename!"
@rem ] to space
set "zfilename=!zfilename:]= !"
echo "zfilename !zfilename!"
@rem ' to space
set "zfilename=!zfilename:'= !"
echo "zfilename !zfilename!"
@rem ¿ to space
set "zfilename=!zfilename:¿= !"
echo "zfilename !zfilename!"
@rem ¡ to space
@rem this doesnt get replaced for some reason
@rem not sure why
@rem this symbol will screw up the batch file
set "zfilename=!zfilename:¡= !"
echo "zfilename !zfilename!"
@rem echo "file - %%f"
@rem @rem pause
@rem , to space
set "zfilename=!zfilename:,= !"
echo "zfilename !zfilename!"
@rem ' to space
set "zfilename=!zfilename:'= !"
echo "zfilename !zfilename!"

@rem removes up to 5 double spaces just incase
@rem 
@rem 2026-07-12-07-38-45-AM
@rem adding recursive double @removals
@rem double character to single space

	FOR /L %%i IN (1,1,5) DO (
		@rem double space to single space Z
		set "zfilename=!zfilename:  = !"
		echo "zfilename %%i !zfilename!"

		@rem -- to space
		set "zfilename=!zfilename:--= !"
		echo "zfilename !zfilename!"

		@rem -- to space
		set "zfilename=!zfilename:_= !"
		echo "zfilename !zfilename!"

	)
	
@rem space to dash
set "zfilename=!zfilename: =-!"
echo "zfilename !zfilename!"

@rem -.m4a to .m4a
set "zfilename=!zfilename:-.m4a=.m4a!"
echo "zfilename !zfilename!"
@rem _.m4a to .m4a
set "zfilename=!zfilename:_.m4a=.m4a!"
echo "zfilename !zfilename!"
@rem space.m4a to .m4a
set "zfilename=!zfilename: .m4a=.m4a!"
echo "zfilename !zfilename!"

@rem rename file
ren "%%f" "!zfilename!"
@rem @rem pause
@rem clear zfilenames
set "zfilename="

)

@rem convert m4a to mp3
@rem after name conversion

for %%f in (*.m4a) do (
echo "file - %%f"
@rem pause
@rem default
@rem ffmpeg -y -i "%%f" "%%~nf.mp3"
@rem m4a to mp3 with lame encoder
@rem switch:
@rem -map_metadata -1 -vn -c:a libmp3lame
@rem 2026-07-15-17-42-39-PM
@rem update to use lame encoder for mp3
ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "%%~nf.mp3"
@rem delete m4a
del /f /q "%%f"
)

@rem convert mp4 to mp3
@rem after name conversion

for %%f in (*.mp4) do (
echo "file - %%f"
@rem pause
@rem default
@rem ffmpeg -y -i "%%f" "%%~nf.mp3"
@rem m4a to mp3 with lame encoder
@rem switch:
@rem -map_metadata -1 -vn -c:a libmp3lame
@rem 2026-07-15-17-42-39-PM
@rem update to use lame encoder for mp3
ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "%%~nf.mp3"
@rem delete mp4
del /f /q "%%f"
)

@rem dash and underscore to space then @remove double space Z times incase of 4 spaces then convert to either underscore or dash

@rem clear zfilenames
set "zfilename="

for %%f in ("*.mp3") do (

echo "file - %%f"
@rem pause

set "zfilename=%%f"
echo "zfilename !zfilename!"
@rem ==========================================
@rem setting to null:
@rem (128kbit_AAC) to null
set "zfilename=!zfilename:(128kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem template for copy pasting
@rem @rem to null
@rem set "zfilename=!zfilename:=!"
@rem echo "zfilename !zfilename!"
@rem (360p_25fps_h264-96kbit_aac) to null
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_aac)=!"
echo "zfilename !zfilename!"
@rem (360p_25fps_h264-96kbit_AAC) to null
set "zfilename=!zfilename:(360p_25fps_h264-96kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem (720p_25fps_h264-128kbit_aac) to null
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_aac)=!"
echo "zfilename !zfilename!"
@rem (720p_25fps_h264-128kbit_AAC) to null
set "zfilename=!zfilename:(720p_25fps_h264-128kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem (1080p_25fps_H264-128kbit_AAC)to null
set "zfilename=!zfilename:(1080p_25fps_H264-128kbit_AAC)=!"
echo "zfilename !zfilename!"
@rem (Official Video)
set "zfilename=!zfilename:(Official Video)=!"
echo "zfilename !zfilename!"

@rem ==========================================
@rem converting to space:
@rem dash to space
set "zfilename=!zfilename:-= !"
echo "zfilename !zfilename!"
@rem underscore to space
set "zfilename=!zfilename:_= !"
echo "zfilename !zfilename!"
@rem ( to space
set "zfilename=!zfilename:(= !"
echo "zfilename !zfilename!"
@rem ) to space
set "zfilename=!zfilename:)= !"
echo "zfilename !zfilename!"
@rem [ to space
set "zfilename=!zfilename:[= !"
echo "zfilename !zfilename!"
@rem ] to space
set "zfilename=!zfilename:]= !"
echo "zfilename !zfilename!"
@rem ' to space
set "zfilename=!zfilename:'= !"
echo "zfilename !zfilename!"

@rem removes up to 5 double spaces just incase
	FOR /L %%i IN (1,1,5) DO (
		@rem double space to single space Z
		set "zfilename=!zfilename:  = !"
		echo "zfilename %%i !zfilename!"
	)
	
@rem space to dash
set "zfilename=!zfilename: =-!"
echo "zfilename !zfilename!"

@rem -.mp3 to .mp3
set "zfilename=!zfilename:-.mp3=.mp3!"
echo "zfilename !zfilename!"
@rem _.mp3 to .mp3
set "zfilename=!zfilename:_.mp3=.mp3!"
echo "zfilename !zfilename!"
@rem space.mp3 to .mp3
set "zfilename=!zfilename: .mp3=.mp3!"
echo "zfilename !zfilename!"

@rem rename file
ren "%%f" "!zfilename!"
@rem @rem pause
@rem clear zfilenames
set "zfilename="

)
