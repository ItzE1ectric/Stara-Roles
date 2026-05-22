# Balance Notes

## Version target
- Preset version: `0.1.0`
- Sample target before public use: `>= 30` rounds per preset.

## Core KPIs
- Crewmate team win rate target: `45% - 55%`
- Impostor team win rate target: `45% - 55%`
- Neutral role completion rate target: `< 25%` each role
- Average round length target: `6 - 12` minutes
- Meeting count target per game: `3 - 6`

## Tuning loop
1. Collect outcomes by preset (A/B) with role composition recorded.
2. Flag roles with overperformance (`>60%` impact) or underperformance (`<35%`).
3. Adjust only one lever at a time (cooldown, charges, duration, spawn weight).
4. Re-test with at least 10 rounds before another adjustment.

## Known conflict pairs to avoid
- High information stack: `Archivist + Oracle + Tracker` (if vanilla Tracker enabled)
- Hard concealment stack: `Mimic + Parasite + Phantom` (if vanilla Phantom enabled)
- Chaos overload: `Broker + Fugitive + Noisemaker` (if vanilla Noisemaker enabled)

## Notes
- Keep confirmable roles at low spawn rates in small lobbies.
- Prioritize clarity over complexity for first public playtest.
