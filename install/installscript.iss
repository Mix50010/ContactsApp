[Setup] 
AppName=ContactsApp
AppId=F12F730C-2B3C-4079-936A-242C94C6A70A
AppVersion=1.0
WizardStyle=modern
DefaultDirName={autopf}\Goryachev\ContactsApp
DefaultGroupName=ContactsApp 
Compression=lzma2 
SolidCompression=yes 
OutputDir=Output
OutputBaseFilename=SetupContactsApp
SetupIconFile="ContactsApp_96x96.ico"
LicenseFile="..\LICENSE"
[Files] 
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\ContactsApp.View.exe"; DestDir: "{app}" 
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\*.dll"; DestDir: "{app}" 
[Tasks]
; Создание иконки на рабочем столе
Name: "desktopicon"; Description: "Создать значок на рабочем столе"; GroupDescription: "Дополнительные значки"; Flags: unchecked
Name: "groupicon"; Description: "Создать значок в меню быстрого доступа"; GroupDescription: "Дополнительные значки"; Flags: unchecked


[Icons]
Name: "{group}\ContactsApp"; Filename: "{app}\ContactsApp.View.exe"; Tasks: groupicon
Name: "{group}\ContactsAppUnins"; Filename: "{app}\unins000.exe"; Tasks: groupicon 
Name: "{commondesktop}\ContactsApp"; Filename: "{app}\ContactsApp.View.exe"; Tasks: desktopicon