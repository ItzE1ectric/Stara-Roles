# Stara Roles DLL Research And Plan

## Objective
Maintain a real, buildable Among Us mod DLL project focused on a single custom role: `Cheater`.

## Verified technical stack (current)
- `TargetFramework`: `net6.0`
- `AllOfUs.MiraAPI`: `0.4.0`
- `Reactor`: `2.5.0-ci.371`
- `BepInEx.Unity.IL2CPP`: `6.0.0-be.735`
- `AmongUs.GameLibs.Steam`: `2026.3.31`
- `BepInEx.IL2CPP.MSBuild`: `2.1.0-rc.1`

## Primary references used
- TOU-Mira project structure and props (local source audit)
- MiraAPI source and example plugin/roles (local source audit)
- BepInEx + Reactor + MiraAPI package docs/metadata
- Local game dump:
- `C:\Users\xklyo\Downloads\Stara Among Us Client\Game Info Dumps\GameAssembly_il2cppdump_20260510_1830\dump.cs`

## Implemented
1. Created `Stara.Roles` DLL project with correct dependencies and build target.
2. Reduced runtime scope to one compiled custom role class (`CheaterRole`).
3. Added custom ability button (`Warp Kill`) for Cheater.
4. Implemented ability flow:
- teleport to random alive player
- hidden-body kill via `CustomMurderRpc` (`createDeadBody: false`)
- return to original position after 5 seconds
5. Added dump-derived runtime hook map (`DUMP_HOOK_MAP.md`) with key method anchors.
6. Verified successful `Release` build output of `Stara.Roles.dll`.

## Architecture choices
- Keep the mod intentionally small and stable to avoid IL2CPP registration crashes.
- Compile only explicit source files in `Stara.Roles.csproj` (`EnableDefaultCompileItems=false`).
- Keep role behavior in minimal files for easier troubleshooting and fast iteration.

## Next implementation passes
1. Add explicit host/server authority checks around teleport-kill timing.
2. Add configurable cooldown/return delay in role options.
3. Add visual/audio feedback tuning for ability use.
4. Expand safely from Cheater to new roles one-by-one only after runtime verification.
