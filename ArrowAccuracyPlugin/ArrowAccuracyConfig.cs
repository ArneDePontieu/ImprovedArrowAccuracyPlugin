using BepInEx;
using BepInEx.Configuration;

namespace ArrowAccuracyPlugin
{
    public static class ArrowAccuracyConfig
    {
        public static ConfigEntry<float> ArrowAccuracyMultiplier;
        public static ConfigEntry<float> ArrowVelocityMultiplier;

        public static void Initialize(ConfigFile configFile)
        {
            ArrowAccuracyMultiplier = configFile.Bind("General.Accuracy", "ArrowAccuracyMultiplier", 0f,
                "Projectile Accuracy Multiplier. 1 is default, 0 is 100% accurate.");
            
            ArrowVelocityMultiplier = configFile.Bind("General.Velocity", "ArrowVelocityMultiplier", 1f,
                "Arrow velocity multiplier, 1 is default, more is faster arrows.");
        }
    }
}