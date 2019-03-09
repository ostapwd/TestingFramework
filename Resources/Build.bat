SET RootPath=%cd%

SET MSBuildPath="C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin"

%MSBuildPath%\MSBuild.exe "%RootPath%\..\TestingFramework.sln" /p:WarningLevel=0 /p:BuildProjectReferences=true /t:Rebuild