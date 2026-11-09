rem ===========================
rem 2026-11-08-21-04-44-PM
rem ===========================
rem making a timelapse video
rem using frames and a images.txt
rem with specified durations
rem ===========================
rem example of images.txt format
rem ===========================
rem ffconcat version 1.0
rem file 'slide_a.png'
rem duration 3.0
rem file 'slide_b.jpg'
rem duration 5.5
rem file 'slide_c.png'
rem duration 2.0
rem file 'slide_c.png'
rem ===========================
rem example command
rem ===========================
rem ffmpeg -f concat -safe 0 -i images.txt -vsync vfr -c:v libx264 -pix_fmt yuv420p output.mp4
rem ===========================
rem use zonide.exe to get a file list
rem then regex or extended replace
rem to find the .jpg and add a line
rem with a specific duration
rem andd the file ' ' formating
rem using alt shift and page down
rem in notepad ++ then typing file
rem works to add that part easily first
rem then finding .jpg and replacing with
rem .jpg'. then finding '\r\n
rem and replacing with
rem '\r\nduration 0.5\r\n
rem (Note: Due to an internal FFmpeg quirk,
rem you must repeat the final file at the
rem very bottom without a duration directive
rem for the last duration to register correctly).
rem encoding:
rem images.txt has to be utf-8

cd c:\vc

rem -r 24 messes up the duration
rem trying to re-encode it to 24
rem afterward
rem ffmpeg -r 24 -f concat -safe 0 -i images.txt -vsync vfr -c:v libx264 -pix_fmt yuv420p jpg-frames-to-mp4-24-fps-output.mp4
ffmpeg -f concat -safe 0 -i images.txt -vsync vfr -c:v libx264 -pix_fmt yuv420p jpg-frames-to-mp4-half-second-duration-output.mp4

ffmpeg -i jpg-frames-to-mp4-half-second-duration-output.mp4 -r 24 jpg-frames-to-mp4-24-fps-output.mp4
