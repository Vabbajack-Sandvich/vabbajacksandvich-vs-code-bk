rem overlapping backup
rem D:\youtubestuff
robocopy "D:\youtubestuff" "f:\youtubestuff" /e /z /copy:dat /mt:32 /dcopy:dat /xo /r:5 /w:1 /v
pause
robocopy "D:\zonide" "f:\zonide" /e /z /copy:dat /mt:32 /dcopy:dat /xo /r:5 /w:1 /v
pause