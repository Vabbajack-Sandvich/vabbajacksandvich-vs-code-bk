rem 2026-06-25-21-02-10-PM
rem updating this
rem strips metadata from mp4
cd C:\vc
for %%f in (*.mp4) do (
ffmpeg -y -i "%%f" -map_metadata -1 -c copy "%%~nf_md.mp4"
)
