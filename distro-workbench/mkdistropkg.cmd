@echo off
cd /d "%~dp0"
setlocal
set "ZCMD=%ProgramFiles%\7-Zip\7z.exe"

if not exist dest (
    echo Please publish the Add-in first.
    pause
    exit /b 1
) 

copy require\confirm-address.cer dest\
copy require\setup.cmd dest\

cd dest
"%ZCMD%" a ..\archive.7z *.* -r -t7z -mmt=on
cd ..
copy /b require\7zSD.sfx + require\7zSDconfig.txt + archive.7z  Confirm-AddressOutlookSetupvxyz.exe

endlocal
pause .