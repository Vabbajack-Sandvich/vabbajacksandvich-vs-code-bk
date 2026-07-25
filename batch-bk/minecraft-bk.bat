cd c:\zonide\msi-xfer

set mydate=%date:/=%
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%

set basep=C:\zonide\msi-xfer\brs-2-6-6-

set "finalpath=%basep%%mytimestamp%"

echo finalpath

pause

rem md "C:\zonide\msi-xfer\brs-2-6-6 %mytimestamp"

rem robocopy "C:\zonide\msi-xfer\" "D:\zonide\music" /s /zb /copy:dat /mt:32 /xo /r:5 /w:5 /v