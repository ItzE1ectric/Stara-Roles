using System.Collections.Generic;
using HarmonyLib;
using MiraAPI.Hud;
using MiraAPI.Keybinds;
using MiraAPI.Networking;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace Stara.Roles.Roles;

public static class CheaterAbilityRuntime
{
    private static readonly Color CheaterColor = new Color32(230, 66, 66, 255);

    private static bool _pendingReturn;
    private static Vector2 _returnPosition;
    private static float _returnAt;

    public static bool HasPendingReturn => _pendingReturn;

    public static bool TryExecuteTeleportKill()
    {
        var localPlayer = PlayerControl.LocalPlayer;
        if (!IsLocalCheaterAlive(localPlayer))
        {
            return false;
        }
        if (localPlayer == null)
        {
            return false;
        }

        if (MeetingHud.Instance != null)
        {
            Helpers.CreateAndShowNotification("Cheater: cannot use ability during a meeting.", CheaterColor);
            return false;
        }

        var candidates = BuildAliveTargets(localPlayer);
        if (candidates.Count == 0)
        {
            Helpers.CreateAndShowNotification("Cheater: no valid target found.", CheaterColor);
            return false;
        }

        var target = candidates[Random.Range(0, candidates.Count)];
        if (!target || target.Data == null || target.Data.IsDead)
        {
            return false;
        }

        _returnPosition = localPlayer.GetTruePosition();
        _returnAt = Time.time + 5f;
        _pendingReturn = true;

        Teleport(localPlayer, target.GetTruePosition());

        // Hidden-body kill: no dead body is spawned, so it cannot be reported.
        CustomMurderRpc.RpcCustomMurder(
            localPlayer,
            target,
            didSucceed: true,
            resetKillTimer: true,
            createDeadBody: false,
            teleportMurderer: false,
            showKillAnim: false,
            playKillSound: false);

        Helpers.CreateAndShowNotification(
            $"Cheater: eliminated {target.Data.PlayerName}. Returning in 5s.",
            CheaterColor);

        return true;
    }

    public static void OnLocalFixedUpdate()
    {
        if (!_pendingReturn || Time.time < _returnAt)
        {
            return;
        }

        _pendingReturn = false;

        var localPlayer = PlayerControl.LocalPlayer;
        if (!localPlayer || localPlayer.Data == null || localPlayer.Data.IsDead)
        {
            return;
        }

        Teleport(localPlayer, _returnPosition);
        Helpers.CreateAndShowNotification("Cheater: returned to original position.", CheaterColor);
    }

    private static bool IsLocalCheaterAlive(PlayerControl? player)
    {
        if (player == null || !player)
        {
            return false;
        }

        var data = player.Data;
        return data != null &&
               !data.IsDead &&
               data.Role is CheaterRole;
    }

    private static List<PlayerControl> BuildAliveTargets(PlayerControl localPlayer)
    {
        var result = new List<PlayerControl>();
        var all = GameData.Instance?.AllPlayers;
        if (all == null)
        {
            return result;
        }

        foreach (var info in all)
        {
            var candidate = info?.Object;
            if (candidate == null || !candidate || candidate.PlayerId == localPlayer.PlayerId || candidate.Data == null || candidate.Data.IsDead)
            {
                continue;
            }

            result.Add(candidate);
        }

        return result;
    }

    private static void Teleport(PlayerControl player, Vector2 position)
    {
        if (!player)
        {
            return;
        }

        if (player.NetTransform != null)
        {
            player.NetTransform.RpcSnapTo(position);
            player.NetTransform.SnapTo(position);
        }

        player.transform.position = position;
    }
}

public sealed class CheaterTeleportKillButton : CustomActionButton
{
    private static readonly LoadableAsset<Sprite> ButtonAsset = new LoadableResourceAsset("Stara.Roles.Resources.AbilityButton.png");

    public override string Name => "Warp Kill";

    public override float Cooldown => 30f;

    public override float EffectDuration => 0f;

    public override LoadableAsset<Sprite> Sprite => ButtonAsset;

    public override MiraKeybind? Keybind => MiraGlobalKeybinds.PrimaryAbility;

    public override Color TextOutlineColor => new Color32(230, 66, 66, 255);

    public override bool Enabled(RoleBehaviour? role)
    {
        return role is CheaterRole;
    }

    protected override void OnClick()
    {
        if (!CheaterAbilityRuntime.TryExecuteTeleportKill())
        {
            SetTimer(0f);
        }
    }

    protected override void FixedUpdate(PlayerControl playerControl)
    {
        if (Button == null)
        {
            return;
        }

        Button.OverrideText(CheaterAbilityRuntime.HasPendingReturn ? "RETURNING" : "WARP KILL");
    }
}

[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.FixedUpdate))]
public static class CheaterAbilityFixedUpdatePatch
{
    public static void Postfix(PlayerControl __instance)
    {
        if (!__instance || !PlayerControl.LocalPlayer || __instance.PlayerId != PlayerControl.LocalPlayer.PlayerId)
        {
            return;
        }

        CheaterAbilityRuntime.OnLocalFixedUpdate();
    }
}
