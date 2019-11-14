@echo off

if "%5" NEQ "" (goto:SKIP)

title DevTools: Post-Build

@echo ===============================================================================================================
@echo = (c) 2012-2019 SokoolTools.
@echo =
@echo = This batch file is used for post-build configuration and should be called directly from the Visual Studio 
@echo = project's [Post-Build] event command-line using the following syntax:
@echo =
@echo = "$(ProjectDir)PostBuild.bat" "$(ConfigurationName)" "$(SolutionDir)" "$(ProjectName)" "$(TargetDir)" "$(TargetName)"
@echo =
@echo ===============================================================================================================
@echo.
@echo Press any key to continue . . . &pause>nul
goto:EOF

:SKIP

verify other 2>nul
setlocal EnableExtensions
if errorlevel 1 echo Unable to enable extensions

set Configuration=%~1
set SolutionDir=%~2
set ProjectDir=%~dp0
set ProjectName=%~3
set TargetDir=%~4
set TargetName=%~5
set TargetPath=%~4%~5

echo.
echo.
echo +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
echo BEGIN [%ProjectName%] Post-Build
echo - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

echo.
echo ======================================================================================
echo = List of local variables.
echo ======================================================================================
echo Configuration =	%Configuration%
echo SolutionDir   =	%SolutionDir%
echo ProjectDir    =	%ProjectDir%
echo ProjectName   =	%ProjectName%
echo TargetDir     =	%TargetDir%
echo TargetName    =	%TargetName%
echo TargetPath    =	%TargetPath%
echo ======================================================================================

echo.

if %Configuration% EQU Debug (
	CALL:DO_DEBUG_SPECIFIC_TASKS
) else (
	CALL:DO_RELEASE_SPECIFIC_TASKS
)

echo.
echo - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
echo END [%ProjectName%] Post-Build
echo +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
echo.
echo.
GOTO:EOF

:: +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
:DO_DEBUG_SPECIFIC_TASKS

net session >nul 2>&1
if errorlevel 1 (
	echo WARNING!!! This step could not be performed since 'Admin' permissions are required.
	echo ^(You need to restart Visual Studio as an administrator...^)
	GOTO:EOF
)

echo ======================================================================================
echo = Copy the target files to the "%%PROGRAMFILES(X86)%%\DevTools\.." folder. 
echo ======================================================================================
echo.
set src="%TargetPath%.*"
set dst="%PROGRAMFILES(X86)%\DevTools\%ProjectName%\*"
echo  Copying %src%
echo       to %dst%
echo    (Note: only new or modified files are copied.)
xcopy /y/q/d %src%  %dst%
echo.
echo ======================================================================================
echo = Copy the 'Setup' files to the "%%PROGRAMFILES(X86)%%\DevTools\.." folder.
echo ======================================================================================
echo.
set src="%ProjectDir%Setup\*.*"
set dst="%PROGRAMFILES(x86)%\DevTools\%ProjectName%\*"
echo  Copying %src%
echo       to %dst%
echo    (Note: only new or modified files are copied.)
xcopy /y/q/d %src%  %dst%
echo.
echo ======================================================================================
GOTO:EOF

:: +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
:DO_RELEASE_SPECIFIC_TASKS
echo.
echo -- No 'Release' specific tasks required. --
GOTO:EOF
