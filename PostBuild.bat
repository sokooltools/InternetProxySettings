@echo off

if "%5" NEQ "" (goto:SKIP)

title SokoolTools: Post-Build

@echo ===============================================================================================================
@echo = (c) 2012-2019 SokoolTools.
@echo =
@echo = This batch file is used for post-build configuration and should be called directly from the Visual Studio 
@echo = project's [Post-Build] event command-line using the following syntax:
@echo =
@echo = "$(ProjectDir)Postbuild.bat" "$(ConfigurationName)" "$(SolutionDir)" "$(ProjectName)" "$(TargetDir)" "$(TargetName)"
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

net session >nul 2>&1
if errorlevel 1 (
	echo WARNING!!! This step could not be performed since 'Admin' permissions are required.
	echo ^(You need to restart Visual Studio as an administrator...^)
	GOTO:EOF
)

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

echo ======================================================================================
echo = Copy the target files to the "%%ProgramFiles(X86)%%\SokoolTools\.." folder. 
echo ======================================================================================
echo.
set src="%TargetDir%*.*"
set dst="%ProgramFiles(x86)%\SokoolTools\%ProjectName%\*"
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
CALL:DO_DEBUG_SPECIFIC_TASKS
if exist %dst%.pdb del/q %dst%.pdb
if exist %dst%.xml del/q %dst%.xml
GOTO:EOF

:: +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
