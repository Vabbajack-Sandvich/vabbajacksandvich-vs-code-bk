rem 2026-06-19-11-38-49-AM
rem mp3
rem convert dash and underscore to space
rem remove double space
rem space to dash

setlocal enabledelayedexpansion
rem %variable:search=replace%

cd c:\vc
rem cd c:\vc\t

rem dash and underscore to space then remove double space Z times incase of 4 spaces then convert to either underscore or dash

rem clear zfilenames
set "zfilename="

for %%f in ("*.mp4") do (

set "zfilename=%%f"
echo "zfilename !zfilename!"
rem dash to space
set "zfilename=!zfilename:-= !"
echo "zfilename !zfilename!"
rem underscore to space
set "zfilename=!zfilename:_= !"
echo "zfilename !zfilename!"
rem removes up to 5 double spaces just incase
	FOR /L %%i IN (1,1,5) DO (
		rem double space to single space Z
		set "zfilename=!zfilename:  = !"
		echo "zfilename %%i !zfilename!"
	)
rem space to dash
set "zfilename=!zfilename: =_!"
echo "zfilename !zfilename!"
rem rename file
ren "%%f" "!zfilename!"
rem pause
rem clear zfilenames
set "zfilename="

)
