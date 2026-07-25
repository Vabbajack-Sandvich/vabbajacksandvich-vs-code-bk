rem imc2
rem image magick conversion
rem uses d:\imc\
rem converts from png to jpeg
rem all files in that directory
chdir /d d:
cd imc
magick mogrify -format jpeg *.png