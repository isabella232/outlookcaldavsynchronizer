$1=$args[0]

$parent = (Get-Item $1).parent.FullName

$version = (Get-Item $parent"\CalDavSynchronizer\obj\Debug\CalDavSynchronizer.dll").VersionInfo.ProductVersion

Out-File -FilePath $1"version.txt" -InputObject $version -Encoding ASCII -Width 50