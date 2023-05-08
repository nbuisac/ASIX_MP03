@echo off
IF %1 LSS 9 GOTO MENYSDE10
FOR /L %%i IN (1 , 1 , 9) do (
    dir Exercici0%%i && rmdir /S /Q Exercici0%%i
)
FOR /L %%i IN (10 , 1 , %1) do (
    dir Exercici%%i && rmdir /S /Q Exercici%%i
)
FOR /L %%i IN (1 , 1 , 9) do (
    mkdir Exercici0%%i
)
FOR /L %%i IN (10 , 1 , %1) do (
    mkdir Exercici%%i
)
GOTO FI

:MENYSDE10
FOR /L %%i IN (1 , 1 , %1) do (
    dir Exercici0%%i && rmdir /S /Q Exercici0%%i
)
FOR /L %%i IN (1 , 1 , %1) do (
    mkdir Exercici0%%i
)

:FI
echo Adeu
@echo on
