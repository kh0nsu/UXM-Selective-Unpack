# UXM Selective Unpacker  
Enables file modding for DS1, DS2, SotFS, DS3, Sekiro and Elden Ring by unpacking game archives and patching the executable to load loose files instead.    
Requires [.NET 4.7.2](https://www.microsoft.com/net/download/thank-you/net472) - Windows 10 users should already have this.    
[Nexus Page](https://www.nexusmods.com/eldenring/mods/1651)    

# Usage  
When first starting the app, the default Steam location of Sekiro will be selected. If the game you want is installed somewhere else, use the Browse button to correct it.  

The Unpack button will extract all files from the game archives, unless you select files in the "View Files" menu.  

Any files you select with "View Files" will be the only files unpacked, if you have the "Use Selected Files" checkbox checked (Which will be checked for you if you hit "OK" in the "View Files" menu).  

The Patch button will modify the executable to use those extracted files instead of looking in the archives; please note that for Sekiro, most users should use Mod Engine instead of patching. Patching the executable without also unpacking the archives will crash the game, so make sure you do both.  

Finally, the Restore button will restore the original executable and delete the extracted files, and the Abort button will cancel any operation in progress.  

# Bannability
UXM only edits data within the executable, not code, so anticheat should have no effect on it. File mods in general have never been grounds for a ban in any of the Souls games, but mods that alter your save may not be safe, so please consult your mod author's advice and play offline if using anything dubious.  

Elden Ring  
You cannot play online with an modified exe, so you cannot go online with an unpacked game (Nor can you go online with Mod Engine 2)  

# Credits  
[TKGP](https://github.com/JKAnderson) original Author  

[Meowmaritus](https://github.com/Meowmaritus) for Elden Ring compatibility  

[BinderTool](https://github.com/Atvaark/BinderTool) by Atvaark  

[Costura.Fody](https://github.com/Fody/Costura) by Simon Cropp, Cameron MacFarland  

[Octokit](https://github.com/octokit/octokit.net) by GitHub  

[Semver](https://github.com/maxhauser/semver) by Max Hauser  

# Building

SoulsFormats must be cloned next to the UXM folder. Must switch to ER branch for ER support.

# Changelog  
### 2.1.3  
* Added 21 new files from 1.06 patch 
	+/map/m10/m10_00_00_00/m10_00_00_00_910021.mapbnd.dcx  
	+/map/m60/m60_08_12_02/m60_08_12_02_32355002.mapbnd.dcx  
	+/map/m60/m60_09_13_02/m60_09_13_02_76395404.mapbnd.dcx  
	+/map/m60/m60_13_10_02/m60_13_10_02_41524102.mapbnd.dcx  
	+/map/m60/m60_17_25_01/m60_17_25_01_32355002.mapbnd.dcx  
	+/map/m60/m60_19_27_01/m60_19_27_01_76395404.mapbnd.dcx  
	+/map/m60/m60_26_20_01/m60_26_20_01_41524102.mapbnd.dcx  
	+/map/m60/m60_35_50_00/m60_35_50_00_355002.mapbnd.dcx  
	+/map/m60/m60_39_54_00/m60_39_54_00_395404.mapbnd.dcx  
	+/map/m60/m60_51_57_00/m60_51_57_00_515704.mapbnd.dcx  
	+/map/m60/m60_52_41_00/m60_52_41_00_524102.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910015.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910016.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910017.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910018.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910019.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910020.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910022.mapbnd.dcx  
	+/map/m10/m10_00_00_00/m10_00_00_00_910023.mapbnd.dcx  
	+/map/m60/m60_12_14_02/m60_12_14_02_31515704.mapbnd.dcx  
	+/map/m60/m60_25_28_01/m60_25_28_01_31515704.mapbnd.dcx  

### 2.1.2
* Finally named the FileFormView window.  
* Fixed a bug where the files were invisible until you tried to search.  


### 2.1.1
* Bugfix for Sekiro unpacking. It should now work properly  
* Minor bugfix that would propt the user with an exception if they didn't have Elden Ring installed.  
* Added old file for backwards compatibility:  
	+/enus/wem/84/846437564.wem  

### 2.1
* Added better support for file extensions in `_unknown`. Underlying extension for .DCX'd files and extensions inside bnds    
* Added two missing aeg files to the list and 4 missing .entryfilelist:  
	+/asset/aet/aet500/aet500_813.tpf.dcx  
	+/asset/aet/aet500/aet500_813_l.tpf.dcx  
	+/map/entryfilelist/e001105/i0011050063.entryfilelist  
	+/map/entryfilelist/e001201/e0012010971.entryfilelist  
	+/map/entryfilelist/e001202/e0012022202.entryfilelist  
	+/map/entryfilelist/e001202/e0012022209.entryfilelist  

### 2.0  
* Added support for Dark Souls: PTDE.  
* Added "support" for Dark Souls Remastered.  
* Added auto detect steam library where Elden Ring is located.  

### 1.71
* Search bar in file view.  
* Fixed bug with ER Sound files.  

### 1.70 - The "No More Funny Numbers" Update  
* Small code change to be more accurate to the original UXM code, while still getting the correct values.  
* added some files that changed paths and files that exist in previous versions. 
* properly unpacks unknown sd files.  

### 1.69.420
* Made it work with older games again :fatcat:  

### 1.69
* Elden ring support and improved the file picking window slightly.  

### 2.7.1
* File selection GUI uncheck parents when child node unchecked  

### 2.7
* Added GUI for selective file unpacking  

### 2.6
* Added support for launching UXM from the Windows Search menu.  
* Added updated Sekiro Dictionary that TKGP posted in ?ServerName?  

### 2.5
* Added "Skip unknown files" option. Allows user to delete files from the res/GameDictionary.txt to extract only specific files. I.E. Deleting all files except ones in the sound folder from ScholarDictionary.txt to only unpack the sounds for Dark Souls 2 SotFS.  

### 2.4
* Sekiro pre-order artbook/soundtrack thing support; just browse to DigitalArtwork_MiniSoundtrack.exe
* Identify more files for Sekiro (thank you horkrux!)

### 2.3
* Sekiro support

### 2.2
* Identified the final file in DS3 (thanks Meow)
* Identified files for Japanese DS2
* Show progress on the taskbar icon
* Make sure you really want to delete everything if you click Restore

### 2.1.3
* Support unpacking decrypted archives for BootBoost compatibility

### 2.1.2
* Fix the update link in the app not actually doing anything

### 2.1.1
* Fix DLC2 files still being loaded from archive (just click Patch again to fix it)

### 2.1
* Fix keybinding menu being broken because of a false positive
* Identify all but 1 file in DS3 (and support release version better)

### 2.0
* U3M has been mostly rewritten and is now UXM
* DS2 and SotFS are supported
* Performance improvements (20-30% faster unpacking)
* Patching and restoring now also display progress and are abortable
* Fixed some misidentified files in DS3 and identified 1 new one
