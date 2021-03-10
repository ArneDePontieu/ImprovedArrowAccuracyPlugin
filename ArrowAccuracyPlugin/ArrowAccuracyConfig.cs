using BepInEx;
using BepInEx.Configuration;

namespace ArrowAccuracyPlugin
{
    public static class ArrowAccuracyConfig
    {
        public static ConfigEntry<bool> CustomAccuracyEnabled;
        public static ConfigEntry<float> ArrowMinAccuracy;
        public static ConfigEntry<float> ArrowMaxAccuracy;
        public static ConfigEntry<float> ArrowVelocityMultiplier;

        public static void Initialize(ConfigFile configFile)
        {
            CustomAccuracyEnabled = configFile.Bind("General", "EnableCustomAccuracy", true, "Enable custom accuracy");
            
            ArrowMinAccuracy = configFile.Bind("General.Accuracy", "MinimumArrowAccuracy", 0f,
                "The accuracy value when shooting without drawing the bow (0 is perfect accuracy)");
            
            ArrowMaxAccuracy = configFile.Bind("General.Accuracy", "MaximumArrowAccuracy", 0f,
                "The accuracy value when shooting with a fully drawn bow (0 is perfect accuracy)");
            
            ArrowVelocityMultiplier = configFile.Bind("General.Velocity", "ArrowVelocityMultiplier", 1f,
                "Arrow velocity multiplier, 1 is default, more is faster arrows.");
        }
    }
}