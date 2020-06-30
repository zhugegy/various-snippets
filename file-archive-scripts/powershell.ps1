$movepath = "C:\Documentstest"
$archpath = "C:\Archivetest"
$movedays = "10"
$currenttime = Get-Date
$zip = "C:\Program Files\7-Zip\7z.exe"


function  create-7zip([String] $aDirectory, [String] $aZipfile){
    [string]$pathToZipExe = "$($env:ProgramFiles)\7-Zip\7z.exe";
    [Array]$arguments = "a", "-tzip", "$aZipfile", "$aDirectory";
    & $pathToZipExe $arguments
}

Get-ChildItem -Path $movepath -Recurse | Where-Object {$_.LastWriteTime -gt (Get-Date).AddDays(-$movedays)} |
 ForEach {
 $filename = $_.FullName
 $zipfile = $filename+$(Get-Date -f dd-MM-yy)+".zip"
 create-7zip "$filename" "$zipfile" 
 Move-Item $zipfile -Destination $archpath -Force -ErrorAction:SilentlyContinue
 "Moved $zipfile to $archpath at $currenttime successfully"
 }