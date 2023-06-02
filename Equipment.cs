using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Equipment : Item
    {
        public Equipment(string name, int value, int weight, Image display) : base(name, value, weight, display)
        {

        }
        public override int Use(Entity player)
        {
            return 1;
        }
        public virtual int UseEquipment(Entity user, Entity target)
        {
            return 0;
        }
    }
    public class BasicWeapon : Equipment
    {
        protected int damage;

        public BasicWeapon(string name, int value, int weight, int damage, Image display) : base(name, value, weight, display)
        {
        }
        public override int UseEquipment(Entity user, Entity target)
        {
            target.health -= damage;
            if (target.health < 0)
                target.health = 0;

            return 0;
        }
        
        // procedural generation
        private static string[] possibleFNames =
        {
            "hardy",
            "spined",
            "grimy",
            "hardened",
            "wizened"
        };
        private static string[] possibleLBlob1s =
        {
            "worm",
            "orc",
            "spasm",
            "trachea",
            "throat",
        };
        private static string[] possibleLBlob2s =
        {
            "slayer",
            "slicer",
            "cutter",
            "crusher",
            "whipper"
        };
        public static BasicWeapon GenerateWeapon()
        {
            string fName = possibleFNames[Globals.rand.Next(possibleFNames.Length)];
            string lName1 = possibleLBlob1s[Globals.rand.Next(possibleLBlob1s.Length)];
            string lName2 = possibleLBlob2s[Globals.rand.Next(possibleLBlob2s.Length)];

            string name = fName + ' ' + lName1 + lName2;

            int w_min = GameSettings.BASE_WEAPON_WEIGHT_RANGE[0];
            int w_max = GameSettings.BASE_WEAPON_WEIGHT_RANGE[1] + 1;
            int weight = Globals.rand.Next(w_min, w_max);

            int value = (int) (weight * (GameSettings.VALUE_MOD + ((Globals.rand.Next(2) == 0) ? -.25f : .25f)));

            int damage = (int)(GameSettings.DAMAGE_MOD * weight);

            Image display = Images.basic_weapon;
            int heavyThreshold = (int)(w_min + (GameSettings.HEAVY_WEAPON_THRESHOLD * (w_max - w_min)));
            if (weight > heavyThreshold)
            {
                damage += 2;
                display = Images.basic_weapon_heavy;
            }
             
            return new BasicWeapon(name, value, weight, damage, display);
        }
    }
    public class VampiricWeapon : BasicWeapon
    {
        public VampiricWeapon(string name, int value, int weight, int damage, Image display) : base(name, value, weight, damage, display)
        {

        }
        public override int UseEquipment(Entity user, Entity target)
        {
            float prevTHealth = target.health;
            base.UseEquipment(user, target);
            user.health += GameSettings.VAMPIRE_PERCENT * (target.health - prevTHealth);
            return 0;
        }

        // procedural generation
        private static string[] possibleFNames =
        {
            "crimson",
            "horned",
            "vampiric",
            "gothic",
            "haunting"
        };
        private static string[] possibleLBlob1s =
        {
            "blood",
            "vein",
            "bat",
            "shade",
            "shadow"
        };
        private static string[] possibleLBlob2s =
        {
            "blade",
            "sword",
            "cleaver",
            "stake"
        };
        public static new VampiricWeapon GenerateWeapon()
        {
            string name;
            if (Globals.rand.Next(101) == 53)
                name = "Sucky McSuckface";
            else
            {
                string fName = possibleFNames[Globals.rand.Next(possibleFNames.Length)];
                string lName1 = possibleLBlob1s[Globals.rand.Next(possibleLBlob1s.Length)];
                string lName2 = possibleLBlob2s[Globals.rand.Next(possibleLBlob2s.Length)];

                name = fName + ' ' + lName1 + lName2;
            }

            int w_min = GameSettings.BASE_WEAPON_WEIGHT_RANGE[0];
            int w_max = GameSettings.BASE_WEAPON_WEIGHT_RANGE[1] + 1;
            int weight = Globals.rand.Next(w_min, w_max);

            int value = (int)(weight * (GameSettings.VALUE_MOD + ((Globals.rand.Next(2) == 0) ? -.25f : .25f)));

            int damage = (int)(GameSettings.DAMAGE_MOD * weight);

            Image display = Images.vampire_weapon;
            int heavyThreshold = (int)(w_min + (GameSettings.HEAVY_WEAPON_THRESHOLD * (w_max - w_min)));
            if (weight > heavyThreshold)
            {
                damage += 2;
                display = Images.vampire_weapon_heavy;
            }

            return new VampiricWeapon(name, value, weight, damage, display);
        }
    }
}
