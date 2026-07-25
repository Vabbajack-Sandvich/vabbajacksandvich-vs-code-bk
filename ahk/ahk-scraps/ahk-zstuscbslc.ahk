;=====================================================================

;2026-06-09-19-31-12-PM
;zspacetounderscoreclipboardswaplc
;space to underscore clipboard swap lower case
;this is to copy a string
;and filter it to remove all spaces
;and replace them with underscores
;then replace the clipboard contents
;with the new string
;then turn itself off
;it also makes it lower case

zstuscbslc()
{
;strreplace(zfnsfn, " ", "-")
zstuscbslcstr := A_Clipboard
	if (zstuscbslcstr = "") {
		zwmsg("zstuscbslc - zstuscbslcstr - clipboard empty string")
		return
	}
;sanitize any stray capitals with lower
zstuscbslcswapoutstr := strlower(zstuscbslcstr)
;run title case
;zstuscbslcswapoutstr := strtitle(zstuscbslcswapoutstr)
zstuscbslcswapoutstr := strreplace(zstuscbslcstr, " ", "_")
A_Clipboard := zstuscbslcswapoutstr
ztoasty()
return
}
