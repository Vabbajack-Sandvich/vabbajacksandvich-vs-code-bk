rem ==================================================
rem 2026-07-10-08-59-34-AM
rem ==================================================
rem woodchipper filter process
rem audcity filter 0 and 6 db to macros from c:\m to macros audacity output
rem f1 filter shortcut
rem 2 thirds slower lower is part of the f1 filter
rem with winamp base eq
rem run filter 0 audacity filter on all of macros\t
rem it will leave the temp files in t
rem and output the newly filtered and amped
rem back to macros
rem run f2 filter shortcut
rem filter 2 - from macros\t to c:\vc with rename
rem then make a png file
rem leave 1 mp3 you want to be made in to an mp4
rem run i1 shortcut
rem to scan c:\vc for 1 mp3 and 1 png
rem then convert them into the blahblah_siv.mp4 video
rem suffix:
rem siv:
rem single image video
rem ==================================================
rem 2026-06-27-14-48-32-PM
rem ==================================================
rem keeping this in c:\zonide\zip\music\
rem dont plan on publishing the 1 and 2
rem 66666 zonide remix batch files
rem too easy to accidentally upload them by mistake
rem add -2-12db to audacity macro output mp3s
rem copy to 2 and C:\vc
@echo off
setlocal enabledelayedexpansion
rem macro path
rem C:\Users\zonid\OneDrive\Documents\Audacity\macro-output
rem set "mpath=C:\Users\zonid\OneDrive\Documents\Audacity\macro-output"
set "mpath=C:\Users\zonid\OneDrive\Documents\Audacity\macro-output"
rem the vc path
rem C:\vc
set "vpath=C:\vc"
rem the 2 path
rem C:\zonide\non-zip\2
set "fpath=C:\zonide\non-zip\2"
rem temp path
rem C:\Users\zonid\OneDrive\Documents\Audacity\macro-output
set "tpath=C:\Users\zonid\OneDrive\Documents\Audacity\macro-output\t"
md !tpath!
rem clear filename
set "filename="
cd !mpath!
for %%f in (*.mp3) do (
set "filename=%%f"
set "filenamenoextention=%%~nf"
set "filenameoutput=!filenamenoextention!-2-6db.mp3"
echo "file name change"
ren "!filename!" "!filenameoutput!"
rem copy /y "!filenameoutput!" "!vpath!\!filenameoutput!"
rem copy /y "!filenameoutput!" "!fpath!\!filenameoutput!"
rem move to vc
echo "move"
echo ""!filenameoutput! - !vpath!\!filenameoutput!"
move /y "!filenameoutput!" "!vpath!\!filenameoutput!"
rem echo "delete file"
rem echo "!filename!"
rem delete macro folder mp3
rem del /f /q "!filename!"
rem clear variables
set "filename="
set "filenamenoextention="
set "filenameoutput="
)
rem clear temp folder
rem tpath
cd !tpath!
for %%f in (*.mp3) do (
set "filename=%%f"
echo "clearing temp folder - !filename!"
del /f /q "!filename!"
)
