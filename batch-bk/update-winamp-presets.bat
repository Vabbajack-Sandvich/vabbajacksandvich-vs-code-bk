rem 2026-06-06-06-04-56-AM
rem this updates the vabbajack code base presets and the winamp section ones too
rem C:\Program Files (x86)\Winamp\Plugins\Milkdrop2\presets
xcopy "C:\Program Files (x86)\Winamp\Plugins\Milkdrop2\presets" "C:\zonide\zip\CODE\git\winamp-milkdrop-preset-edits\base\presets" /f /h /r /y /j /d /e

rem have to manually pick out the edits
rem this will still update both repos

rem C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\winamp-milkdrop-preset-edits\base\presets

xcopy "C:\Program Files (x86)\Winamp\Plugins\Milkdrop2\presets" "C:\zonide\zip\CODE\vabbajacksandvich-vs-code-bk\vabbajacksandvich-vs-code-bk\winamp-milkdrop-preset-edits\base\presets" /f /h /r /y /j /d /e

