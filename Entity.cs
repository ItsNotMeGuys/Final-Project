using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Entity
    {
        public float health;
        public float accuracy;
        public float strength;
        public string name;

        public List<Item> inventory = new List<Item>();
        public Equipment[] quickSlots = new Equipment[5];

        public Entity(string name, float health, float accuracy, float strength)
        {
            this.name = name;
            this.health = health;
            this.accuracy = accuracy;
        }
    }
}
