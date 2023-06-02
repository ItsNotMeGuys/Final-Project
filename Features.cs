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
        public new FeatureType type = FeatureType.PAINTING;

        bool used = false;

        public Painting_F(Image image, string description, bool trap) : base(image, description)
        {
            is_trap = trap;
        }

        public Image image;
        public string description;

        public override void Interact(Entity interacter)
        {
            if (used)
                return;

            if (is_trap)
            {
                interacter.health -= GameSettings.PAINTING_DAMAGE;
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
        static Image[] painting_options;
        private static void initPaintingOptions()
        {
            painting_options = new Image[] {
                Images.painting_a,
                Images.painting_b,
                Images.painting_c
            };
        }
    }
    public class Container : RoomFeature
    {
        Item item;
        bool used = false;
        public new FeatureType type = FeatureType.EMPTY;
        public Container(Image image, string description, Item item) : base(image, description)
        {
            this.item = item;
        }

        public override void Interact(Entity interacter)
        {
            if (used)
                return;

            interacter.inventory.Add(item);
            used = true;
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
        public static new FeatureType type = FeatureType.SHELF;
        public Shelf(Image image, string description, Item item) : base(image, description, item)
        {

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
    public class Door : RoomFeature
    {
        public new FeatureType type = FeatureType.DOOR;
        public Door(Image image, string description) : base(image, description)
        {
        }

        public override void Interact(Entity interacter)
        {
            Room.GenNewRoom();
        }

        static Image[] images;
        public static new Door Generate()
        {
            Image image = images[Globals.rand.Next(images.Length)];
            string description = "A nice door";

            return new Door(image, description);
        }
        public static void initDoorOptions()
        {
            images = new Image[]
            {
                Images.door_a,
                Images.door_b,
                Images.door_c,
                Images.door_d
            };
        }
    }
    public class Ladder : RoomFeature
    {
        public new FeatureType type = FeatureType.LADDER;
        public Ladder(Image image, string description) : base(image, description)
        {
        }

        public override void Interact(Entity interacter)
        {
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

        }
    
        public static void EncounterMonster()
        {

        }
    }
}
