using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public class Painting_F : RoomFeature
    {
        public bool is_trap;
        public Painting_F(Image image, string description, bool trap) : base(image, description)
        {
            type = FeatureType.PAINTING;
            this.name = "Painting";
            is_trap = trap;
        }

        public override void Interact(Entity interacter)
        {
            base.Interact(interacter);

            if (is_trap)
            {
                interacter.health -= GameSettings.PAINTING_DAMAGE;
                MessageBox.Show("that was a trap painting!");
            } else
            {
                Item painting = new Item("Painting", GameSettings.PAINTING_VALUE, 5, image);

                interacter.inventory.Add(painting);
            }
        }
        public override void Display(PictureBox box, Label lblDescription)
        {
            if (box != null)
                box.Image = image;
            if (box != null)
                lblDescription.Text = description;
        }
        public static new Painting_F Generate()
        {
            string description = "An elegant painting";
            Image display = painting_options[Globals.rand.Next(painting_options.Length)];
            Painting_F painting = new Painting_F(display, description, Globals.rand.Next(2) == 1);
            return painting;
        }
        static Image[] painting_options = new Image[]
        {
            Images.painting_a,
            Images.painting_b,
            Images.painting_c
        };
    }
    public class Container : RoomFeature
    {
        Item item;
        public Container(Image image, string description, Item item) : base(image, description)
        {
            this.type = FeatureType.EMPTY;
            this.item = item;
        }

        public override void Interact(Entity interacter)
        {
            base.Interact(interacter);

            interacter.inventory.Add(item);
        }

        public static new Container Generate()
        {
            Image display = Images.shelf;
            HealthPotion potion = new HealthPotion(Globals.rand.Next(3));
            string description = "A nice glitch in the matrix with a " + potion.GetName();

            Container shelf = new Container(display, description, potion);
            return shelf;
        }
    }
    public class Shelf : Container
    {
        public Shelf(Image image, string description, Item item) : base(image, description, item)
        {
            type = FeatureType.SHELF;
            this.name = "Shelf";
        }
        public static new Shelf Generate()
        {
            Image display = Images.shelf;
            HealthPotion potion = new HealthPotion(Globals.rand.Next(5));
            string description = "A nice shelf with a " + potion.GetName();

            Shelf shelf = new Shelf(display, description, potion);
            return shelf;
        }
    }
    public class Pedestal : Container
    {
        public Pedestal(Image image, string description, Item item) : base(image, description, item)
        {
            type = FeatureType.PEDESTAL;
            name = "Pedestal";
        }
        public static new Pedestal Generate()
        {
            Image display = Images.pedestal;
            Equipment equip;
            if (Globals.rand.Next(5) == 1) // vampiric weapon (1/5 chance)
                equip = VampiricWeapon.GenerateWeapon();
            else
                equip = BasicWeapon.GenerateWeapon();
            string description = $"A pedestal with a mysterious sword inside.\nThe sword is named {equip.GetName()}";
            Pedestal pedestal = new Pedestal(display, description, equip);
            return pedestal;
        }
    }
    public class ItemFeature : RoomFeature
    {
        Item item;
        public ItemFeature(Item item) : base(item.GetDisplay(), "An " + item.GetName().ToLower() + " on the floor")
        {
            this.name = item.GetName();
            this.item = item;
        }
        public override void Interact(Entity interacter)
        {
            base.Interact(interacter);

            interacter.inventory.Add(item);
        }
    }
    public class Door : RoomFeature
    {
        public Door(Image image, string description) : base(image, description)
        {
            type = FeatureType.DOOR;
            this.name = "Door";
        }

        public override void Interact(Entity interacter)
        {
            base.Interact(interacter);

            Room.GenNewRoom();
        }

        static Image[] images =
        {
            Images.door_a,
            Images.door_b,
            Images.door_c,
            Images.door_d
        };
        public static new Door Generate()
        {
            Image image = images[Globals.rand.Next(images.Length)];
            string description = "A nice door";

            return new Door(image, description);
        }
    }
    public class Ladder : RoomFeature
    {
        public Ladder(Image image, string description) : base(image, description)
        {
            type = FeatureType.LADDER;
            this.name = "Ladder";
        }

        public override void Interact(Entity interacter)
        {
            base.Interact(interacter);

            Room.GenNewRoom();
        }
        public static new Ladder Generate()
        {
            string description = "A nice ladder";

            return new Ladder(Images.ladder, description);
        }
    }
    public class MonsterEncounter : RoomFeature
    {
        public MonsterEncounter(Image image, string description) : base(image, description)
        {
            type = FeatureType.ENCOUNTER;
        }
        Monster monster = null;
    
        public static MonsterEncounter EncounterMonster()
        {
            MonsterEncounter encounter = new MonsterEncounter(Images.dead_monster, "A dead Monster");
            encounter.monster = frmMonsterFight.FightMonster();

            return encounter;
        }
    }
}
