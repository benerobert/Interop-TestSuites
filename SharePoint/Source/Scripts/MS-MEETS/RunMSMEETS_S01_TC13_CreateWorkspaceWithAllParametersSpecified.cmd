@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_MEETS.S01_MeetingWorkspace.MSMEETS_S01_TC13_CreateWorkspaceWithAllParametersSpecified /testcontainer:..\..\MS-MEETS\TestSuite\bin\Debug\MS-MEETS_TestSuite.dll /runconfig:..\..\MS-MEETS\MS-MEETS.testsettings /unique
pause