@REM BUG: Dittums DotNet doesn't like any files existing in the destination directory
Del /F /Q .\HandBrakeWPF\bin\publish\*.*

@REM Build the static library version of HB (single .EXE)
DotNet publish -p:PublishProfile=publish_x64

@REM Remove redundant files
Del /F /Q .\HandBrakeWPF\bin\publish\*.pdb

@REM Copy required support files into the destination directory
XCopy ..\..\build\HandBrakeCLI.exe .\HandBrakeWPF\bin\publish /V /C /R /Y
XCopy ..\..\build\libhb\hb.dll     .\HandBrakeWPF\bin\publish /V /C /R /Y
XCopy .\HandBrake.Worker\bin\publish\*.exe .\HandBrakeWPF\bin\publish /I /V /C /R /Y
XCopy .\doc\*.* .\HandBrakeWPF\bin\publish\doc /I /V /C /R /Y

@REM Visual feedback that it all worked
Dir /O:GN .\HandBrakeWPF\bin\publish
