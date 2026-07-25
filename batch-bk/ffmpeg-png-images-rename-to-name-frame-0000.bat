rem 2026-06-25-05-05-18-AM

rem this makes and uses C:\vc\i

rem this is to ensure that there
rem is an empty directory
rem specifically for renaming
rem the files with this batch file

rem need to make one that itterates
rem and renames all pictures in c:\vc to the
rem frame dump source
rem name_frame_####.png format
rem ffmpeg-mp4-extract-each-frame-vsync.bat
rem mp4 frame dump batch outputs
rem that anyway

rem renames then moves the files
rem to prevent loop conflicts

@echo off

mkdir C:\vc\i
mkdir C:\vc\i\t

cd c:\vc\i

setlocal enabledelayedexpansion

rem convert jpg to png
for %%f in (*.jpg) do (
ffmpeg -y -i "%%f" "%%~nf.png"
)

rem convert jpeg to png
for %%f in (*.jpeg) do (
ffmpeg -y -i "%%f" "%%~nf.png"
)

rem convert bmp to png
for %%f in (*.bmp) do (
ffmpeg -y -i "%%f" "%%~nf.png"
)

rem convert webp to png
for %%f in (*.webp) do (
ffmpeg -y -i "%%f" "%%~nf.png"
)

rem saving this here
rem as an easy copy and paste thing
rem simpler way to get file count
rem and for specific extentions
rem for %%f in (*.png) do (
rem     set /a file_count+=1
rem     echo "Found file: %%f"
rem 	echo "file_count - !file_count!"
rem )

rem confusing way to get file count
rem works though
rem not using it
rem saving it though
rem get file count
rem for /f %%A in ('dir /b /a-d 2^>nul ^| find /v /c ""') do (
rem set file_count=%%A
rem echo "!file_count!"
rem )

rem goto endofloop

rem switching over to just time stamping the output file name

set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%
echo %mydateformat%
set mydate=%mydateformat:/=-%
echo %mydate%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%
set mytimestamp=%mytimestamp: =%

rem simpler way to get file count
rem and for specific extentions
set /a file_count=0

for %%f in (*.png) do (
    set /a file_count+=1
    echo "Found file: %%f"
	echo "file_count - !file_count!"
	
	rem GTR: Greater than
	rem GEQ: Greater than or equal to
	rem LSS: Less than
	rem LEQ: Less than or equal to
	rem EQU: Equal to
	rem NEQ: Not equal to

	rem this is for each progressive digit

	rem greater or equal than 1000
	rem #_frame_####.png
	if !file_count! geq 1000 (
		set "filename=!mytimestamp!_frame_!file_count!.png"
		echo "!filename!"
		echo "renaming %%f to !filename!"
	)

	rem less than 999
	rem #_frame_0###.png
	if !file_count! leq 999 (
		set "filename=!mytimestamp!_frame_0!file_count!.png"
		echo "!filename!"
		echo "renaming %%f to !filename!"
	)

	rem less than 99
	rem #_frame_00##.png
	if !file_count! leq 99 (
		set "filename=!mytimestamp!_frame_00!file_count!.png"
		echo "!filename!"
		echo "renaming %%f to !filename!"
	)
	
	rem less than 9
	rem #_frame_000#.png
	if !file_count! leq 9 (
		set "filename=!mytimestamp!_frame_000!file_count!.png"
		echo "!filename!"
		echo "renaming %%f to !filename!"
	)

	rem put rename thing here
	ren "%%f" "!filename!"
	move /y "!filename!" "c:\vc\i\t"
	set "filename="

)

cd c:\vc\i\t

rem move back afterward
for %%f in (*.png) do (
echo "moving file back to c:\vc\i - %%f"
move /y "%%f" "c:\vc\i"
)

cd c:\vc\i

:endofloop
echo "end of loop"
rem clear variable
set /a "file_count=0"
set "mytimestamp="
set "filename="

endlocal
