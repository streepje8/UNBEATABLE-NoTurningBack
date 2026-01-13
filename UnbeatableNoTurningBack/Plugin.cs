using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace Streep.Unbeatable.NoTurningBack
{
    [BepInPlugin(UnbeatableNoTurningBackInfo.PLUGIN_GUID, UnbeatableNoTurningBackInfo.PLUGIN_NAME, UnbeatableNoTurningBackInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;

        private void Awake()
        {
            Logger = BepInEx.Logging.Logger.CreateLogSource("NoTurningBack");
            Logger.LogInfo($"Plugin {UnbeatableNoTurningBackInfo.PLUGIN_GUID} is loaded!");
            var harmony = new Harmony(UnbeatableNoTurningBackInfo.PLUGIN_GUID);
            harmony.PatchAll(typeof(Patches));
            Logger.LogInfo($"Applied patches.");
        }

        private void OnApplicationQuit()
        {
            BepInEx.Logging.Logger.Sources.Remove(Logger);
        }
    }
}
