using HarmonyLib;
using HarmonyLib.Tools;
using UnityEngine;
using ValheimLib;

namespace ArrowAccuracyPlugin.GameClasses
{
    [HarmonyPatch(typeof(Attack), "Start")]
    public static class ModifyProjectiles
    {
        private static void Postfix(ref Attack __instance, ref Humanoid character)
        {
            if (!character.IsPlayer())
            {
                return;
            }
            
            __instance.m_projectileVel *= ArrowAccuracyConfig.ArrowVelocityMultiplier.Value;
            __instance.m_projectileVelMin *= ArrowAccuracyConfig.ArrowVelocityMultiplier.Value;
            __instance.m_projectileAccuracyMin *= ArrowAccuracyConfig.ArrowAccuracyMultiplier.Value;
            __instance.m_projectileAccuracy *= ArrowAccuracyConfig.ArrowAccuracyMultiplier.Value;
        }
    }
}