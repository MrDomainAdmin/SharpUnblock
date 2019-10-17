# SharpUnblock
C# binary designed to "Unblock" executables by deleting the zone-identifier ADS

This program should remove the zone-identifier that tells Windows that this program came from a remote location. This is also known as "Mark of the Web".
Syntax:
SharpUnblock.exe [Full Path of file in quotes]

Example:
SharpUnblock.exe "c:\program files\test\testprogram.exe"
