rem 2026-07-30-14-46-57-PM
rem music-bk sd card update
rem copy from local to sd card only
rem from
rem C:\zonide\non-zip\music-bk\2
rem to
rem D:\music-bk\2
rem D:\xfer\music-bk\2
rem using robocopy
rem it doesnt like slashes at the ends
rem cd C:\zonide\non-zip\music-bk\2
chdir /D D:
rem cd D:\music-bk\2
rem /XO is only modified files
rem robocopy "C:\zonide\non-zip\music-bk\2" "D:\music-bk\2" /XO

rem D:\xfer\music-bk\2
md "D:\xfer\music-bk\2"

rem robocopy "C:\zonide\non-zip\music-bk\2" "D:\xfer\music-bk\2" /XO
robocopy "C:\vc" "D:\xfer\music-bk\2" /XO

chdir /D C:

cd C:\

