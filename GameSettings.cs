using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Globals
    {
        public static Random rand;
        public static Player player;
    }
    public class GameSettings
    {
        public static float PLAYER_BASE_HEALTH = 50f;
        public static float PLAYER_BASE_ACCURACY = .8f;
        public static float PLAYER_BASE_STRENGTH = 1;

        public static float PAINTING_DAMAGE = 10f;
        public static int PAINTING_VALUE = 600;

        public static int MAX_MONSTER_LOOT = 5;

        public static float HEALTH_POTION_REGAIN_BASE = 5;
        public static float HEALTH_POTION_REGAIN_INCREASE = 3;
        public static int HEALTH_POTION_WEIGHT_BASE = 3;
        public static int HEALTH_POTION_WEIGHT_INCREASE = 2;
        public static int[] BASE_WEAPON_WEIGHT_RANGE = { 5, 15 };
        public static float HEAVY_WEAPON_THRESHOLD = .6f;
        public static float VALUE_MOD = 1.75f;
        public static float DAMAGE_MOD = 1.5f;
        public static float VAMPIRE_PERCENT = .8f;
    }
}
