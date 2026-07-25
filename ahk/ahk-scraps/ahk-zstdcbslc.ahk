;=====================================================================

;2026-06-09-19-31-12-PM
;zspacetodashclipboardswap
;space to dash clipboard swap
;this is to copy a string
;and filter it to remove all spaces
;and replace them with dashs
;then replace the clipboard contents
;with the new string
;then turn itself off

zstdcbslc()
{
;strreplace(zfnsfn, " ", "-")
zstdcbslcstr := A_Clipboard
	if (zstdcbslcstr = "") {
		zwmsg("zstdcbslc - zstdcbslcstr - clipboard empty string")
		return
	}
;sanitize any stray capitals with lower
zstdcbslcswapoutstr := strlower(zstdcbslcstr)
;run title case
;zstdcbslcswapoutstr := strtitle(zstdcbslcswapoutstr)
zstdcbslcswapoutstr := strreplace(zstdcbslcstr, " ", "-")
A_Clipboard := zstdcbslcswapoutstr
ztoasty()
return
}
