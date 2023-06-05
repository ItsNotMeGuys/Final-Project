using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Monster : Entity
    {
        public Monster(string name, float health, float strength) : base(name, health, strength, Images.monster)
        {

        }
        private static string[] possibleFNames =
        {
            "Grunga",
            "Lunker",
            "Probol",
            "Khazarr",
            "Strr'ak"
        };
        private static string[] possibleLName1s =
        {
            "Wealth",
            "Man",
            "Meat",
            "Fire"
        };
        private static string[] possibleLName2s =
        {
            "Stealer",
            "Eater",
            "Slayer"
        };
        public new List<string> getActions()
        {
            List<string> actions = base.getActions();
            actions.Add("Spit");
            return actions;
        }
        public string GetAction()
        {
            List<string> actions = getActions();
            return actions[Globals.rand.Next(actions.Count)];
        }
        public static Monster Generate()
        {
            string fName = possibleFNames[Globals.rand.Next(possibleFNames.Length)];
            string lName1 = possibleLName1s[Globals.rand.Next(possibleLName1s.Length)];
            string lName2 = possibleLName2s[Globals.rand.Next(possibleLName2s.Length)];

            string name = fName + ' ' + lName1 + '-' + lName2;
            float health = GameSettings.PLAYER_BASE_HEALTH - Globals.rand.Next(16);
            float accuracy = (float) Globals.rand.NextDouble();
            float strength = (float) Globals.rand.NextDouble();

            Monster monster = new Monster(name, health, strength);

            int loot = Globals.rand.Next(GameSettings.MAX_MONSTER_LOOT);
            bool equipUsed = false;
            for (int i = 0; i < loot; i ++)
            {
                float selection = (float) Globals.rand.NextDouble();
                if (selection < .33f || i == 0) // weapon
                {
                    Equipment weapon;
                    if (selection < .15f) weapon = VampiricWeapon.GenerateWeapon(); // vampiric weapon
                    else weapon = BasicWeapon.GenerateWeapon(); // normal weapon

                    if (!equipUsed)
                    {
                        monster.inventory.Add(weapon);
                        monster.quickSlots[0] = weapon;
                        equipUsed = true;
                    } else
                    {
                        monster.inventory.Add(weapon);
                    }
                } else // health potion
                {
                    int healthSize = (selection < .66f) ? 8 : 3;
                    monster.inventory.Add(new HealthPotion(healthSize));
                }
            }

            return monster;
        }
    }
}
