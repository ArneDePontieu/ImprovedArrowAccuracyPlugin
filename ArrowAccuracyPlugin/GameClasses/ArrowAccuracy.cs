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
                __instance.m_projectileVel *= ArrowAccuracyConfig.EnemyArrowVelocityMultiplier.Value;
                __instance.m_projectileVelMin *= ArrowAccuracyConfig.EnemyArrowVelocityMultiplier.Value;
                __instance.m_projectileAccuracyMin *= ArrowAccuracyConfig.EnemyArrowAccuracyMultiplier.Value;
                __instance.m_projectileAccuracy *= ArrowAccuracyConfig.EnemyArrowAccuracyMultiplier.Value;
                return;
            }
            
            __instance.m_projectileVel *= ArrowAccuracyConfig.PlayerArrowVelocityMultiplier.Value;
            __instance.m_projectileVelMin *= ArrowAccuracyConfig.PlayerArrowVelocityMultiplier.Value;
            __instance.m_projectileAccuracyMin *= ArrowAccuracyConfig.PlayerArrowAccuracyMultiplier.Value;
            __instance.m_projectileAccuracy *= ArrowAccuracyConfig.PlayerArrowAccuracyMultiplier.Value;
        }
    }
}