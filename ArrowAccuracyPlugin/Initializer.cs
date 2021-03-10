using HarmonyLib;

namespace ArrowAccuracyPlugin
{
    internal static class Initializer
    {
        internal static Harmony HarmonyInstance;

        internal static void Initialize()
        {
            EnableHarmonyPatches();
        }

        internal static void Disable()
        {
            DisableHarmonyPatches();
        }

        #region Harmony

        private static void EnableHarmonyPatches()
        {
            HarmonyInstance = new Harmony(ArrowAccuracyPlugin.ModGuid);
            HarmonyInstance.PatchAll();
        }

        private static void DisableHarmonyPatches()
        {
            HarmonyInstance.UnpatchSelf();
        }

        #endregion
    }
}