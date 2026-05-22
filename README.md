# Stara Roles

Custom Among Us role planning and content pipeline.

## Current contents
- `AMONG_US_CUSTOM_ROLES_ICON_PLAN.md` - research-backed planning document.
- `custom_roles_pack/design/roles.csv` - Stara original custom roles dataset (no imported role list).
- `custom_roles_pack/design/STARA_ORIGINAL_ROLES.md` - originality scope and design rules.
- `custom_roles_pack/config/*.json` - spawn, cooldown, and lobby preset templates.
- `custom_roles_pack/docs/*` - compatibility and legal/disclaimer docs.

## Next build steps
1. Draw role icons into `custom_roles_pack/assets/icons` (`288x288` PNG).
2. Draw role headers into `custom_roles_pack/assets/role_headers` (`500x200` PNG).
3. Wire CSV + JSON fields to your runtime config loader.
4. Run private playtests and tune with `design/balance_notes.md`.
