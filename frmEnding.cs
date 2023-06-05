using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public enum Ending
    {
        SUCCESS,
        RUN,
        FAIL
    };
    public partial class frmEnding : Form
    {
        public frmEnding(string message, Image image)
        {
            InitializeComponent();
            pbImage.Image = image;
            lblResult.Text = message;
        }
        public static void ShowEnding(Ending ending)
        {
            int score = 0;
            if (Globals.player.inventory.Count > 0)
            {
                if (ending == Ending.RUN)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Globals.player.inventory.RemoveAt(Globals.rand.Next(Globals.player.inventory.Count));
                        if (Globals.player.inventory.Count == 0)
                            break;
                    }
                }
                else if (ending == Ending.FAIL)
                {
                    List<Item> itemsToRemove = new List<Item>();
                    int salvaged = 5;
                    foreach (Item i in Globals.player.inventory)
                    {
                        if (salvaged > 0 && Globals.rand.Next(2) == 0)
                        {
                            salvaged--;
                            itemsToRemove.Add(i);
                        }
                    }
                    foreach (Item i in itemsToRemove)
                        Globals.player.inventory.Remove(i);
                }
            }
            foreach (Item i in Globals.player.inventory)
                score += i.GetValue();

            string message;
            Image image;
            switch (ending)
            {
                case Ending.SUCCESS:
                    score += 500;
                    message = $"You managed to make it out of the dungeon!\nThe items you looted have a value of {score}.\n\n Congratulations, adventurer!";
                    image = Images.end_success;
                    break;
                case Ending.RUN:
                    message = $"The monster chased you out of the dungeon, and you lost a few items on the way. The remaining items had a value of {score}";
                    image = Images.end_run;
                    break;
                case Ending.FAIL:
                    message = $"The dungeon claimed another life.\nThe recovery expedition managed to salvage a few items, with a value of {score}";
                    image = Images.end_fail;
                    break;
                default:
                    message = "WHAT";
                    image = Images.empty;
                    break;
            }

            frmEnding endForm = new frmEnding(message, image);
            endForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
