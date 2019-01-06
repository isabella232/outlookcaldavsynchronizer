"C:\Program Files (x86)\Windows Kits\10\bin\10.0.17763.0\x86\signtool.exe" sign /tr http://timestamp.digicert.com /td sha256 /fd sha256 /sha1 "86B0AE3B15989A793D3FAAC6187A8136F45EB52E" %2

powershell.exe -ExecutionPolicy ByPass -File "%1getVersion.ps1" %1 %3
set /p version=<%1version.txt
"C:\Program Files (x86)\NSIS\makensis.exe" /DVERSION=%version% /DCONFIG=%3 %1SnapAppointmentsOutlookSync.nsi
del %1version.txt
