# Stara Roles

Custom Among Us role planning and content pipeline.

## Current contents
- `AMONG_US_CUSTOM_ROLES_ICON_PLAN.md` - research-backed planning document.
- `custom_roles_pack/design/roles.csv` - merged all-custom-roles list for implementation.
- `custom_roles_pack/design/all_custom_roles_catalog.csv` - source-by-source full catalog.
- `custom_roles_pack/design/all_custom_roles_merged.csv` - deduped merged list across mods.
- `custom_roles_pack/design/ALL_CUSTOM_ROLES_INDEX.md` - quick index and source revision snapshot.
- `custom_roles_pack/config/*.json` - spawn, cooldown, and lobby preset templates.
- `custom_roles_pack/docs/*` - compatibility and legal/disclaimer docs.

## Next build steps
1. Draw role icons into `custom_roles_pack/assets/icons` (`288x288` PNG).
2. Draw role headers into `custom_roles_pack/assets/role_headers` (`500x200` PNG).
3. Wire CSV + JSON fields to your runtime config loader.
4. Run private playtests and tune with `design/balance_notes.md`.
