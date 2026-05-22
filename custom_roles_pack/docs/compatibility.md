# Compatibility Matrix

## Game compatibility policy
- Track vanilla role changes from official Innersloth patch notes before each custom update.
- Validate role interactions whenever a new vanilla role is added.

## Install model notes
- Client-side packs (TOU/TOR style): all players usually need the same mod build.
- Host-only packs (EHR/BHR style): host runs modded server logic, clients can stay mostly vanilla.

## Test matrix (minimum)
- Windows host + Windows client
- Host-only configuration with mixed clients
- Lobby sizes: 8, 10, 12, 15
- Maps: Skeld, Polus, Airship, Fungle

## Breakage watchlist
- Meeting HUD layout updates
- Role reveal serialization changes
- Task pipeline changes affecting fake task behavior
- Map room identifier changes (pathing and trace roles)
