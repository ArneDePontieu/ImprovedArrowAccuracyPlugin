using BepInEx;
using BepInEx.Configuration;

namespace ArrowAccuracyPlugin
{
    public static class ArrowAccuracyConfig
    {
        public static ConfigEntry<float> PlayerArrowAccuracyMultiplier;
        public static ConfigEntry<float> PlayerArrowVelocityMultiplier;        
        public static ConfigEntry<float> EnemyArrowAccuracyMultiplier;
        public static ConfigEntry<float> EnemyArrowVelocityMultiplier;

        public static void Initialize(ConfigFile configFile)
        {
            PlayerArrowAccuracyMultiplier = configFile.Bind("General.Accuracy", "PlayerArrowAccuracyMultiplier", 0f,
                "Player Projectile Accuracy Multiplier. Higher number = less accuracy.");
            
            PlayerArrowVelocityMultiplier = configFile.Bind("General.Velocity", "PlayerArrowVelocityMultiplier", 1f,
                "Player Arrow velocity multiplier");
            
            EnemyArrowAccuracyMultiplier = configFile.Bind("General.Accuracy", "EnemyArrowAccuracyMultiplier", 1f,
                "Enemy Player Projectile Accuracy Multiplier. Higher number = less accuracy.");
            
            EnemyArrowVelocityMultiplier = configFile.Bind("General.Velocity", "EnemyArrowVelocityMultiplier", 1f,
                "Enemy Arrow velocity multiplier");
        }
    }
}