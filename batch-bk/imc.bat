rem imc
rem image magick conversion
rem uses d:\imc\
rem converts from jfif to jpeg
rem all files in that directory
chdir /d d:
cd imc
rem magick mogrify -format jpeg "*.jfif"
magick mogrify -format jpeg "*.webp"
