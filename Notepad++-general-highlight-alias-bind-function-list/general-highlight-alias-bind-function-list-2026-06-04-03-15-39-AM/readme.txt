
============================================
2026-06-04-02-46-34-AM
============================================
notepad++ language highlight with function list
general highlight alias bind function list
this is a general file highlight for numbers, aliases and keybinds
it picks out aliases and keybinds and puts them in the functionlist for notepad++
works for some game configs
specifically rust or team fortress 2
other games that uses aliases that match the pattern
might get picked up also
it also searches for bind
============================================
files:
general-highlight-alias-bind-function-list-fl.xml
general-highlight-alias-bind-function-list-language.xml
overrideMap.xml
============================================
normal notepad++ language install
============================================
close notepad++
============================================
put the -fl file here:
============================================
C:\Program Files\Notepad++\functionList
============================================
put the -language file here:
%AppData%\Roaming\Notepad++\userDefineLangs\
============================================
easier way:
just copy and paste the overrideMap.xml over top of the one in C:\Program Files\Notepad++\functionList
============================================
harder way:
editing overrideMap.xml:
open the overrideMap.xml here:
C:\Program Files\Notepad++\functionList

add these lines at the bottom above
</associationMap>

<association id= "general-highlight-alias-bind-function-list-fl.xml"	userDefinedLangName="general-highlight-alias-bind-function-list"/>
============================================


