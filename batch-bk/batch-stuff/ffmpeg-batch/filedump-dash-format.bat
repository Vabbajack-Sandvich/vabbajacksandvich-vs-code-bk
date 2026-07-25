
rem ==========================================
rem 2026-06-23-06-27-00-AM
rem ==========================================
rem *
rem -.!filenameextention! to .!filenameextention!
rem _.!filenameextention! to .!filenameextention!
rem space.!filenameextention! to .!filenameextention!
rem ==========================================
rem removing by setting to null:
rem (128kbit_AAC) - has space in front
rem (360p_25fps_h264-96kbit_aac)
rem (360p_25fps_h264-96kbit_AAC)
rem (720p_25fps_h264-128kbit_aac)
rem (720p_25fps_h264-128kbit_AAC)
rem (1080p_25fps_H264-128kbit_AAC)
rem (1080p_30fps_H264-128kbit_AAC)
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

@echo off
rem @echo on

setlocal enabledelayedexpansion
rem %variable:search=replace%

rem cd c:\vc
cd c:\filedump
rem cd c:\vc\t

rem chdir /d D:
rem cd D:\xfer\mp4

rem dash and underscore to space then remove double space Z times incase of 4 spaces then convert to either underscore or dash

rem clear filenames
set "filename="

rem this shoul be just the extention
rem %%~xf

for %%f in ("*.*") do (

set "filename=%%f"
echo "filename !filename!"
set "filenameextention=%%~xf"
echo "filenameextention !filenameextention!"

rem ==========================================
rem setting to null:
rem (128kbit_AAC) to null
set "filename=!filename:(128kbit_AAC)=!"
echo "filename !filename!"
rem template for copy pasting
rem rem to null
rem set "filename=!filename:=!"
rem echo "filename !filename!"
rem (360p_25fps_h264-96kbit_aac) to null
set "filename=!filename:(360p_25fps_h264-96kbit_aac)=!"
echo "filename !filename!"
rem (360p_25fps_h264-96kbit_AAC) to null
set "filename=!filename:(360p_25fps_h264-96kbit_AAC)=!"
echo "filename !filename!"
rem (720p_25fps_h264-128kbit_aac) to null
set "filename=!filename:(720p_25fps_h264-128kbit_aac)=!"
echo "filename !filename!"
rem (720p_25fps_h264-128kbit_AAC) to null
set "filename=!filename:(720p_25fps_h264-128kbit_AAC)=!"
echo "filename !filename!"
rem (1080p_25fps_H264-128kbit_AAC)to null
set "filename=!filename:(1080p_25fps_H264-128kbit_AAC)=!"
echo "filename !filename!"
rem (1080p_30fps_H264-128kbit_AAC)
set "filename=!filename:(1080p_30fps_H264-128kbit_AAC)=!"
echo "filename !filename!"
rem -480p
set "filename=!filename:-480p=!"
echo "filename !filename!"
rem 480p
set "filename=!filename:480p=!"
echo "filename !filename!"
rem 480
set "filename=!filename:480=!"
echo "filename !filename!"
rem -720p
set "filename=!filename:-720p=!"
echo "filename !filename!"
rem 720p
set "filename=!filename:720p=!"
echo "filename !filename!"
rem 720
set "filename=!filename:720=!"
echo "filename !filename!"
rem -1080p
set "filename=!filename:-1080p=!"
echo "filename !filename!"
rem 1080p
set "filename=!filename:1080p=!"
echo "filename !filename!"
rem 1080
set "filename=!filename:1080=!"
echo "filename !filename!"
rem -60fps
set "filename=!filename:-60fps=!"
echo "filename !filename!"
rem ¿
set "filename=!filename:¿=!"
echo "filename !filename!"
rem -hls
set "filename=!filename:-hls=!"
echo "filename !filename!"
rem ”
set "filename=!filename:”=!"
echo "filename !filename!"
rem -watch-online
set "filename=!filename:-watch-online=!"
echo "filename !filename!"

rem ==========================================
rem converting to space:
rem dash to space
set "filename=!filename:-= !"
echo "filename !filename!"
rem underscore to space
set "filename=!filename:_= !"
echo "filename !filename!"
rem ( to space
set "filename=!filename:(= !"
echo "filename !filename!"
rem ) to space
set "filename=!filename:)= !"
echo "filename !filename!"
rem [ to space
set "filename=!filename:[= !"
echo "filename !filename!"
rem ] to space
set "filename=!filename:]= !"
echo "filename !filename!"
rem ' to space
set "filename=!filename:'= !"
echo "filename !filename!"
rem , to space
set "filename=!filename:,= !"
echo "filename !filename!"

rem removes up to 5 double spaces just incase
	FOR /L %%i IN (1,1,5) DO (
		rem double space to single space Z
		set "filename=!filename:  = !"
		echo "filename %%i !filename!"
	)
	
rem space to dash
set "filename=!filename: =-!"
echo "filename space to dash - !filename!"

rem pause

rem -.mp4 to .mp4
set "filename=!filename:-%%~xf=%%~xf!"
echo "filename -.mp4 to .mp4 - !filename!"
rem _%%~xf to %%~xf
set "filename=!filename:_%%~xf=%%~xf!"
echo "filename _%%~xf to %%~xf - !filename!"
rem space%%~xf to %%~xf
set "filename=!filename: %%~xf=%%~xf!"
echo "filename last - space %%~xf to %%~xf - !filename!"

rem pause

rem rename file
ren "%%f" "!filename!"
rem pause
rem clear filenames
set "filename="

)
