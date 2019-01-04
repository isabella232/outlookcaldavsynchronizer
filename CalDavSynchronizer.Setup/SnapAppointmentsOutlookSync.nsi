SilentInstall silent
RequestExecutionLevel user
OutFile "${CONFIG}\SnapAppointmentsOutlookSync-${VERSION}.exe"

Section
InitPluginsDir
SetOutPath $PluginsDir
File "${CONFIG}\SnapAppointmentsOutlookSync.Setup.msi"
File "${CONFIG}\setup.exe"
ExecWait '"$PluginsDir\setup.exe"' ; Double quotes on the path

SetOutPath $Temp ; SetOutPath locks the directory and we don't want to lock $PluginsDir
SectionEnd