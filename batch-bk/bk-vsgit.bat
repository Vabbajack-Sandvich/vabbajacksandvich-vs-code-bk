rem 2025-10-20-14-35-26-PM
rem this copies the updated files
rem from the working visual studio folder
rem to the github folder

rem copy only the updated batchfiles to the batch file folder in visualstudio-git
xcopy "D:\*.bat" "D:\zonide\CODE\visualstudio-git\batch-bk\" /f /h /r /y /j /d

rem copy only the updated files from visualstudio to visualstudio-git
xcopy "D:\zonide\CODE\visualstudio\" "D:\zonide\CODE\visualstudio-git\" /f /h /r /y /j /d /e
