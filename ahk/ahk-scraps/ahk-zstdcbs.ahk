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

zstdcbs()
{
;strreplace(zfnsfn, " ", "-")
zstdcbsstr := A_Clipboard
	if (zstdcbsstr = "") {
		zwmsg("zstdcbs - zstdcbsstr - clipboard empty string")
		return
	}
;sanitize any stray capitals with lower
;zstdcbsswapoutstr := strlower(zstdcbsstr)
;run title case
;zstdcbsswapoutstr := strtitle(zstdcbsswapoutstr)
zstdcbsswapoutstr := strreplace(zstdcbsstr, " ", "-")
A_Clipboard := zstdcbsswapoutstr
ztoasty()
return
}
