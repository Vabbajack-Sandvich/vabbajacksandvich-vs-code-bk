
;=====================================================================
;test2
;=====================================================================

;=====================================================================

;this is for the control r random number generator output
global zrandmac := ""
global zrandmac02 := ""
global zrandipa100 := ""
global zInetAuto := 0

#MaxThreadsPerHotkey 2

SetKeyDelay 25, 10

return
;=====================================================================

;functions

;=====================================================================

zAudacityShortcutKeyPathFilter()
{
send "!o"
sleep 400
send "a"
sleep 400
send "m"
sleep 400
send "m"
sleep 400
send "{Enter}"
return
}

;=====================================================================

;functions

;=====================================================================
;2026-04-25-09-14-14-AM
;when you hold alt in a program
;the under lined letters
;are the underscore path
;this lets you feed a string
;of letters or numbers in
;and it does the alt path
;2026-06-19-01-58-22-AM
;! = alt
;usage zHotKeyPath("!tns")

zHotKeyPath(zHkp)
{
	if (zHkp = "") {
		return
	}
setkeydelay 400, 35
sendevent zHkp
sleep 400
send "{Enter}"
return
}

;=====================================================================

;zInetCheck
; Example usage:
;if (zInetCheck()) {
;    MsgBox, You are connected to a network.
;	}
;else {
;    MsgBox, You are not connected to a network.
;}

;returns 1 or 0
zInetCheck()
{
	zinet := DllCall("Wininet.dll\InternetGetConnectedState", "Str", "0x40", "Int", 0)
    Return zinet
}


;=====================================================================

;this toggles the auto internet connection timer
;if its not on, it turns the timer on
;if the timer is on it checks to see if you are connected
;if you arent connected it exectutes the generate random mac and ip
;then reconnects you

zInetAutoCheckTimerToggle()
{
global zInetAuto
	if (zInetAuto = 1) {
		zInetAuto := 0
		MsgBox("auto reconnect off")
	}
	else {
		zInetAuto := 1
		MsgBox("auto reconnect on")
		;start the loop here
		while zInetAuto = 1
		{
			if (zInetAuto = 0) {
				MsgBox("auto reconnect off2")
				return
			}
			;MsgBox(zInetCheck())
			if  (zInetCheck() = 0) {
				zgenandwriterndmacipbatchwriterunzeew()
				sleep 15000
			}
			sleep 5000
			;zInetAuto := 0
		}	
	}
return
}
;=====================================================================

zgenrandmac()
{
;this the global that the program uses
;to output the last randomly generated string
global zrandmac

;randdig is the digit from 1 to 12 for the hex code
;for the loop that iterates through the digits
;then generates a random number or letter
;then adds it to the end of the global zrandmac

;this count the passes of the loop which
;incriments the digit place, until it hits
;37 at which point it stops the loop
zrandinc := 1

;this is the loops random number from 1 to 36
;which the swich case thing uses to append
;an alpha numeric character based on which number matched
;which case, to the the global zrandmac
;by using itself to add to the end
randdig := 0

;this controls the loop
;if it is not 0 it will stop
zrandstop := 0

;reset zrandmac
zrandmac := ""

	while zrandstop = 0 {
		zranddig := Random(0, 15)
		Switch zranddig
			{
			Case 0:
				;0
				zrandmac := zrandmac "0"
			Case 1:
				;1
				zrandmac := zrandmac "1"
			Case 2:
				;2
				zrandmac := zrandmac "2"
			Case 3:
				;3
				zrandmac := zrandmac "3"
			Case 4:
				;4
				zrandmac := zrandmac "4"
			Case 5:
				;5
				zrandmac := zrandmac "5"
			Case 6:
				;6
				zrandmac := zrandmac "6"
			Case 7:
				;7
				zrandmac := zrandmac "7"
			Case 8:
				;8
				zrandmac := zrandmac "8"
			Case 9:
				;9
				zrandmac := zrandmac "9"
			Case 10:
				;A
				zrandmac := zrandmac "A"
			Case 11:
				;B
				zrandmac := zrandmac "B"
			Case 12:
				;C
				zrandmac := zrandmac "C"
			Case 13:
				;D
				zrandmac := zrandmac "D"
			Case 14:
				;E
				zrandmac := zrandmac "E"
			Case 15:
				;F
				zrandmac := zrandmac "F"
			;last select brace
			}
				
		if (zrandinc < 12)
		{
			zrandinc := zrandinc + 1
		}
		else {
			;stop the loop
			zrandstop := 1
		}
	;end loop brace
	}
;end of zgenrandhex
}

;=====================================================================

zgenrandmac02()
{

;this will set the first 2 to 02

;this the global that the program uses
;to output the last randomly generated string
global zrandmac02

;randdig is the digit from 1 to 12 for the hex code
;for the loop that iterates through the digits
;then generates a random number or letter
;then adds it to the end of the global zrandmac02

;this count the passes of the loop which
;incriments the digit place, until it hits
;37 at which point it stops the loop
zrandinc := 1

;this is the loops random number from 1 to 36
;which the swich case thing uses to append
;an alpha numeric character based on which number matched
;which case, to the the global zrandmac02
;by using itself to add to the end
randdig := 0

;this controls the loop
;if it is not 0 it will stop
zrandstop := 0

;reset zrandmac02
zrandmac02 := "02"

	while zrandstop = 0 {
		zranddig := Random(0, 15)
		Switch zranddig
			{
			Case 0:
				;0
				zrandmac02 := zrandmac02 "0"
			Case 1:
				;1
				zrandmac02 := zrandmac02 "1"
			Case 2:
				;2
				zrandmac02 := zrandmac02 "2"
			Case 3:
				;3
				zrandmac02 := zrandmac02 "3"
			Case 4:
				;4
				zrandmac02 := zrandmac02 "4"
			Case 5:
				;5
				zrandmac02 := zrandmac02 "5"
			Case 6:
				;6
				zrandmac02 := zrandmac02 "6"
			Case 7:
				;7
				zrandmac02 := zrandmac02 "7"
			Case 8:
				;8
				zrandmac02 := zrandmac02 "8"
			Case 9:
				;9
				zrandmac02 := zrandmac02 "9"
			Case 10:
				;A
				zrandmac02 := zrandmac02 "A"
			Case 11:
				;B
				zrandmac02 := zrandmac02 "B"
			Case 12:
				;C
				zrandmac02 := zrandmac02 "C"
			Case 13:
				;D
				zrandmac02 := zrandmac02 "D"
			Case 14:
				;E
				zrandmac02 := zrandmac02 "E"
			Case 15:
				;F
				zrandmac02 := zrandmac02 "F"
			;last select brace
			}
				
		if (zrandinc < 10)
		{
			zrandinc := zrandinc + 1
		}
		else {
			;stop the loop
			zrandstop := 1
		}
	;end loop brace
	}
;end of zgenrandhex
}

;=====================================================================

;this generates a random ip address for the wifi thing
;192.168.18.random above 100

zgenrandip()
{

;this the global that the program uses
;to output the last randomly generated string
global zrandipa100

;this count the passes of the loop which
;incriments the digit place, until it hits
zrandinc := 1

;this controls the loop
;if it is not 0 it will stop
zrandstop := 0

;reset zrandipa100
zrandipa100 := "192.168.18.1"

	while zrandstop = 0 {
		zranddig := Random(0, 9)
		Switch zranddig
			{
			Case 0:
				;0
				zrandipa100 := zrandipa100 "0"
			Case 1:
				;1
				zrandipa100 := zrandipa100 "1"
			Case 2:
				;2
				zrandipa100 := zrandipa100 "2"
			Case 3:
				;3
				zrandipa100 := zrandipa100 "3"
			Case 4:
				;4
				zrandipa100 := zrandipa100 "4"
			Case 5:
				;5
				zrandipa100 := zrandipa100 "5"
			Case 6:
				;6
				zrandipa100 := zrandipa100 "6"
			Case 7:
				;7
				zrandipa100 := zrandipa100 "7"
			Case 8:
				;8
				zrandipa100 := zrandipa100 "8"
			Case 9:
				;9
				zrandipa100 := zrandipa100 "9"
			;last select brace
			}
				
		if (zrandinc < 2)
		{
			zrandinc := zrandinc + 1
		}
		else {
			;stop the loop
			zrandstop := 1
		}
	;end loop brace
	}
;end of zgenrandip
}


;=====================================================================

;this generates random mac and random ip address and write them to batch files for zeew

;c:\rndmac.bat
;c:\rndip.bat

;REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 0219066D76EE /f

;netsh interface ipv4 set address name="Wi-Fi" static 192.168.18.212 255.255.255.0 192.168.18.1

zgenandwriterndmacipbatch()
{
global zrandipa100

zgenrandip()

global zrandmac02

zgenrandmac02()

;batch string to be written to the batch file
zbatstr := ""
zbatstr := zbatstr "`nrem this is a batch file write a random mac command for the wifi adapter"
zbatstr := zbatstr "`nREG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d " zrandmac02 " /f"

;random mac batch
;c:\rndmac.bat
zpath := "c:\rndmac.bat"

;open file:
;`n option: stand-alone `n to `r`n when writing
zile := FileOpen(zpath, "w`n")
	if !zile
	{
		;no file
		;zwmsg(zpath)
		return
	}

;write the file
zile.Write(zbatstr)

;close the file
zile.Close()

;sleep 1000

;batch string to be written to the batch file
zbatstr := ""
zbatstr := zbatstr "`nrem this is a batch file write a random ip command for the wifi adapter"
zbatstr := zbatstr "`nnetsh interface ipv4 set address name=Wi-Fi static " zrandipa100 " 255.255.255.0 192.168.18.1"

;random ip batch
;c:\rndip.bat
zpath := "c:\rndip.bat"

;open file:
;`n option: stand-alone `n to `r`n when writing
zile := FileOpen(zpath, "w`n")
	if !zile
	{
		;no file
		;zwmsg(zpath)
		return
	}

;write the file
zile.Write(zbatstr)

;close the file
zile.Close()


return
}

;=====================================================================

;this generates random mac and random ip address and write them to batch files for zeew

;then runs zeew.bat

;c:\rndmac.bat
;c:\rndip.bat
;C:\zonide\zip\programs-batch-files-10-14-2025-0\zeew.bat

;REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 0219066D76EE /f

;netsh interface ipv4 set address name="Wi-Fi" static 192.168.18.212 255.255.255.0 192.168.18.1

zgenandwriterndmacipbatchrunzeew()
{
global zrandipa100

zgenrandip()

global zrandmac02

zgenrandmac02()

;batch string to be written to the batch file
zbatstr := ""
zbatstr := zbatstr "`nrem this is a batch file write a random mac command for the wifi adapter"
zbatstr := zbatstr "`nREG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d " zrandmac02 " /f"

;random mac batch
;c:\rndmac.bat
zpath := "c:\rndmac.bat"

;open file:
;`n option: stand-alone `n to `r`n when writing
zile := FileOpen(zpath, "w`n")
	if !zile
	{
		;no file
		;zwmsg(zpath)
		return
	}

;write the file
zile.Write(zbatstr)

;close the file
zile.Close()

;sleep 1000

;batch string to be written to the batch file
zbatstr := ""
zbatstr := zbatstr "`nrem this is a batch file write a random ip command for the wifi adapter"
zbatstr := zbatstr "`nnetsh interface ipv4 set address name=Wi-Fi static " zrandipa100 " 255.255.255.0 192.168.18.1"

;random ip batch
;c:\rndip.bat
zpath := "c:\rndip.bat"

;open file:
;`n option: stand-alone `n to `r`n when writing
zile := FileOpen(zpath, "w`n")
	if !zile
	{
		;no file
		;zwmsg(zpath)
		return
	}

;write the file
zile.Write(zbatstr)

;close the file
zile.Close()

;C:\zonide\zip\programs-batch-files-10-14-2025-0\zeew.bat

run "C:\zonide\zip\programs-batch-files-10-14-2025-0\zeew.bat"

return
}


;=====================================================================

;this generates random mac and random ip address and write them to batch files for zeew

;then writes and runs zeew.bat

;instead of running the version of zeew
;that uses each batch file
;this just writes the whole zeew batch file

;default zeew
;rem this is for
;rem disabling the ethernet
;rem enabling the wifi and connecting
;
;rem disable ethernet
;netsh interface set interface Ethernet disable
;
;rem disable wifi
;netsh interface set interface Wi-Fi disable
;
;rem wait for it to disable
;timeout /t 2 /nobreak
;
;rem old working version
;rem REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 0219066D76EE /f
;
;rem adding this for random mac address
;rem REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 0219066F76FE /f
;
;rem adding the ahk random mac batch here
;call c:\rndmac.bat
;
;timeout /t 2 /nobreak
;
;rem enable wifi
;netsh interface set interface Wi-Fi enable
;
;rem pause
;
;rem wait for it to enable
;timeout /t 2 /nobreak
;
;rem pause
;
;rem call enet.bat
;
;call c:\rndip.bat
;
;rem pause
;
;rem connect
;rem netsh wlan connect ssid=ShaynePLuisA name=ShaynePLuisA interface=Wi-Fi
;netsh wlan connect ssid=ShaynePLuisA-2.4G name=ShaynePLuisA-2.4G interface=Wi-Fi
;
;rem pause

;c:\rndmac.bat
;c:\rndip.bat
;C:\zonide\zip\programs-batch-files-10-14-2025-0\zeew.bat

;REG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d 0219066D76EE /f

;netsh interface ipv4 set address name="Wi-Fi" static 192.168.18.212 255.255.255.0 192.168.18.1

zgenandwriterndmacipbatchwriterunzeew()
{
global zrandipa100

zgenrandip()

global zrandmac02

zgenrandmac02()

;batch string to be written to the batch file
zbatstr := ""

;rem disable ethernet
;netsh interface set interface Ethernet disable

zbatstr := zbatstr "`nrem disable ethernet"
zbatstr := zbatstr "`nnetsh interface set interface Ethernet disable"
zbatstr := zbatstr "`nnetsh interface set interface Wi-Fi disable"

zbatstr := zbatstr "`nrem wait for it to disable"
zbatstr := zbatstr "`ntimeout /t 2 /nobreak"

zbatstr := zbatstr "`nrem generate random mac command"
zbatstr := zbatstr "`nREG ADD HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0002 /v NetworkAddress /t REG_SZ /d " zrandmac02 " /f"


;timeout /t 2 /nobreak
zbatstr := zbatstr "`nrem wait to make sure it executed"
zbatstr := zbatstr "`ntimeout /t 2 /nobreak"

;zbatstr := zbatstr "`n"

;rem enable wifi
;netsh interface set interface Wi-Fi enable

zbatstr := zbatstr "`nrem enable wifi"
zbatstr := zbatstr "`nnetsh interface set interface Wi-Fi enable"

zbatstr := zbatstr "`nrem wait to make sure it enabled"
zbatstr := zbatstr "`ntimeout /t 2 /nobreak"

zbatstr := zbatstr "`nrem random ip command for the wifi adapter"
zbatstr := zbatstr "`nnetsh interface ipv4 set address name=Wi-Fi static " zrandipa100 " 255.255.255.0 192.168.18.1"

;rem connect
;netsh wlan connect ssid=ShaynePLuisA-2.4G name=ShaynePLuisA-2.4G interface=Wi-Fi

zbatstr := zbatstr "`nrem connect"
zbatstr := zbatstr "`nnetsh wlan connect ssid=ShaynePLuisA-2.4G name=ShaynePLuisA-2.4G interface=Wi-Fi"

;write zeew.bat then run it
zpath := "c:\zeew2.bat"

;open file:
;`n option: stand-alone `n to `r`n when writing
zile := FileOpen(zpath, "w`n")
	if !zile
	{
		;no file
		;zwmsg(zpath)
		return
	}

;write the file
zile.Write(zbatstr)

;close the file
zile.Close()

;run zpath

Run '*RunAs ' zpath 

return
}

;=====================================================================

;this toggles the auto internet connection check

;control shift i
$^+i::
{
zInetAutoCheckTimerToggle()
return
}

;=====================================================================

;this generates random ip and mac batches
;for zeew.bat

;control shift r
$^+r::
{
;zgenandwriterndmacipbatch()
;zgenandwriterndmacipbatchrunzeew()
zgenandwriterndmacipbatchwriterunzeew()
return
}

;=====================================================================

;2026-04-11-01-06-58-AM
;audacity
;music-audacity-macro-filter-0
;shortcut key paths:
;1:
;alt o a m m
;alt o a down x4 - asus

;2026-06-06-02-18-20-AM
;auto hot key note:
;if you are using the test2.ahk script
;the control left arrow hot key
;may not work
;you have to adjust the hot key path
;to match your hot key path in your
;copy of audacity
;
;hot key path:
;alt o opens tools
;alt a opens the sub menu apply macro
;then you have to count the number of M's
;before you hit enter

;control left arrow
$^left::
{
;MsgBox("ctrl left")
zAudacityShortcutKeyPathFilter()
return
}

;=====================================================================

;2026-04-11-01-06-58-AM
;audacity
;add new track
;alt t n s
;control down arrow
$^down::
{
;MsgBox("ctrl down")
zHotKeyPath("!tns")
return
}

;=====================================================================

