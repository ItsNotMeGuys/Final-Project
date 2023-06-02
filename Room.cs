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
        RoomFeature left, center, right, middle;
        public static Room currentRoom;
        private static Room prevRoom;
        
        public static void GenNewRoom()
        {
            prevRoom = currentRoom;

            Room room = new Room();

            room.left = GenFeature();
            room.center = GenFeature();
            room.right = GenFeature();

            RoomFeature.FeatureType door = RoomFeature.FeatureType.DOOR;
            bool ladder = room.left.type != door && room.center.type != door && room.right.type != door;

            if (ladder)
                room.middle = Ladder.Generate();
            else
                room.middle = GenMiddle();
        }
        private static RoomFeature GenMiddle()
        {
            if (Globals.rand.Next(2) == 1) return Ladder.Generate();
            else return MonsterEncounter.EncounterMonster();
        }
        private static RoomFeature GenFeature()
        {
            switch (Globals.rand.Next())
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
        Image image
        {
            get;
            set;
        }
        string description 
        { 
            get; 
            set; 
        }

        public FeatureType type = FeatureType.EMPTY;
        public RoomFeature(Image image, string description)
        {
            this.image = image;
            this.description = description;
        }

        public virtual void Interact(Entity interacter)
        {
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
