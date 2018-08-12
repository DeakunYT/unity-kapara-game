; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{93F391E5-2FE2-4E2B-B53C-0D66BEBF76E7}
AppName=KaparaGame
AppVersion=0.0.3
AppPublisher=Giora Guttsait
AppPublisherURL=https://www.github.com/gioragutt
AppSupportURL=https://www.github.com/gioragutt
AppUpdatesURL=https://www.github.com/gioragutt
DefaultDirName={pf}\KaparaGame
DisableProgramGroupPage=yes
OutputDir=D:\Repositories\Unity\HowToMakeAVideoGame\Builds\Installer
OutputBaseFilename=Kapara Setup (x86)
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "D:\Repositories\Unity\HowToMakeAVideoGame\Builds\Windows\x86\Kapara.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Repositories\Unity\HowToMakeAVideoGame\Builds\Windows\x86\Kapara_Data\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\KaparaGame"; Filename: "{app}\Kapara.exe"
Name: "{commondesktop}\KaparaGame"; Filename: "{app}\Kapara.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\KaparaGame"; Filename: "{app}\Kapara.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\Kapara.exe"; Description: "{cm:LaunchProgram,KaparaGame}"; Flags: nowait postinstall skipifsilent
