rem 2026-06-23-12-00-04-PM
rem works with auto hot key test.ahk
rem zfilelist.txt from test.exe based file lists
rem you can use wild cards to seach directories
rem like *blah*.mp3 will return all files with blah that are .mp3 files in zfilelist
rem using control shift f and specifying
rem the paths and search in the input boxes

setlocal EnableDelayedExpansion

for %%f in ("*.mp3") do (

	rem Loop through each line of the text file
	for /f "delims=" %%A in (%%f) do (
		set "line=%%A"
		
		:loop
		rem Check if the line still contains two consecutive spaces
		if not "!line:  =!"=="!line!" (
			rem Replace two spaces with one space
			set "line=!line:  = !"
			goto loop
		)
		
		rem Output the cleaned line to the new file
		echo(!line!>> "%%f"
		endlocal
	)
	
	endlocal
	echo Done! Check %%f.
	rem pause

)
