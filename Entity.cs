using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Project
{
    public class Entity
    {
        public float health;
        public float strength;
        public string name;
        public Image image;

        public List<Item> inventory = new List<Item>();
        public Equipment[] quickSlots = new Equipment[5];

        public Entity(string name, float health, float strength, Image image)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.image = image;
        }
        public static string GetAttack(Entity entityA, BasicWeapon weaponA, Entity entityD, BasicWeapon weaponD, bool blocked)
        {
            if (blocked)
            {
                float penChance = 1;
                penChance *= entityA.strength / entityD.strength;
                penChance *= weaponA.GetWeight() / weaponD.GetWeight();

                if (Globals.rand.NextDouble() < penChance)
                {
                    weaponA.UseEquipment(entityA, entityD);
                    return $"{entityA.name} swung at {entityD.name}, and {entityD.name} blocked. However, {entityA.name} broke through {entityD.name}'s defense and did {weaponA.damage * entityA.strength} damage!";
                } else
                {
                    return $"{entityA.name} swung at {entityD.name}, and {entityD.name} blocked it!";
                }
            } else
            {
                weaponA.UseEquipment(entityA, entityD);
                return $"{entityA.name} swung at {entityD.name} and did {weaponA.damage * entityA.strength} damage!";
            }
        }
        public List<string> getActions()
        {
            List<string> actions = new List<string>();
            actions.Clear();
            actions.Add("Swing");
            actions.Add("Block");

            return actions;
        }
    }
}
