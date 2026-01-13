# UNBEATABLE No Turning Back Mod

This mod makes UNBEATABLE behave more like Muse Dash. All Enemies and obstacles come exclusivly from the right side.  

## Disclaimer
PLEASE ONLY USE THIS MOD IN STORY MODE, AS IT GIVES AN UNFAIR ADVANTAGE IN ARCADE MODE!

## Installation Instructions

### Via UBMT (Recommended)
You can download the UNBEATABLE Modding Tool at [https://github.com/streepje8/UBMT](https://github.com/streepje8/UBMT)

1. Install UNBEATABLE Modding Tool
2. Mod your game (if it is not modded already)
3. Select the No Turning Back Mod
4. Click Install.
5. Restart your game if it was already running

Uninstallation
1. Open UBMT
2. Navigate to Manage mods
3. Find the No Turning Back Mod
4. Select it and click Uninstall.
5. Restart your game if it was already running

### Install Manualy

1. Install BepInEx ([https://docs.bepinex.dev/articles/user_guide/installation/index.html](https://docs.bepinex.dev/articles/user_guide/installation/index.html))
2. Build the mod, or download the latest version from the releases section on github.
3. Put the .dll file in the BepInEx plugins folder.

## Build Instructions
1. Clone this repository from github
2. Open the .sln file with your IDE (ex: Rider or Visual Studio)
3. Edit the .csproj file and set the <UnbeatableLocation> tag to your UNBEATABLE game installation (which should contain a UNBEATABLE_Data folder)
4. Switch your project to release mode
5. Build (In rider, press the green hammer on the top
6. In the bin folder, you will now find UnbeatableNoTurningBack.dll