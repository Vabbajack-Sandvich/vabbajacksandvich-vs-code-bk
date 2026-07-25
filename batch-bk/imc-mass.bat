rem this is to do a sub directory
rem mass file convert from
rem webm to png
rem change the directory to what you want
rem use %%G - might not need to
rem D:\z-x2\pix\

rem chdir /d d:
rem cd imc
rem magick mogrify -format jpeg "*.jfif"
rem magick mogrify -format jpeg "*.webp"
rem this is the old mogrify batch

for /r "D:\z-x2\pix\" %%G in (*.webp) do (

echo %%G

magick mogrify -format jpeg "%%G"

del /f %%G

rem pause

)