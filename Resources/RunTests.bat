SET RootPath=%cd%
SET DllPath=%RootPath%\..\TestingFramework\bin\Debug\TestingFramework.dll

CD "%RootPath%\NUnit.Console-3.9.0"
nunit3-console %DllPath%