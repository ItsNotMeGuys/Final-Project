using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public class Item
    {
        protected string name;
        protected int value;
        protected int weight;
        protected Image display;

        public Item(string name, int value, int weight, Image display)
        {
            this.name = name;
            this.value = value;
            this.weight = weight;
            this.display = display;
        }

        public string GetName()
        {
            return name;
        }
        public int GetValue()
        {
            return value;
        }
        public int GetWeight()
        {
            return weight;
        }
        public Image GetDisplay()
        {
            return display;
        }


        public virtual void Display(PictureBox imageDisplay, Label description)
        {
            if (imageDisplay != null)
                imageDisplay.Image = display;

            string message = $"{name}\nWeight: {weight}\nValue: {value}";
            if (description != null)
                description.Text = message;
        }
        public virtual int Use(Entity player)
        {
            return 0;
        }
    }
    public class HealthPotion : Item
    {
        float healthRegain;
        int size;
        bool empty;

        public HealthPotion(int size) : base("health potion", 0, 0, Images.health_potion_custom)
        {
            this.size = size;

            switch (size)
            {
                case 0:
                    name = "small health potion";
                    value = 100;
                    break;
                case 1:
                    name = "medium health potion";
                    value = 300;
                    break;
                case 2:
                    name = "large health potion";
                    value = 500;
                    break;
                default:
                    name = $"size {size} health potion";
                    value = 100 + size * 200;
                    break;
            }
            UpdateDisplay();
            weight = GameSettings.HEALTH_POTION_WEIGHT_BASE + (size * GameSettings.HEALTH_POTION_WEIGHT_INCREASE);
            healthRegain = GameSettings.HEALTH_POTION_REGAIN_BASE + (size * GameSettings.HEALTH_POTION_REGAIN_INCREASE);
        }
        public override void Display(PictureBox imageDisplay, Label description)
        {
            if (imageDisplay != null)
                imageDisplay.Image = display;
            string desc = $"{name}\nWeight: {weight}\nHealing: {healthRegain}\nValue: {value}";
            if (description != null)
                description.Text = desc;
        }
        public override int Use(Entity entity)
        {
            if (empty)
                return 1;

            entity.health += healthRegain;
            empty = true;
            name = "empty" + name;
            UpdateDisplay();

            return 0;
        }
        private void UpdateDisplay()
        {
            switch (size)
            {
                case 0:
                    display = (empty) ? Images.health_potion_small_empty : Images.health_potion_small;
                    break;
                case 1:
                    display = (empty) ? Images.health_potion_medium_empty : Images.health_potion_medium;
                    break;
                case 2:
                    display = (empty) ? Images.health_potion_large_empty : Images.health_potion_large;
                    break;
                default:
                    display = (empty) ? Images.health_potion_custom_empty : Images.health_potion_custom;
                    break;
            }
        }

    }
}
