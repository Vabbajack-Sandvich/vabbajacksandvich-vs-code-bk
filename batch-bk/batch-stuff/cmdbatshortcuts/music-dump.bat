rem 2026-06-14-01-11-43-AM

rem this goes through each sub directory
rem in C:\zonide\non-zip\music and dumps the files in to C:\zonide\non-zip\music

rem to use this:
rem copy and paste a directory in
rem C:\zonide\non-zip\music
rem if you dont have a C:\zonide\non-zip\music folder
rem make one or rename C:\zonide\non-zip\music to
rem whatever folder you want

rem /D is for directories
rem /R is for sub directories
rem /Y is for disabling prompting

cd C:\zonide\non-zip\music

for /D %%a in (*) do (
for /R %%f in (*.*) do (
move /Y "%%f" "C:\zonide\non-zip\music"
rem timeout /t 1 /nobreak
)
rem timeout /t 1 /nobreak
)

