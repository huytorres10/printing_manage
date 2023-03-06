@ECHO OFF
echo %1
rundll32.exe printui.dll,PrintUIEntry /o /n %1
PAUSE