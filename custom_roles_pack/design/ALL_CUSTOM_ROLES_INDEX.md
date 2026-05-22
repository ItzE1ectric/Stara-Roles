# All Custom Roles Index

Generated on: 2026-05-22 (America/Chicago)

This folder now contains a consolidated custom-role dataset pulled from major Among Us role mods.

## Files
- `all_custom_roles_catalog.csv`
  - One row per role per source mod.
  - Includes role kind (`custom_role`, `sub_role`, `modifier`, `ghost_role`, `gamemode_role`, `vanilla_remake`).
- `all_custom_roles_merged.csv`
  - Deduped role names across sources.
  - Includes `sources`, `source_count`, `team_hints`, `icon_file`.
- `roles.csv`
  - Project-facing merged role list (derived from `all_custom_roles_merged.csv`).
- `all_custom_roles_stats.txt`
  - Snapshot counts by source and role kind.

## Current Snapshot
- Catalog rows: `634`
- Unique merged roles (excluding modifiers): `452`
- Source contribution:
  - `BoundlessHostRoles`: 408
  - `TOU-R`: 86
  - `TOU-Mira`: 81
  - `TheOtherRoles`: 59

## Source Revisions Used
- TOU-R: `943c462`
- TOU-Mira: `d4e775e`
- TheOtherRoles: `b782da4`
- BoundlessHostRoles: `1d69328`

## Notes
- Team hints are best-effort from source structure/enums and may need manual correction for edge cases.
- This list intentionally includes sub-roles and gamemode roles in the catalog; use `kinds` to filter.
