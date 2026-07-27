@rem ===================================================
@rem 2026-07-09-18-04-56-PM
@rem vabbajacksandvich.vb module update across each project
@rem in the 
@rem ===================================================


@rem not all the things use the module
@rem ill finish this later and make sure i do
@rem it manually just in case until then
@rem its not that it wont work
@rem i just dont want to automate this part

@rem 
@rem @rem =======================
@rem @rem 2026-07-04-23-07-35-PM
@rem @rem =======================
@rem @rem vabbajacksandvich.vb
@rem @rem updater across all things
@rem @rem =======================
@rem @rem first pass copies all things to the temp folder
@rem @rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-temp
@rem @rem =======================
@rem set "zsrcpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\"
@rem set "zdestpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-temp\"
@rem set "zfilename=vabbajacksandvich.vb"
@rem 
@rem cd !zsrcpath!
@rem 
@rem for /f "usebackq delims=" %%a in ("!zfilename!") do (
@rem     @rem this is where it reads the files
@rem 	@rem then performs commands on each file name
@rem 	@rem using %%a
@rem 	echo %%a
@rem 	@rem move /y "%%a" "!zdestpath!"
@rem 	@rem xcopy "%%a" "%zdestpath%" /f /h /r /y /j /d
@rem pause
@rem 	echo "src %%a\!zfilename! dest !zdestpath!"
@rem 	@rem xcopy "%%a\!zfilename!" "!zdestpath!" /f /h /r /y /j /d /i /e
@rem 	@rem damned e switch
@rem 	xcopy "%%a\!zfilename!" "!zdestpath!" /f /h /r /y /j /d /i
@rem )
@rem 
@rem 
@rem @rem then copy back from temp back to each one
@rem 
@rem @rem ================================================
@rem @rem ================================================
@rem @rem second pass - copies the updated 1 to all the others
@rem @rem ================================================
@rem @rem ================================================
@rem 
@rem 

@rem ================================================
@rem ================================================
@rem pause
@rem ================================================
@rem ================================================


@rem not all the things use the module
@rem ill finish this later and make sure i do
@rem it manually just in case until then
@rem its not that it wont work
@rem i just dont want to automate this part

setlocal EnableDelayedExpansion

@echo off

rem ============================================================================
call poot.bat
pause
rem ============================================================================

@rem 
@rem @rem =======================
@rem @rem 2026-07-04-23-07-35-PM
@rem @rem =======================
@rem @rem vabbajacksandvich.vb
@rem @rem updater across all things
@rem @rem =======================
@rem @rem first pass copies all things to the temp folder
@rem @rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-temp
@rem @rem =======================
set "zsrcpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\"
set "zdestpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-temp\"
@rem this is for what folders to search through
set "zlistfilename=code-repo-folders.txt"
@rem this is for the file to copy
set "zcopyfilename=vabbajacksandvich.vb"

cd !zsrcpath!

@rem copy everything to the temp folder from each folder
@rem in the folder path list with just the folder name in it
@rem in the zlistfilename variable
@rem example:
@rem this is what the file should contain to itterate though
@rem in the loop. make sure to have a return at the end
@rem with an empty line
@rem Machine Set Calculator
@rem scraps
@rem zCodeGen
@rem zComparator
@rem zFile
@rem zLineCombine
@rem zProcess
@rem zTf2Script
@rem zVabbajackSandvichModuleMaster
@rem zVabbajackSandvichModuleMaster-bk

@rem the zcopyfilename variable is for the module file you want to copy
@rem example:
@rem vabbajacksandvich.vb

setlocal EnableDelayedExpansion

for /f "usebackq delims=" %%a in ("!zlistfilename!") do (
    @rem this is where it reads the files
	@rem then performs commands on each file name
	@rem using %%a
	
	echo "============================================================================"
	echo "percent percent a - %%a"
	echo "============================================================================"
	echo "zsrcpath = !zsrcpath!"
	echo "zdestpath = !zdestpath!"
	echo "zlistfilename = !zlistfilename!"
	echo "zcopyfilename = !zcopyfilename!"
	echo "============================================================================"
	
	@rem move /y "%%a" "!zdestpath!"
	@rem xcopy "%%a" "%zdestpath%" /f /h /r /y /j /d
	
	@rem defbk
	@rem echo "src %%a\!zlistfilename! dest !zdestpath!"
	echo "%% %% a\!zcopyfilename! dest !zdestpath!"
	echo "%%a\!zcopyfilename! dest !zdestpath!"
	echo "============================================================================"
	@rem echo "this is going to copy next, so stop it here if needed"
	@rem pause
	@rem pause
	@rem xcopy "%%a\!zlistfilename!" "!zdestpath!" /f /h /r /y /j /d /i /e
	@rem damned e switch
	@rem this is the defbk
	@rem xcopy "%%a\!zlistfilename!" "!zdestpath!" /f /h /r /y /j /d /i
	xcopy "%%a\!zcopyfilename!" "!zdestpath!" /f /h /r /y /j /d /i
	echo "============================================================================"
	@rem pause
)

@rem then copy back from temp back to each one

@rem ================================================
@rem ================================================
@rem second pass - copies the updated 1 to all the others
@rem ================================================
@rem ================================================

rem ============================================================================
call bool.bat
rem ============================================================================

@rem ================================================
@rem ================================================
pause
@rem ================================================
@rem ================================================

@rem from here i should copy the one in temp
@rem back to each folder

setlocal EnableDelayedExpansion

@rem @rem =======================
@rem set "zsrcpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\"
@rem swapping zsrc and zdest
@rem set "zdestpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-temp\"
set "zsrcpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\zVabbajackSandvichModuleMaster-temp\"
set "zdestpath=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\"
@rem this is for what folders to search through
@rem adding the full path to this one
set "zlistfilename=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\visualstudio\code-repo-folders.txt"
@rem this is for the file to copy
set "zcopyfilename=vabbajacksandvich.vb"

cd !zsrcpath!

@rem copy everything to the temp folder from each folder
@rem in the folder path list with just the folder name in it
@rem in the zlistfilename variable
@rem example:
@rem this is what the file should contain to itterate though
@rem in the loop. make sure to have a return at the end
@rem with an empty line
@rem Machine Set Calculator
@rem scraps
@rem zCodeGen
@rem zComparator
@rem zFile
@rem zLineCombine
@rem zProcess
@rem zTf2Script
@rem zVabbajackSandvichModuleMaster
@rem zVabbajackSandvichModuleMaster-bk

@rem the zcopyfilename variable is for the module file you want to copy
@rem example:
@rem vabbajacksandvich.vb

for /f "usebackq delims=" %%a in ("!zlistfilename!") do (
    @rem this is where it reads the files
	@rem then performs commands on each file name
	@rem using %%a
	echo "============================================================================"
	echo "percent percent a - %%a"
	echo "============================================================================"
	echo "zsrcpath = !zsrcpath!"
	echo "zdestpath = !zdestpath!"
	echo "zlistfilename = !zlistfilename!"
	echo "zcopyfilename = !zcopyfilename!"
	echo "============================================================================"
	
	@rem move /y "%%a" "!zdestpath!"
	@rem xcopy "%%a" "%zdestpath%" /f /h /r /y /j /d
	
	@rem defbk
	@rem echo "src %%a\!zlistfilename! dest !zdestpath!"
	@rem echo "%% %% a\^!zcopyfilename^! dest ^!zdestpath^!"
	@rem echo "%%a\!zcopyfilename! dest !zdestpath!\%%a"
	@rem echo "this is going to copy next, so stop it here if needed"
	@rem pause
	@rem pause
	@rem xcopy "%%a\!zlistfilename!" "!zdestpath!" /f /h /r /y /j /d /i /e
	@rem damned e switch
	@rem this is the defbk
	@rem xcopy "%%a\!zlistfilename!" "!zdestpath!" /f /h /r /y /j /d /i
	@rem xcopy "%%a\!zcopyfilename!" "!zdestpath!" /f /h /r /y /j /d /i
	echo "============================================================================"
	echo "!zsrcpath!!zcopyfilename! dest !zdestpath!percent percent a"
	echo "============================================================================"
	xcopy "!zsrcpath!!zcopyfilename!" "!zdestpath!%%a" /f /h /r /y /j /d /i
	echo "============================================================================"
	@rem pause
)

pause
rem ============================================================================
call unholy.bat
rem ============================================================================

pause
