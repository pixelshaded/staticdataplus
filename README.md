# staticdataplus
Static Data Script Generator for SQL Server

A continuation of http://leon.mvps.org/TFS/StaticData.aspx

Binaries are in Installers folder

![alt tag](https://github.com/pixelshaded/staticdataplus/raw/develop/v1.1.0_screenshot.png)

v1.1.1
- Fixed bug in line endings of Step 5 Delete Statement
- Fixed bug where UPDATE statement in Step 4 would still exist even if there were no columns to update

v1.1.0
- Added form for creating connection strings

v1.0.0
- Connection strings can be entered through UI and function similarly to SSMS (note these are saved in config file)
- Connection string can be changed at runtime
- Window resizing is now supported
- Added button to open drop folder from UI

# Building Project
Project was built with VS 2015

Visual Studio Installer Projects Extension is required
