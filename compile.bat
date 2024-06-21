@echo off

@REM This is the compile command
csc /out:Multi.exe /m:Home /win32icon:icon.ico *.cs

@REM These are unit testing because why not. Compiles, runs, then deletes the exe
csc /out:Testing.exe /m:UnitTests *.cs >bin/nul

.\Testing.exe
del .\Testing.exe