using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    class Room
    {
        public RoomFeature left, center, right, middle;
        public List<ItemFeature> floorItems = new List<ItemFeature>();
        public static Room currentRoom = null;
        private static Room prevRoom = null;

        public static int rooms = 0;
        public void ClearUsedPaintingsAndItems()
        {
            if ((left as ItemFeature != null || left as Painting_F != null) && left.used)
                left = null;
            if ((center as ItemFeature != null || center as Painting_F != null) && center.used)
                center = null;
            if ((right as ItemFeature != null || right as Painting_F != null) && right.used)
                right = null;
            if ((middle as ItemFeature != null || middle as Painting_F != null) && middle.used)
                middle = null;

            floorItems.RemoveAll(x => x.used);
        }
        public static void GenNewRoom()
        {
            prevRoom = currentRoom;

            Room room = new Room();
            rooms++;

            room.left = GenFeature();
            room.left.name += " (left wall)";
            room.center = GenFeature();
            room.center.name += " (middle wall)";
            room.right = GenFeature();
            room.right.name += " (right wall)";

            RoomFeature.FeatureType door = RoomFeature.FeatureType.DOOR;
            bool ladder = room.left.type != door && room.center.type != door && room.right.type != door;

            if (ladder)
                room.middle = Ladder.Generate();
            else
                room.middle = GenMiddle();

            currentRoom = room;
            if (Globals.player.health == 0)
            {
                return;
            }
            Globals.mainForm.updateView();
        }
        private static RoomFeature GenMiddle()
        {
            int r = Globals.rand.Next(5);
            if (r <= 1) // 2/5 is monster
            {
                return MonsterEncounter.EncounterMonster();
            }else if (r <= 3) // 2/5 is pedestal
            {
                return Pedestal.Generate();
            } else // 1/5 is empty
            {
                return null;
            }
        }
        private static RoomFeature GenFeature()
        {
            switch (Globals.rand.Next(3))
            {
                case 0:
                    return Painting_F.Generate();
                case 1:
                    return Shelf.Generate();
                case 2:
                    return Door.Generate();
                default:
                    return RoomFeature.Generate();
            }
        }
    }
    public class RoomFeature
    {
        public enum FeatureType
        {
            EMPTY,
            DOOR,
            SHELF,
            PEDESTAL,
            LADDER,
            PAINTING,
            ENCOUNTER
        };
        public Image image
        {
            get;
            set;
        }
        public string description
        { 
            get; 
            set; 
        }
        public string name = "feature";
        public bool used = false;

        public FeatureType type = FeatureType.EMPTY;
        public RoomFeature(Image image, string description)
        {
            this.image = image;
            this.description = description;
        }

        public virtual void Interact(Entity interacter)
        {
            used = true;
            return;
        }
        public virtual void Display(PictureBox box, Label label)
        {
            box.Image = image;
            label.Text = description;
        }
        public static RoomFeature Generate()
        {
            return new RoomFeature(Images.empty, "A glitch in the matrix");
        }
    }
}
