rem ==================================================
rem 2026-06-26-02-21-37-AM
rem ==================================================
rem ==================================================
rem 		TLDR
rem	  just change the gain section
rem easiest way is to click and hold
rem the winamp eq slider and look at
rem 	   the main window
rem ==================================================
rem ==================================================

rem @echo off
@echo on

cd c:\vc

setlocal enabledelayedexpansion

rem winamp
rem 70
rem 180
rem 320
rem 600
rem 1k
rem 3k
rem 6k
rem 12k
rem 14k
rem 16k
rem winamp widths
rem base to -1 next bar

rem math variables
rem change these easily
rem when making new file variations
rem set "base=0"
rem set /a "width=0"
rem set "gain=0"
rem set "widthtype=h"

echo "base section"
rem winamp
rem set "base1=0"
set "base1=70"
set "base2=180"
set "base3=320"
set "base4=600"
set "base5=1000"
set "base6=3000"
set "base7=6000"
set "base8=12000"
set "base9=14000"
set "base10=16000"

echo "width_type section"
rem width_type:
rem How the bandwidth is defined
rem h  =  for Hz
rem q  =  for Q-factor
rem o  =  for octave
rem set "widthtype=h"
set "widthtype1=h"
set "widthtype2=h"
set "widthtype3=h"
set "widthtype4=h"
set "widthtype5=h"
set "widthtype6=h"
set "widthtype7=h"
set "widthtype8=h"
set "widthtype9=h"
set "widthtype10=h"

echo "width section"
rem set /a "width1=0"
set /a "width1=base2 - base1 - 1"
set /a "width2=base3 - base2 - 1"
set /a "width3=base4 - base3 - 1"
set /a "width4=base5 - base4 - 1"
set /a "width5=base6 - base5 - 1"
set /a "width6=base7 - base6 - 1"
set /a "width7=base8 - base7 - 1"
set /a "width8=base9 - base8 - 1"
set /a "width9=base10 - base - 1"
set /a "width10=500"

rem you can see the gain if you open the winamp window
rem control w or double click
rem for the main window, eq and playlists
rem clicking and holding, but without moving the mouse
rem you can see the slider gain + or -
rem in the main window, for each slider frequency

echo "gain section"
rem winamp slider bar frequencies in Hz (Hertz)
rem set /a "gain1=0"
rem 70
set "gain1=4.8"
rem 180
set "gain2=3.6"
rem 320
set "gain3=-4.8"
rem 600
set "gain4=3.2"
rem 1k
set "gain5=0"
rem 3k
set "gain6=-0.6"
rem 6k
set "gain7=-4.4"
rem 12k
set "gain8=-3.2"
rem 14k
set "gain9=-4.4"
rem 16k
set "gain10=5.1"

rem equalizer=f=base6:
rem f:
rem The central target frequency in Hz

rem width_type=h:
rem How the bandwidth is defined
rem h  =  for Hz
rem q  =  for Q-factor
rem o  =  for octave
rem set /a "widthtype=0"

rem w=width1:
rem The width value matching your chosen width_type

rem g=gain1
rem The volume gain or reduction in dB

rem ==================================================
rem default
rem ==================================================
rem filter complex mode default
rem faster and all at once instead of individually
rem ==================================================
rem complex filter break down
rem for copy and paste modifications for
rem other revisions
rem you can find replace \r\n
rem after you duplicated or modify
rem each individual central part of the
rem complex filter. the equalizer lines.
rem simply, you can edit it easily with the returns
rem then copy and paste it in to a new notepad temp file
rem and find replace \r\n with nothing
rem and it will put it back together in to one line
rem with the updated complex filter changes
rem having the base width and gains
rem seperated in the top of the file
rem means you only have to change
rem those values at the top
rem if you want the eq to be different
rem in different eq variations
rem ==================================================
rem ==================================================
rem multi line break down
rem ==================================================
rem winamp high and low gain
rem +12dB and -12dB
rem mid would be 6dB
rem each line within the central part of the complex filter
rem needs to be seperated with only a comma
rem with nocomma at the end before [aout]
rem each individual seperator is on its own line
rem for easy reassembly using find replace \r\n nothing
rem and copy and pasting etc for eq file variations
rem ==================================================
rem ==================================================
rem ffmpeg -i -y "%%f"
rem -filter_complex "
rem [0:a] equalizer=f=!base1!:width_type=!widthtype1!:w=!width1!:g=!gain1!,
rem equalizer=f=!base2!:width_type=!widthtype2!:w=!width2!:g=!gain2!,
rem equalizer=f=!base3!:width_type=!widthtype3!:w=!width3!:g=!gain3!,
rem equalizer=f=!base4!:width_type=!widthtype4!:w=!width4!:g=!gain4!,
rem equalizer=f=!base5!:width_type=!widthtype5!:w=!width5!:g=!gain5!,
rem equalizer=f=!base6!:width_type=!widthtype6!:w=!width6!:g=!gain6!,
rem equalizer=f=!base7!:width_type=!widthtype7!:w=!width7!:g=!gain7!,
rem equalizer=f=!base8!:width_type=!widthtype8!:w=!width8!:g=!gain8!,
rem equalizer=f=!base9!:width_type=!widthtype9!:w=!width9!:g=!gain9!,
rem equalizer=f=!base10!:width_type=!widthtype10!:w=!width10!:g=!gain10!
rem [aout]"
rem -map "
rem [aout]"
rem -map "
rem 0:v"
rem "
rem %%~nf_winamp-eq-highbass-verylow320-midhigh-dip-highhigh.mp3"
rem ==================================================
rem ==================================================
rem 2026-06-26-01-46-54-AM
rem default complex filter copy and paste
rem ==================================================
rem default single line
rem ==================================================
rem ffmpeg -y -i "%%f" -filter_complex "[0:a]equalizer=f=!base1!:width_type=!widthtype1!:w=!width1!:g=!gain1!,equalizer=f=!base2!:width_type=!widthtype2!:w=!width2!:g=!gain2!,equalizer=f=!base3!:width_type=!widthtype3!:w=!width3!:g=!gain3!,equalizer=f=!base4!:width_type=!widthtype4!:w=!width4!:g=!gain4!,equalizer=f=!base5!:width_type=!widthtype5!:w=!width5!:g=!gain5!,equalizer=f=!base6!:width_type=!widthtype6!:w=!width6!:g=!gain6!,equalizer=f=!base7!:width_type=!widthtype7!:w=!width7!:g=!gain7!,equalizer=f=!base8!:width_type=!widthtype8!:w=!width8!:g=!gain8!,equalizer=f=!base9!:width_type=!widthtype9!:w=!width9!:g=!gain9!,equalizer=f=!base10!:width_type=!widthtype10!:w=!width10!:g=!gain10![aout]" -map "[aout]" "%%~nf_winamp-eq-highbass-verylow320-midhigh-dip-highhigh.mp3"
rem ==================================================
rem ==================================================
rem 2026-06-26-02-13-15-AM
rem ==================================================
rem got bored
rem doctor?!
rem are you sure this will...
rem *explodes*
rem work....
rem i guess is no then
rem ==================================================
rem                             .+######+-                                   
rem                          .+############+                                 
rem                         +################-                               
rem                        ###################+                              
rem                       +#####################.                            
rem                      -###############+-----##.                           
rem                      -+#####+-----+##++###+###+                          
rem                     .-++##+--###++++####+++####-                         
rem                     .-++##+++##+++++######+++###-.                       
rem                    -++++#####+++##+++#++##++++##+++#+.                 ..
rem                   .+++++#++++++++##-----+###++++#---+##########++++++####
rem                   .-+++++++++++++###+--++#####++#####+-+++++----------+++
rem                    -++++++++++++++#++++++++++++++#####-++++++------------
rem                   .++++++++++++++++++++---+++++++#####+-+++++------------
rem                 .##++++++++++++++++++---...-++++++#####--++++------------
rem               .+-+-++++++++++-------+++##++++-+++++####+-----------------
rem             .++--+#+-+#++++----------+++++++--+++++###+------------------
rem           .++-####++-+#++--------------------------+##+-----+------------
rem           -++-++++----+#+--------------------------+#+-------------------
rem         .-+--..--+#+---+++------------------------+##+-------------------
rem       .++-...-+###+-----+++-----------------------+++--------------------
rem       .--..-####++-----++++++--------------------+++---------------------
rem        ..++-.+++--------++++++------------------+++----------------------
rem      ..----....-+###+----++++++---------------+++++------+---------------
rem     -+-......-+#####+-----++##++++--------+--+++++-----------------------
rem     .---..-++-#####++--.---++###+++++++----++++++------------------------
rem      ..--+++++#+++++---.----++####+++++++++++++++------------------------
rem     .--+++++--....-+###+--.--++#####++++++++++++#+----+------------------
rem ==================================================
rem why are you like this?
rem I HAVE NO IDEA!!
rem kind of looks like one
rem of the strogg
rem "i require stroyent"
rem ==================================================
rem 2026-06-26-02-56-29-AM
rem default single line
rem ffmpeg -y -i "%%f" -filter_complex "[0:a]equalizer=f=!base1!:width_type=!widthtype1!:w=!width1!:g=!gain1!,equalizer=f=!base2!:width_type=!widthtype2!:w=!width2!:g=!gain2!,equalizer=f=!base3!:width_type=!widthtype3!:w=!width3!:g=!gain3!,equalizer=f=!base4!:width_type=!widthtype4!:w=!width4!:g=!gain4!,equalizer=f=!base5!:width_type=!widthtype5!:w=!width5!:g=!gain5!,equalizer=f=!base6!:width_type=!widthtype6!:w=!width6!:g=!gain6!,equalizer=f=!base7!:width_type=!widthtype7!:w=!width7!:g=!gain7!,equalizer=f=!base8!:width_type=!widthtype8!:w=!width8!:g=!gain8!,equalizer=f=!base9!:width_type=!widthtype9!:w=!width9!:g=!gain9!,equalizer=f=!base10!:width_type=!widthtype10!:w=!width10!:g=!gain10![aout]" -map "[aout]" "%%~nf_winamp-eq-highbass-verylow320-midhigh-dip-highhigh.mp3"
rem ==================================================
rem 2026-06-26-03-06-52-AM
rem woo! hoo!
rem its alive!! ITS AAAALLIIIVVEE!!
rem finally got this working
rem ==================================================

for %%f in (*.mp3) do (

echo "file - %%f"

ffmpeg -y -i "%%f" -filter_complex "[0:a]equalizer=f=!base1!:width_type=!widthtype1!:w=!width1!:g=!gain1!,equalizer=f=!base2!:width_type=!widthtype2!:w=!width2!:g=!gain2!,equalizer=f=!base3!:width_type=!widthtype3!:w=!width3!:g=!gain3!,equalizer=f=!base4!:width_type=!widthtype4!:w=!width4!:g=!gain4!,equalizer=f=!base5!:width_type=!widthtype5!:w=!width5!:g=!gain5!,equalizer=f=!base6!:width_type=!widthtype6!:w=!width6!:g=!gain6!,equalizer=f=!base7!:width_type=!widthtype7!:w=!width7!:g=!gain7!,equalizer=f=!base8!:width_type=!widthtype8!:w=!width8!:g=!gain8!,equalizer=f=!base9!:width_type=!widthtype9!:w=!width9!:g=!gain9!,equalizer=f=!base10!:width_type=!widthtype10!:w=!width10!:g=!gain10![aout]" -map "[aout]" "%%~nf_winamp-eq-highbass-verylow320-midhigh-dip-highhigh.mp3"

)
