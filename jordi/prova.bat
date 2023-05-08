@echo off
:inici
if "%1"=="" goto fi
echo %1
shift
goto inici
:fi
@echo on