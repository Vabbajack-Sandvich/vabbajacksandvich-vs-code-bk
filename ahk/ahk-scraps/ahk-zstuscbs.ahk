;=====================================================================

;2026-06-09-19-31-12-PM
;zspacetounderscoreclipboardswap
;space to underscore clipboard swap
;this is to copy a string
;and filter it to remove all spaces
;and replace them with underscores
;then replace the clipboard contents
;with the new string
;then turn itself off

zstuscbs()
{
;strreplace(zfnsfn, " ", "-")
zstuscbsstr := A_Clipboard
	if (zstuscbsstr = "") {
		zwmsg("zstuscbs - zstuscbsstr - clipboard empty string")
		return
	}
;sanitize any stray capitals with lower
;zstuscbsswapoutstr := strlower(zstuscbsstr)
;run title case
;zstuscbsswapoutstr := strtitle(zstuscbsswapoutstr)
zstuscbsswapoutstr := strreplace(zstuscbsstr, " ", "_")
A_Clipboard := zstuscbsswapoutstr
ztoasty()
return
}
