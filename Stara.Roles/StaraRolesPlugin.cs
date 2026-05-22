using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using Reactor.Utilities;

namespace Stara.Roles;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public class StaraRolesPlugin : BasePlugin, IMiraPlugin
{
    public const string PluginGuid = "itz.e1ectric.stara.roles";
    public const string PluginName = "Stara Roles";
    public const string PluginVersion = "1.0.0";

    public Harmony Harmony { get; } = new(PluginGuid);

    public string OptionsTitleText => "Stara Roles";

    public ConfigFile GetConfigFile() => Config;

    public override void Load()
    {
        Harmony.PatchAll();
        Logger<StaraRolesPlugin>.Info("Loaded Stara Roles plugin (Cheater safe build).");
    }
}
