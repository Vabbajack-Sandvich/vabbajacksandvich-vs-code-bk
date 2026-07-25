rem 2026-06-27-11-51-23-AM
rem add -2 to audacity macro output mp3s


@echo off

setlocal enabledelayedexpansion

rem macro path
rem C:\Users\zonid\OneDrive\Documents\Audacity\macro-output
set "mpath=C:\Users\zonid\OneDrive\Documents\Audacity\macro-output"

cd !mpath!

for %%f in (*.mp3) do (
ren "%%f" "%%~nf-2.mp3"
)
