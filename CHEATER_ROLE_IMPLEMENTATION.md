# Cheater Role (BepInEx + MiraAPI)

The `Cheater` role is implemented as a real custom `Impostor` role in:

- `Stara.Roles/Roles/CheaterRoleMinimal.cs`

Runtime logic is implemented in:

- `Stara.Roles/Roles/CheaterAbility.cs`

## How it works

- Ability button (`Warp Kill`) is available only when the local role is `Cheater`.
- On use, Cheater teleports to a random alive target.
- Target is killed using `CustomMurderRpc` with hidden-body settings.
- No dead body is created, so the kill is not reportable.
- After 5 seconds, Cheater returns to the original position.

## Output DLL

Compiled plugin:

- `Stara.Roles/bin/Release/net6.0/Stara.Roles.dll`
