@rem 2026-07-08-16-40-33-PM

@rem this
@rem moves the files from macros to c:\vc
@rem converts m4a to mp3
@rem deletes the m4a
@rem formats the file name
@rem adds -2 no 6db, filter only
@rem 2 thirds slower lower pitch
@rem delete the non converted file
@rem no eq

call c.bat
cd C:\zonide\zip\music\
call ffmpeg-mp3-zonide-66666-remix-5.bat
pause
call c.bat
