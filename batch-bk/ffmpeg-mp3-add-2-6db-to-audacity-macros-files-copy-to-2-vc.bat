rem 2026-06-27-11-51-23-AM
rem add -2-6db to audacity macro output mp3s
rem copy to 2 and C:\vc

@echo off

setlocal enabledelayedexpansion

rem macro path
rem C:\Users\zonid\OneDrive\Documents\Audacity\macro-output
set "mpath=C:\Users\zonid\OneDrive\Documents\Audacity\macro-output"

rem the vc path
rem C:\vc
set "vpath=C:\vc"

rem the 2 path
rem C:\zonide\non-zip\2
set "fpath=C:\zonide\non-zip\2"

rem clear filename
set "filename="

cd !mpath!

for %%f in (*.mp3) do (
set "filename=%%f"
set "filenamenoextention=%%~nf"
set "filenameoutput=!filenamenoextention!-2-6db.mp3"
ren "!filename!" "!filenameoutput!"
copy /y "!filenameoutput!" "!vpath!\!filenameoutput!"
copy /y "!filenameoutput!" "!fpath!\!filenameoutput!"
rem delete macro folder mp3
del /f /q "!filenameoutput!"
rem clear variables
set "filename="
set "filenamenoextention="
set "filenameoutput="
)
