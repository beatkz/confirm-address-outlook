@set @temp=0/*
@echo off

:: Check for Mandatory Label/High Mandatory Level 
whoami /groups | find "S-1-16-12288" > nul
if "%errorlevel%"=="0" ( 
    echo �Ǘ��҂Ƃ��Ď��s�����o�������߁A�X�N���v�g�𑱍s���܂��B 
) else ( 
    echo �ʏ팠���ł̎��s�����o���܂����B
    echo ���[�U�[�A�J�E���g����_�C�A���O��\�����܂�: "%~dpnx0" %*

    if '%1'=='ELEV' (
        shift
    ) else (
        cscript.exe //e:jscript //nologo "%~f0" "%~0"
        exit /B
    )
)

:: Continue script here

rem Write your own code here  ==>
cd /d "%~dp0"
certutil -addstore root confirm-address.cer
certutil -addstore TrustedPublisher confirm-address.cer

start setup.exe
rem pause .
rem Write your own code here  <==

goto :EOF
*/
var UAC = new ActiveXObject("Shell.Application");
UAC.ShellExecute(WScript.Arguments(0), "ELEV", "", "runas", 1);