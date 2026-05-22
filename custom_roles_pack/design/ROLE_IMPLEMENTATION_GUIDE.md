# Stara Role Implementation Guide

These roles are now represented as runtime-ready data in `config/role_definitions.json`.

## Runtime Contract
- Load `role_definitions.json` at lobby init.
- Build role pools from `spawn_weights.json` with conflict filtering.
- Apply per-role cooldowns and charges from `cooldowns.json`.
- Apply preset caps and timers from `lobby_presets.json`.

## Required Engine Events
- `on_round_start`
- `on_tick`
- `on_player_move`
- `on_console_use`
- `on_sabotage_start`
- `on_sabotage_fix`
- `on_kill`
- `on_kill_attempt`
- `on_report`
- `on_meeting_start`
- `on_meeting_vote`
- `on_meeting_end`
- `on_player_death`

## Trigger Dispatch Rules
- `active_button`: local player can cast if cooldown and charges permit.
- `passive_*`: evaluate server-side only and replicate results.
- `on_report` and `on_meeting_*`: execute in deterministic host order by role ID.
- `toggle_stance`: applies a temporary stat profile and reverts on expiry.

## Conflict Handling
- Read `spawn_weights.json -> conflicts` and reject paired assignments.
- If conflict appears after conversion effects, keep earliest-assigned role and reroll the later one.

## Anti-Desync Rules
- Host-authoritative cooldown and charge consumption.
- Broadcast role effect payloads with timestamp + source role ID.
- Never let clients resolve role outcomes independently for kill/sabotage/meeting events.
