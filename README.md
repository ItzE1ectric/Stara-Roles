# Stara Roles

Custom Among Us role planning and content pipeline.

## DLL Mod (Now Included)
- `Stara.Roles/Stara.Roles.csproj` - real BepInEx + MiraAPI role plugin project.
- `Stara.Roles/Roles/CheaterRoleMinimal.cs` - Cheater custom role definition.
- `Stara.Roles/Roles/CheaterAbility.cs` - Cheater teleport/kill/hide/return ability logic.
- `Stara.Roles/Resources/AbilityButton.png` - in-game ability button icon.
- `Stara.Roles/BUILD_AND_INSTALL.md` - install/build instructions.
- `DLL_RESEARCH_AND_PLAN.md` - research notes + implementation plan.
- `DUMP_HOOK_MAP.md` - method-level hook map from your `dump.cs`.

## Current contents
- `AMONG_US_CUSTOM_ROLES_ICON_PLAN.md` - research-backed planning document.
- `custom_roles_pack/design/roles.csv` - Stara original custom roles dataset (no imported role list).
- `custom_roles_pack/design/STARA_ORIGINAL_ROLES.md` - originality scope and design rules.
- `custom_roles_pack/design/ROLE_IMPLEMENTATION_GUIDE.md` - engine event contract and trigger rules.
- `custom_roles_pack/config/role_definitions.json` - runtime-ready role definitions (trigger, targeting, effects, balance, conflicts).
- `custom_roles_pack/config/*.json` - spawn, cooldown, and lobby preset templates.
- `custom_roles_pack/docs/*` - compatibility and legal/disclaimer docs.

## Current runtime scope
1. Only one custom role is compiled and loaded: `Cheater`.
2. Cheater ability: teleport to a random alive player, hidden-body kill, then return after 5 seconds.
3. Plugin target: BepInEx IL2CPP + Reactor + MiraAPI.
