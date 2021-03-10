using HarmonyLib;
using HarmonyLib.Tools;
using UnityEngine;
using ValheimLib;

namespace ArrowAccuracyPlugin.GameClasses
{
    [HarmonyPatch(typeof(Attack), "FireProjectileBurst")]
    public static class ModifyProjectiles
    {
        private static void Prefix(ref Attack __instance)
        {
            __instance.m_projectileVel += ArrowAccuracyConfig.ArrowVelocityMultiplier.Value;
            __instance.m_projectileVelMin += ArrowAccuracyConfig.ArrowVelocityMultiplier.Value;

            if (!ArrowAccuracyConfig.CustomAccuracyEnabled.Value)
            {
                return;
            }

            __instance.m_projectileAccuracy = ArrowAccuracyConfig.ArrowMaxAccuracy.Value;
            __instance.m_projectileAccuracyMin = ArrowAccuracyConfig.ArrowMinAccuracy.Value;
        }
    }
}