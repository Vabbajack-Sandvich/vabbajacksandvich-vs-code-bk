@rem 2026-07-17-17-32-45-PM
@rem strips metadata from mp3
@rem then deletes the file
@rem cd C:\vc
@rem md c:\vc\t
@rem cd C:\zonide\non-zip\music
@rem md C:\zonide\non-zip\music\t

@rem @echo off
setlocal EnableDelayedExpansion

@rem ================================================
@rem          change this
@rem ================================================

@rem put \ at end of path
@rem correct:
@rem set "zsrcpath=C:\vc\"
@rem incorrect:
@rem set "zsrcpath=C:\vc"

set "zsrcpath=C:\vc\"
@rem set "zsrcpath=C:\zonide\non-zip\music\"
@rem set "zsrcpath=C:\zonide\non-zip\2\"

echo "zsrcpath - !zsrcpath!"
@rem ================================================
@rem ================================================

set "zdestpath=!zsrcpath!t\"
echo "zdestpath - !zdestpath!"

set "zfile=zfilelist.txt"
echo "zfile !zfile!"

cd !zsrcpath!

@rem make temp folder in whatever source path
md !zdestpath!

for %%f in (*.mp3) do (
@rem tyring to use the lame encoder to make sure it converts
@rem in case it still uses the aac stream from mp4
@rem from previous conversions without the updated
@rem mp4 to mp3 with lame encoder
@rem ffmpeg -y -i "%%f" -map_metadata -1 -c copy "%%~nf-md.mp3"
ffmpeg -y -i "%%f" -map_metadata -1 -vn -c:a libmp3lame "%%~nf-md.mp3"
timeout /t 1 /nobreak
@rem move stripped suffixed file to temp
echo "moving - %%~nf-md.mp3"
move /y "%%~nf-md.mp3" "!zdestpath!"
@rem pause
@rem delete original mp3
echo "deleting - %%f"
del /f /q "%%f"
timeout /t 1 /nobreak
)
