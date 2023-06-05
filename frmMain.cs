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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Globals.mainForm = this;
            Room.GenNewRoom();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory.ViewInventory(Globals.player, false);
            updateView();
        }

        private void btnCommitAction_Click(object sender, EventArgs e)
        {
            if (lbActions.SelectedIndex == -1)
                return;

            if (((string)lbActions.SelectedItem).StartsWith("Interact"))
            {
                RoomFeature feature = lvRoomObjects.SelectedItems[0].Tag as RoomFeature;
                feature.Interact(Globals.player);
            } else if ((string)lbActions.SelectedItem == "Leave")
            {
                frmEnding.ShowEnding(Ending.SUCCESS);
                return;
            }

            Room.currentRoom.ClearUsedPaintingsAndItems();
            if (Globals.player.health == 0)
                Application.Exit();
            updateView();
        }
        public void updateView()
        {
            try
            {
                lbActions.ClearSelected();
                lbActions.Items.Clear();
                lvRoomObjects.Items.Clear();

                addItem(Room.currentRoom.left);
                addItem(Room.currentRoom.center);
                addItem(Room.currentRoom.right);
                addItem(Room.currentRoom.middle);
                foreach (RoomFeature feature in Room.currentRoom.floorItems)
                    addItem(feature);

                pbItemImage.Image = null;
                lblItemDisplay.Text = "";
            } catch (ObjectDisposedException ex)
            {
                return;
            }
        }
        private void addItem(RoomFeature feature)
        {
            if (feature == null) return;
            ListViewItem item = new ListViewItem();
            item.Text = feature.name;
            item.Tag = feature;

            lvRoomObjects.Items.Add(item);
        }

        private void lvRoomObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRoomObjects.SelectedItems.Count == 0) return;

            lbActions.ClearSelected();
            lbActions.Items.Clear();

            RoomFeature feature = lvRoomObjects.SelectedItems[0].Tag as RoomFeature;
            if (feature != null)
            {
                if (!feature.used && feature.type != RoomFeature.FeatureType.ENCOUNTER)
                    lbActions.Items.Add($"Interact with {lvRoomObjects.SelectedItems[0].Text}");
                feature.Display(pbItemImage, lblItemDisplay);
            }
            lbActions.Items.Add("Leave");
        }

        private void viewStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatusForm.ShowStatus(Globals.player);
        }
    }
}
