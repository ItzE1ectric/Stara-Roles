# Among Us Custom Roles + Icons Plan
Last updated: 2026-05-22 (America/Chicago)

## 1. Goal
Build a clean, balanced custom role pack and a matching icon set that is easy to maintain across updates.

## 2. Research Snapshot (Current)
### Official vanilla role baseline
- Innersloth added these roles in 2021: `Scientist`, `Engineer`, `Guardian Angel`, `Shapeshifter`.
- Innersloth added these roles in 2024: `Tracker`, `Noisemaker`, `Phantom`.
- Innersloth added these roles in 2025: `Detective`, `Viper`.
- Innersloth states the game had `9 roles` in the September 9, 2025 role update.
- Latest official patch note checked during this research: `v17.3.1` on April 8, 2026 (mobile update post).

### Mod ecosystem comparison
| Mod | Install model | Recent version signal | Notes |
|---|---|---|---|
| TOU-Mira | Client-side mod (not host-only) | `v1.6.2` (May 10) | Active and has structured icon folders |
| Town Of Us R | Client-side mod | `v5.3.1` (Apr 27) | Large role set, clear role categories |
| The Other Roles | Client-side mod | `v4.8.0` (Feb 23) | Stable role set + custom hats support |
| BoundlessHostRoles (EHR fork) | Host-only | README states `350+ roles` + `7 modes` | Fast to host, huge role catalog |

### Policy and compliance requirements (must follow)
- Mod stamp must be shown during gameplay.
- Required legal disclaimer must be present on mod page/repo.
- No hacks/cheats, no malicious payloads, no fake "official" branding.
- Modded lobbies are not discoverable via public lobby search, so direct invites/community flow is needed.

## 3. Icon Research Findings
### Proven folder structure (TOU-Mira pattern)
- `Images/Icons`
- `Images/RoleHeaders`
- `Images/ModifierHeaders`
- `Images/Groups`

### Naming convention pattern
- PascalCase role/modifier names with `.png`
- Examples: `Detective.png`, `GuardianAngel.png`, `RandomAny.png`, `CrewInvest.png`

### Measured image dimensions from real mod assets
- `Images/Icons/Detective.png` -> `288x288`
- `Images/RoleHeaders/Detective.png` -> `500x200`
- `Images/ModifierHeaders/Bait.png` -> `500x150`
- `Images/Groups/CrewInvest.png` -> `1500x110`
- TOU-R role sheet (`Roles.png`) -> `3000x12000`
- TOR role sheet (`TOR_Roles.png`) -> `3601x7748`

## 4. Recommended Project Structure
```text
custom_roles_pack/
  design/
    roles.csv
    balance_notes.md
  assets/
    icons/                # 288x288 PNG
    role_headers/         # 500x200 PNG
    modifier_headers/     # 500x150 PNG
    groups/               # 1500x110 PNG
    atlases/
  config/
    spawn_weights.json
    cooldowns.json
    lobby_presets.json
  docs/
    changelog.md
    compatibility.md
    legal_disclaimer.md
```

## 5. Planned Role Pack (Season 1 Draft)
Start with 8-10 roles, not 30+, to keep balance/test cycles tight.

| Role | Team | Core ability | Counterplay | Icon concept |
|---|---|---|---|---|
| Archivist | Crewmate | Stores last known room traces from reports | Fake pathing and rapid rotates | Notebook + map pin |
| Warden | Crewmate | Temporary shield in a small radius | Bait shield early, then split | Shield + door |
| Signaler | Crewmate | One delayed ping to all crew when threatened | Force early ping | Beacon + pulse ring |
| Saboteur+ | Impostor | Alters one task output once per round | Cross-check task progress | Wrench + glitch |
| Mimic | Impostor | Copies one seen role ability with delay | Hide ability usage patterns | Mirror mask |
| Dissolver | Impostor | Body fades in stages after kill | Fast report discipline | Acid drop + bone |
| Broker | Neutral | Wins by trading intel objectives | Deny meetings or force chaos | Coin + eye |
| Fugitive | Neutral | Escapes via timed objective path | Map control and door locks | Running boot + timer |
| Oracle | Crewmate | One high-risk prediction per meeting | Bluff pressure | Crystal + checkmark |
| Parasite | Impostor | Temporary movement influence on target | Buddy movement checks | Tendril + puppet cross |

## 6. Balance Targets
- Crewmate win rate target: `45% - 55%` across 20-50 game samples.
- Any single role should not exceed `~60%` personal win contribution.
- Avoid stacking hard-confirm information roles in the same lobby.
- Keep "hard denial" abilities (silence, lockout, role-block) capped at low counts.

## 7. Implementation Milestones
### Phase 1: Data model and role specs
- Finalize role table with: team, cooldown, duration, charges, win condition, UI strings.
- Define group tags: `CrewInvest`, `CrewSupport`, `CrewProtect`, `ImpConcealing`, `ImpKilling`, `Neutral`.

### Phase 2: Icon production pipeline
- Create templates for 288/500x200/500x150/1500x110.
- Produce first-pass monochrome silhouettes for all roles.
- Run readability test at in-game scale before full color polish.

### Phase 3: Gameplay integration
- Add spawn weighting and lobby toggles.
- Add compatibility checks per game version and map.
- Add guardrails for conflicting role combinations.

### Phase 4: Playtest and tuning
- Run private lobbies with fixed preset A/B.
- Track: win rates, task completion %, meeting count, round length, confusion reports.
- Tune cooldowns and info density before adding new roles.

## 8. Risk Register
- Upstream Among Us updates can break hooks and UI assets.
- Overloaded info roles can make impostor play unfun.
- Too many modifiers at once can make outcomes feel random.
- Icon over-detail reduces readability in meetings and HUD.

## 9. Compliance Checklist
- [ ] Display mod stamp in all gameplay states.
- [ ] Include required Innersloth disclaimer text.
- [ ] Ensure no cheat/hack behavior in features.
- [ ] Keep gameplay access fair (avoid hard paywalling gameplay features).
- [ ] Document install requirements clearly (host-only vs all-player).

## 10. Source Links
- Innersloth Mod Policy: https://www.innersloth.com/among-us-mod-policy/
- Innersloth mod FAQ: https://innersloth.zendesk.com/hc/en-us/articles/6711746215700-Are-there-mods-for-Among-Us
- Innersloth roles update (2021): https://www.innersloth.com/new-roles-cosmicubes-out-now-emergency-meeting-33/amp/
- Innersloth roles update (2024): https://www.innersloth.com/new-roles-enter-the-fray-v2024-6-18-emergency-meeting-38/amp/
- Innersloth roles update (2025): https://www.innersloth.com/new-roles-are-on-the-scene-of-17-0-0-emergency-meeting-41/
- Latest patch checked (2026-04-08): https://www.innersloth.com/mobile-update-v17-3-1/
- TOU-Mira repo: https://github.com/AU-Avengers/TOU-Mira
- TOU-Mira releases: https://github.com/AU-Avengers/TOU-Mira/releases
- TOU-R repo: https://github.com/eDonnes124/Town-Of-Us-R
- TOU-R releases: https://github.com/eDonnes124/Town-Of-Us-R/releases
- TheOtherRoles repo: https://github.com/TheOtherRolesAU/TheOtherRoles
- TheOtherRoles releases: https://github.com/TheOtherRolesAU/TheOtherRoles/releases
- BoundlessHostRoles repo: https://github.com/Ultradragon005/BoundlessHostRoles
