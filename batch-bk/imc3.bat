rem imc3
rem image magick conversion
rem uses d:\imc\
rem converts from jfif to png
rem all files in that directory
chdir /d d:
cd imc
magick mogrify -format png *.jfif