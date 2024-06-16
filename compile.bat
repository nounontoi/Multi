@echo off

@REM This is the compile command
csc /out:Multi.exe /m:Home *.cs

@REM These are unit testing because why not. Compiles, runs, then deletes the exe
csc /out:Testing.exe /m:UnitTests *.cs

.\Testing.exe
del .\Testing.exe