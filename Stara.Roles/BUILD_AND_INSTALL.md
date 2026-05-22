# Stara Roles DLL Build + Install

## What this project is
- A real Among Us mod plugin DLL using BepInEx IL2CPP, Reactor, and MiraAPI.
- A single custom role (`Cheater`) compiled as a real `ICustomRole`.

## Verified runtime on your machine
- Game: `C:\Program Files (x86)\Steam\steamapps\common\Among Us`
- BepInEx: `6.0.0-be.755` (runtime)
- Reactor: `2.5.0`
- MiraAPI: `0.4.0`
- Stara plugin: `Stara.Roles.dll` in `BepInEx\plugins`

## Build
1. Open terminal in `C:\Users\xklyo\Downloads\Stara Roles\Stara.Roles`
2. Run:
```powershell
dotnet restore .\Stara.Roles.csproj
dotnet build .\Stara.Roles.csproj -c Release
```
3. Output DLL:
- `C:\Users\xklyo\Downloads\Stara Roles\Stara.Roles\bin\Release\net6.0\Stara.Roles.dll`

## Install Into Among Us
1. Make sure BepInEx IL2CPP is already installed in your Among Us folder.
2. Copy:
- `Stara.Roles.dll`
3. Paste into:
- `<Among Us>\BepInEx\plugins\`
4. Launch game and open role settings.

## Optional auto-copy
If you set MSBuild property `AmongUs`, the csproj auto-copies the DLL on build:
```powershell
dotnet build .\Stara.Roles.csproj -c Release -p:AmongUs=\"C:\Path\To\Among Us\"
```

## Current implementation level
- `Cheater` is registered and configurable in lobby role options.
- Cheater has a custom active button (`Warp Kill`) with cooldown.
- Ability behavior: teleport to a random alive target, kill target with no reportable dead body, and return to original position after 5 seconds.
