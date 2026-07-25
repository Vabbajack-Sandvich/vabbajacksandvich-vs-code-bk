rem 6-21-2025-1552-0
rem ffmpeg
rem ffmpeg-copy-memos-to-zf.bat
rem delete zf.bat
rem copy vlc memos
rem rename memos.txt
rem run zf.bat
rem C:\Users\zonid\AppData\Roaming\vlc
rem C:\Users\zonid\AppData\Roaming\vlc\memos.txt
rem xcopy d:\zonide\*.bat D:\ /f /h /r /y /d
rem zf.bat

chdir /D d:
cd D:\vc

rem next
rem delete zf.bat

rem pause

del /q zf.bat

rem pause

rem next
rem copy vlc memos

rem xcopy d:\zonide\*.bat D:\ /f /h /r /y /d

xcopy C:\Users\zonid\AppData\Roaming\vlc\memos.txt D:\vc /f /h /r /y /d

rem pause

rem next
rem rename memos.txt

rename memos.txt zf.bat

rem next
rem run zf.bat

rem pause

zf.bat

rem pause
	