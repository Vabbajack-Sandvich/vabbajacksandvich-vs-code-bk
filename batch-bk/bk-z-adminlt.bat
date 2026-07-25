rem overlapping backup
robocopy "D:\zonide" "e:\zonide" /e /z /copy:dat /mt:32 /dcopy:dat /xo /r:5 /w:1 /v
pause