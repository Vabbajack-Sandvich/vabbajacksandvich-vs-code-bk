![example 1](https://github.com/Vabbajack-Sandvich/AutoHotKey-Simple-Function-List-Language-Highlight/blob/main/ahk-notepadplusplus-functionlist-3.png?raw=true)



# TLDR for the TLDR: Windows
Just install it the same way you would any other language highlight or function list thing for Notepad++


# 1.1 - Update
Added spaces and equals to the search key and made the formatting more flexible, so it will find entries with any amount of tabs or spaces before the function or hotkey, whereas before it required strict formatting with the functions and hotkeys having zero spaces or tabs.

# 1.2 - Update
Made it so the curly brace can be on the same line or not.

# Autohotkey Notepad++ custom language highlight and function list files

This highlights syntax and finds function and hotkey definitions, and lists them in Notepad++ the function list window. 

This is intended to be simple and non-exhaustive.

This uses this regex pattern to make the function list in Notepad++ find the 2 things below:


```
^[\t*\x20{*}A-Z*a-z*\d*]+(?<!if not )(?<!if )(?<!else )(?<!while )(?<!while not )(?<!select )\({1}(?<! if not\()(?<!\tif not\()(?<! if\()(?<!\tif\()(?<! else\()(?<!\telse\()(?<! while\()(?<!\twhile\()(?<! while not\()(?<!\twhile not\()(?<! select\()(?<!\tselect\()[\,*[*A-Z*a-z*\d*\s*]*]*\){1}[\r\n]*[\t*\x20{*}]*[\{+]+|^[\x3d{*}\$\^\!\+*A-Z*a-z*\d]+[\:\:]+[\r\n]*[\t*\x20{*}]*[\{+]+
```


A function definition:

new line, however many tabs or spaces, function name, parenthesis, however many variables, parenthesis, return, how ever many tabs, open brace


```
blah(blah1, blah2, blah3)
{
	blahblah()
	return
}
```


or


A hot key definition:

new line, how ever many tabs, spaces, whatever symbols, whatever letter or number, double colons ::, return, however many tabs, open brace


```
$^+f::
{
	blah(1,2,3)
	return
}
```


Sorting by A-z#  in the Notepad++ function list or not means you can see where the function or hotkey falls in the code or not.

Trying to see all the variations of the hotkeys won't work alphanumerically, and they will be scattered, but if you group them alphanumerically in the code and switch the function list to display as it finds stuff in the code, it makes it easy to see all the functions and hotkeys relative to each other.


# Windows Install For Notepad++

# TLDR:

Sometimes the directories aren't in the paths. If they aren't make them there.

Sometimes depending on the Notepad++ install it will only work if you put the files all in the default install root directory.

Sometimes depending on the Notepad++ install it will only work if you put them all in the %APPDATA% version of the  directories.

Sometimes depending on the Notepad++ install it will only work if you put them BETWEEN in the %APPDATA% version of the  directories AND the default root install directory.

So, if you copy and paste the files in all the "right" directories, edit the overridemap.xml, reload Notepad++ and check the function list while looking at your .ahk file AND DON'T SEE ANYTHING IN THE FUNCTIONLIST!!!!

YOU DID EVERYTHING "RIGHT" AND DONT SEE ANYTHING IN THE FUNCTION LIST!!

I know that feeling because between the time I wrote the first version and the time I wrote this update, I forgot how I had it installed, had to reinstall Notepad++, which, somehow, apparently I did differently this time, came here, downloaded my own stuff, followed my own install directions and it still wouldn't work.

You have to try whichever combination of directories works on whichever type of Notepad++ install you have.

Editing the overridemap.xml and having the ahk-fl.xml in the functionlist in the C:\Program Files\Notepad++\functionList\ path AND making a new directory for userdefinedlang in the C:\Users\USERNAME\AppData\Roaming\ directory AND putting the ahk.xml language highlight file in the  C:\Users\USERNAME\AppData\Roaming\Notepad++\userdefinedlang\ directory is the combination that worked for me and is what the TLDR version of the installation WHICH IS NOT what is in the NON-TLDR version which is only in the %APPDATA% version of the Notepad++ install.

Also, you have to select ahk as your user defined language from the language menu while you have your .ahk file open that you want to highlight.

# ahk-fl.xml:

Put ahk-fl.xml here: C:\Program Files\Notepad++\functionList\

Folder: functionlist

```
functionlist
```

Path:

```
C:\Program Files\Notepad++\functionList\
```

# overrideMap.xml:

Edit overrideMap.xml to add this line at the end of the other matching lines at the end of the file. <association id= "ahk-fl.xml"	userDefinedLangName="ahk"/>

Folder: functionlist

```
functionList
```

```
<association id= "ahk-fl.xml"	userDefinedLangName="ahk"/>
```

Edit overrideMap.xml here: C:\Program Files\Notepad++\functionList\

Path:

```
C:\Program Files\Notepad++\functionList\
```

# ahk.xml:

Put ahk.xml here: C:\Users\USERNAME\AppData\Roaming\Notepad++\userdefinedlang\

Folder: userdefinedlang

```
userdefinedlang
```

Path: Replace USERNAME with your username.

```
C:\Users\USERNAME\AppData\Roaming\Notepad++\userdefinedlang\
```

# Non TLDR:

This is just both of the readme files for both the Custom Language Highlight Section and the Function List Section.


# Custom Language Highlight


Complete both sections, the overrideMap.xml and Language Highlight Sections

Both sections have to be completed for the language highlight and the function list to work.


# WINDOWS:


Copy and paste ahk.xml into this directory: C:\Users\USERNAME\AppData\Roaming\Notepad++\userDefineLangs\

```
C:\Users\USERNAME\AppData\Roaming\Notepad++\userDefineLangs\
```

Then restart Notepad++.

Open your .ahk file.

Select the ahk language from the bottom of the language menu.

Open the function list by going to view, then ticking the function list at the bottom of the view menu.

You might have to click on and off the ahk file, or click refresh on the functional, to see if everything worked properly.

But if it did work, you should see all your functions and all the hot keys with:: in the name.

# Function List and overrideMap.xml

Follow the directions for the custom language highlight and function list files.

Both sections have to be completed for the language highlight and the function list to work.


This goes at the end of the association section of the overrideMap.xml 

WINDOWS:

DIRECTORY:

```
C:\Users\USERNAME\AppData\Roaming\Notepad++\functionlist\
```

# overrideMap.xml

Copy and paste the ahk-fl.xml file into the same functionlist directory.

Complete both sections, the overrideMap.xml and Language Highlight Sections

Then restart Notepad++

Open your .ahk file

Select the ahk language from the bottom of the language menu.

Open the function list by going to view, then ticking the function list at the bottom of the view menu.

You might have to click on and off the ahk file or refresh the function list to see if everything worked properly. But if it did work, you should see all your functions and all the hot keys with :: in the name.


```
<association id= "ahk-fl.xml"	userDefinedLangName="ahk"/>
```

