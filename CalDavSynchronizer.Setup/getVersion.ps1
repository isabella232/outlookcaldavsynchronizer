$1=$args[0]
$3=$args[1]

$parent = (Get-Item $1).parent.FullName

$version = (Get-Item $parent"\CalDavSynchronizer\obj\$3\CalDavSynchronizer.dll").VersionInfo.ProductVersion

Out-File -FilePath $1"version.txt" -InputObject $version -Encoding ASCII -Width 50