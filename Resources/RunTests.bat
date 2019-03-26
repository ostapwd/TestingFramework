SET RootPath=%cd%
SET DllPath="%RootPath%\..\TestingFramework\bin\Debug\TestingFramework.dll"
SET TestList=%RootPath%\TestList.txt

CD "%RootPath%\NUnit.Console-3.9.0"
nunit3-console --testlist:"%TestList%" %DllPath% --workers=3