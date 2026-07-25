rem this is a batch file for dragon2
rem this makes a overwriting backup
rem of all the minecraft worlds in this path
rem C:\Users\User\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds
rem to here on dragon 2
rem C:\zonide\gamebackups\minecraft\shayne-bedrock

xcopy "C:\Users\User\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds\" "C:\zonide\gamebackups\minecraft\shayne-bedrock\" /f /h /r /y /j /d /e
