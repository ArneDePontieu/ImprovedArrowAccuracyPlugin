using System;
using System.ComponentModel;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace ArrowAccuracyPlugin
{
    [BepInPlugin(ModGuid, ModName, ModVer)]
    public class ArrowAccuracyPlugin : BaseUnityPlugin
    {
        public const string ModGuid = AuthorName + "." + ModName;
        private const string AuthorName = "Hedrymas";
        private const string ModName = "ArrowAccuracyPlugin";
        private const string ModVer = "0.0.1";

        internal static ArrowAccuracyPlugin Instance;

        private void Awake()
        {
            Instance = this;

            Initializer.Initialize();
            ArrowAccuracyConfig.Initialize(Config);
        }

        private void OnDestroy()
        {
            Initializer.Disable();
        }
    }
}