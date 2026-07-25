rem 2026-06-13-22-28-03-PM

rem this goes through each sub directory
rem in C:\filedump and dumps the files in to C:\filedump

rem to use this:
rem copy and paste a directory in
rem C:\filedump
rem if you dont have a C:\filedump folder
rem make one or rename C:\filedump to
rem whatever folder you want

rem /D is for directories
rem /R is for sub directories
rem /Y is for disabling prompting

cd C:\filedump

for /D %%a in (*) do (
for /R %%f in (*.*) do (
move /Y "%%f" "C:\filedump"
rem timeout /t 1 /nobreak
)
rem timeout /t 1 /nobreak
)

