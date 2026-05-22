# Dump Hook Map (GameAssembly il2cppdump 2026-05-10)

Source dump:
- `C:\Users\xklyo\Downloads\Stara Among Us Client\Game Info Dumps\GameAssembly_il2cppdump_20260510_1830\dump.cs`

## Core methods confirmed in dump
- `PlayerControl.FixedUpdate` at line `55585`
- `PlayerControl.ReportDeadBody` at line `55728`
- `PlayerControl.StartMeeting(NetworkedPlayerInfo)` at line `55737`
- `PlayerControl.CheckMurder` at line `55743`
- `PlayerControl.MurderPlayer` at line `55755`
- `PlayerControl.SetRoleInvisibility` at line `55791`
- `PlayerControl.CmdReportDeadBody` at line `55950`
- `PlayerControl.CmdCheckMurder` at line `55956`
- `PlayerControl.RpcMurderPlayer` at line `55962`
- `RoleManager.SetRole` at line `62390`
- `ShipStatus.StartMeeting(PlayerControl, NetworkedPlayerInfo)` at line `67459`
- `ShipStatus.RpcUpdateSystem(SystemTypes, byte)` at line `67478`
- `MeetingHud.CastVote` at line `37694`
- `MeetingHud.CheckForEndVoting` at line `37700`
- `MeetingHud.CmdCastVote` at line `37739`

## SystemTypes confirmed
- `SystemTypes` enum starts at line `67676`
- Includes sabotage-relevant systems useful for future custom role logic:
- `Sabotage`
- `Reactor`
- `LifeSupp`
- `Comms`
- `Electrical`
- `MushroomMixupSabotage`
- `HeliSabotage`

## Hook usage in current Cheater build
- `PlayerControl.FixedUpdate`: used to process Cheater return timer after teleport-kill.
- `PlayerControl.MurderPlayer` path is replaced at runtime through Mira `CustomMurderRpc` for hidden-body behavior.
- `PlayerControl.ReportDeadBody`: referenced behavior target because Cheater kills create no reportable body (`createDeadBody: false`).
