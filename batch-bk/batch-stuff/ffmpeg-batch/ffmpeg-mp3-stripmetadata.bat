rem 2026-06-25-21-02-10-PM
rem updating this
rem strips metadata from mp3
cd C:\vc
for %%f in (*.mp3) do (
ffmpeg -y -i "%%f" -map_metadata -1 -c copy "%%~nf_md.mp3"
)
