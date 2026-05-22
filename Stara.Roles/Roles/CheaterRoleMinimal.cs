using MiraAPI.Roles;
using UnityEngine;

namespace Stara.Roles.Roles;

public sealed class CheaterRole : ImpostorRole, ICustomRole
{
    private CustomRoleConfiguration? _configuration;

    public string RoleName => "Cheater";

    public string RoleDescription => "A high-pressure impostor role focused on aggressive kills.";

    public string RoleLongDescription =>
        "Ability: Warp Kill. Teleport to a random alive player, kill them with no body left to report, then snap back to your original position after 5 seconds.";

    public Color RoleColor => new Color32(230, 66, 66, 255);

    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

    public RoleOptionsGroup RoleOptionsGroup => new("Stara Roles - Impostor", new Color32(209, 59, 59, 255), -1);

    public CustomRoleConfiguration Configuration => _configuration ??= BuildConfiguration();

    public bool CanSpawnOnCurrentMode()
    {
        return !GameManager.Instance.IsHideAndSeek();
    }

    private CustomRoleConfiguration BuildConfiguration()
    {
        return new CustomRoleConfiguration(this)
        {
            MaxRoleCount = 1,
            DefaultRoleCount = 1,
            DefaultChance = 100,
            CanUseSabotage = true,
            UseVanillaKillButton = true,
            CanGetKilled = true,
        };
    }
}
