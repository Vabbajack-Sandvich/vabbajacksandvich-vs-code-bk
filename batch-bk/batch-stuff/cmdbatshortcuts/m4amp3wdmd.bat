setlocal enabledelayedexpansion
@echo off

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

@rem lol
@rem @echoof

@rem recho
@rem radda radda raaadaa

@rem %variable:search=replace%

cd c:\vc
@rem cd c:\vc\t

@rem doing the m4a name conversion
@rem redueces mp3 conversion name conflicts

@rem @rem clear zfilenames
@rem set "zfilename="
@rem 
@rem for %%f in ("*.m4a") do (
@rem 
@rem @rem echo "file - %%f"
@rem @rem @rem pause
@rem 
@rem @rem 2026-07-12-07-41-51-AM
@rem @rem formatting error
@rem @rem "zfilename Tech-N9ne-Fragile-ft.-Kendrick-Lamar,-¡MAYDAY-&-Kendall-Morgan-Director-s-Cut.m4a"
@rem @rem The syntax of the command is incorrect.
@rem 
@rem @rem ==========================================
@rem set "zfilename=%%f"
@rem echo "zfilename !zfilename!"
@rem @rem ==========================================
@rem @rem setting to modded string:
@rem @rem ft. to ft
@rem set "zfilename=!zfilename:ft.=ft!"
@rem echo "zfilename !zfilename!"
@rem @rem setting to removed dot:
@rem @rem ft. to ft
@rem set "zfilename=!zfilename:feat.=feat!"
@rem echo "zfilename !zfilename!"
@rem @rem setting to removed dot:
@rem @rem & to and
@rem set "zfilename=!zfilename:&=and!"
@rem echo "zfilename !zfilename!"
@rem @rem ==========================================
@rem @rem setting to null:
@rem @rem (128kbit_AAC) to null
@rem set "zfilename=!zfilename:(128kbit_AAC)=!"
@rem echo "zfilename !zfilename!"
@rem @rem template for copy pasting
@rem @rem @rem to null
@rem @rem set "zfilename=!zfilename:=!"
@rem @rem echo "zfilename !zfilename!"
@rem @rem (360p_25fps_h264-96kbit_aac) to null
@rem set "zfilename=!zfilename:(360p_25fps_h264-96kbit_aac)=!"
@rem echo "zfilename !zfilename!"
@rem @rem (360p_25fps_h264-96kbit_AAC) to null
@rem set "zfilename=!zfilename:(360p_25fps_h264-96kbit_AAC)=!"
@rem echo "zfilename !zfilename!"
@rem @rem (720p_25fps_h264-128kbit_aac) to null
@rem set "zfilename=!zfilename:(720p_25fps_h264-128kbit_aac)=!"
@rem echo "zfilename !zfilename!"
@rem @rem (720p_25fps_h264-128kbit_AAC) to null
@rem set "zfilename=!zfilename:(720p_25fps_h264-128kbit_AAC)=!"
@rem echo "zfilename !zfilename!"
@rem @rem (1080p_25fps_H264-128kbit_AAC)to null
@rem set "zfilename=!zfilename:(1080p_25fps_H264-128kbit_AAC)=!"
@rem echo "zfilename !zfilename!"
@rem @rem (Official Video)
@rem set "zfilename=!zfilename:(Official Video)=!"
@rem echo "zfilename !zfilename!"
@rem @rem ==========================================
@rem @rem converting to space:
@rem @rem dash to space
@rem set "zfilename=!zfilename:-= !"
@rem echo "zfilename !zfilename!"
@rem @rem underscore to space
@rem set "zfilename=!zfilename:_= !"
@rem echo "zfilename !zfilename!"
@rem @rem ( to space
@rem set "zfilename=!zfilename:(= !"
@rem echo "zfilename !zfilename!"
@rem @rem ) to space
@rem set "zfilename=!zfilename:)= !"
@rem echo "zfilename !zfilename!"
@rem @rem [ to space
@rem set "zfilename=!zfilename:[= !"
@rem echo "zfilename !zfilename!"
@rem @rem ] to space
@rem set "zfilename=!zfilename:]= !"
@rem echo "zfilename !zfilename!"
@rem @rem ' to space
@rem set "zfilename=!zfilename:'= !"
@rem echo "zfilename !zfilename!"
@rem @rem ¿ to space
@rem set "zfilename=!zfilename:¿= !"
@rem echo "zfilename !zfilename!"
@rem @rem ¡ to space
@rem @rem this doesnt get replaced for some reason
@rem @rem not sure why
@rem @rem this symbol will screw up the batch file
@rem set "zfilename=!zfilename:¡= !"
@rem echo "zfilename !zfilename!"
@rem @rem echo "file - %%f"
@rem @rem @rem pause
@rem @rem , to space
@rem set "zfilename=!zfilename:,= !"
@rem echo "zfilename !zfilename!"
@rem @rem ' to space
@rem set "zfilename=!zfilename:'= !"
@rem echo "zfilename !zfilename!"
@rem 
@rem @rem removes up to 5 double spaces just incase
@rem @rem 
@rem @rem 2026-07-12-07-38-45-AM
@rem @rem adding recursive double @removals
@rem @rem double character to single space
@rem 
@rem 	FOR /L %%i IN (1,1,5) DO (
@rem 		@rem double space to single space Z
@rem 		set "zfilename=!zfilename:  = !"
@rem 		echo "zfilename %%i !zfilename!"
@rem 
@rem 		@rem -- to space
@rem 		set "zfilename=!zfilename:--= !"
@rem 		echo "zfilename !zfilename!"
@rem 
@rem 		@rem -- to space
@rem 		set "zfilename=!zfilename:_= !"
@rem 		echo "zfilename !zfilename!"
@rem 
@rem 	)
@rem 	
@rem @rem space to dash
@rem set "zfilename=!zfilename: =-!"
@rem echo "zfilename !zfilename!"
@rem 
@rem @rem -.m4a to .m4a
@rem set "zfilename=!zfilename:-.m4a=.m4a!"
@rem echo "zfilename !zfilename!"
@rem @rem _.m4a to .m4a
@rem set "zfilename=!zfilename:_.m4a=.m4a!"
@rem echo "zfilename !zfilename!"
@rem @rem space.m4a to .m4a
@rem set "zfilename=!zfilename: .m4a=.m4a!"
@rem echo "zfilename !zfilename!"
@rem 
@rem @rem rename file
@rem ren "%%f" "!zfilename!"
@rem @rem @rem pause
@rem @rem clear zfilenames
@rem set "zfilename="
@rem 
@rem )

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
@rem ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "%%~nf.mp3"
@rem ffmpeg -i "%%f" -map 0:a -c:a copy -map_metadata -1 "!zfilename!"
ffmpeg -y -i "%%f" -map_metadata -1 -vn -map 0:a -c:a libmp3lame "%%~nf.mp3"
@rem delete m4a
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
@rem set "zfilename=!zfilename:.mp3=-md.mp3!"
echo "zfilename !zfilename!"

@rem rename file
ren "%%f" "!zfilename!"

@rem ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "%%~nf.mp3"
@rem ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "!zfilename!"
@rem ffmpeg -i "%%f" -map 0:a -c:a copy -map_metadata -1 "!zfilename!"

@rem pause

@rem delete original mp3 with meta data
@rem del /f /q "%%f"

@rem pause
@rem clear zfilenames
set "zfilename="

)


@rem convert mp3 to mp3 with no meta data
@rem without reencode using libmp3lame
@rem after name conversion

for %%f in (*.mp3) do (
echo "file - %%f"
@rem pause
@rem default
@rem ffmpeg -y -i "%%f" "%%~nf.mp3"
@rem m4a to mp3 with lame encoder
@rem switch:
@rem -map_metadata -1 -vn -c:a libmp3lame
@rem 2026-07-15-17-42-39-PM
@rem update to use lame encoder for mp3
@rem ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "%%~nf.mp3"
@rem ffmpeg -i "%%f" -map 0:a -c:a copy -map_metadata -1 "!zfilename!"
@rem ffmpeg -y -i "%%f" -map_metadata -1 -vn -map 0:a -c:a libmp3lame "%%~nf.mp3"
@rem ffmpeg -i "%%f" -map 0:a -c:a copy -map_metadata -1 "!zfilename!"
echo "============================================"
echo "removing metadata from mp3"
echo "============================================"
ffmpeg -i "%%f" -map 0:a -c:a copy -map_metadata -1 "%%~nf-md.mp3"
@rem pause
@rem timeout /t 1 /nobreak
@rem delete original mp3
del /f /q "%%f"
)
