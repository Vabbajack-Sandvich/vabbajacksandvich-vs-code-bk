==============================================================

# repo-bk batches

==============================================================

repo-bk Path:

https://github.com/Vabbajack-Sandvich/vabbajacksandvich-vs-code-bk/tree/main/batch-bk/batch-stuff/repo-bk

repo-bk Download:

https://github.com/Vabbajack-Sandvich/vabbajacksandvich-vs-code-bk/blob/main/batch-bk/batch-stuff/repo-bk-2026-07-14-13-30-24-PM.zip

==============================================================

The files that use code-repo-folders.txt:
repo-general-repo-update.bat
repo-vabbajacksandvich-module-version-update.bat
repo-vabbajacksandvich-module-version-update.bat

These do a full repo back up and use code-repo-folders.txt to pick directories to copy.

Change what directories get copied using:
code-repo-folders.txt

Example:
Machine Set Calculator
scraps
zCodeGen
zComparator
zFile
zLineCombine
zProcess
zTf2Script
zVabbajackSandvichModuleMaster
zVabbajackSandvichModuleMaster-bk
frmTextBoxFindPopUpModular
gLog

This will only iterate though those directories and skip any others.

==============================================================

repo-vabbajacksandvich-module-version-update.bat:

IMPORTANT NOTE: This assumes you will be making changes to only one version in one project at a time. If you make changes in more than one module copy in more than one project it will just use whichever one was changed last.

This copies each directories vabbajacksandvich.vb file to the temp folder.

This ensures that only the latest one will be in the temp folder by overlaying each copy from each directory in code-repo-folders.txt over top of the copy in the temp folder using last modified to only copy the latest one.

Then it copies from the temp folder to each directory listed in code-repo-folders.txt

==============================================================

cmdbatshortcuts Repo Path:

https://github.com/Vabbajack-Sandvich/vabbajacksandvich-vs-code-bk/tree/main/batch-bk/batch-stuff/cmdbatshortcuts

cmdbatshortcuts.zip Download:

https://github.com/Vabbajack-Sandvich/vabbajacksandvich-vs-code-bk/blob/main/batch-bk/batch-stuff/cmdbatshortcuts-2026-07-14-13-30-24-PM.zip

==============================================================

This also uses short name batch files from cmdbatshortcuts.

You have to add the paths to the Environment Variables in order to use them:

cmdbatshortcuts
asciiart
asciishortcuts

And whereever you put the repo-general-repo-update.bat.

You should also change the directories in each batch file as needed.

I tried to make it easy by using source and destination variables.

I recomend duplicating the line and putting REM in front of the duplicate line to save it, then you can just add or remove comments with different paths as needed, while also making it easy to keep track of potential revisions and the expected defaults.

repobk.bat is the file that calls repo-general-repo-update.bat

They arent anything more than batch files that call the other batch files:

repobk.bat:

```

rem ================================================
rem 2026-07-07-07-58-17-AM
rem make a batch that makes a time stamped text file
rem and outputs the output of this to the text file
rem as a log
rem ================================================

set mydateformat=%date:~10,4%%date:~6,3%/%date:~4,2%
echo %mydateformat%
set mydate=%mydateformat:/=-%
echo %mydate%
rem pause
rem exit /b
set mytime=%time::=%
set mytimestamp=%mydate: =_%_%mytime:.=_%
set mytimestamp=%mytimestamp: =%

call c.bat
call nr.bat
rem C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk
rem in folder
rem call repo-general-repo-update.bat > %mytimestamp%.txt
rem in specified foler

set "specifiedfolder=C:\zonide\zip\CODE\vabbajacksandvich-code-non-repo-bk\repo-update-logs\"

rem call "repo-general-repo-update.bat" > "%specifiedfolder%%mytimestamp%.txt"

rem call "repo-general-repo-update.bat" > "%specifiedfolder%%mytimestamp%.txt 2>&1" 

rem just call the batch in the cmd thing
call repo-general-repo-update.bat

```

x.bat also opens the cmd prompt to whatever path you are in to the explorer.

==============================================================
