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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            updateView();
        }
        private void updateView()
        {
            lvInventoryItems.Items.Clear();
            foreach (Item item in entity.inventory)
            {
                ListViewItem i = new ListViewItem();
                i.Text = item.GetName();
                i.Tag = item;
                lvInventoryItems.Items.Add(i);
            }

            pbItemImage.Image = null;
            lblItemStats.Text = "";
        }
        Entity entity;
        public static void ViewInventory(Entity entity, bool battle)
        {
            frmInventory inventory = new frmInventory();

            inventory.btnDrop.Enabled = !battle;
            inventory.btnEquip.Enabled = !battle;
            inventory.entity = entity;
            inventory.lvInventoryItems.Items.Clear();
            inventory.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btnUse_Click(object sender, EventArgs e)
        {
            if (lvInventoryItems.SelectedItems.Count == 0) return;
            Item selected = (Item)lvInventoryItems.SelectedItems[0].Tag;
            selected.Use(entity);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (lvInventoryItems.SelectedItems.Count == 0) return;
            Item selected = (Item)lvInventoryItems.SelectedItems[0].Tag;
            selected.Display(pbItemImage, lblItemStats);
        }
        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (lvInventoryItems.SelectedItems.Count == 0) return;
            Equipment item = lvInventoryItems.SelectedItems[0].Tag as Equipment;

            if (item != null)
            {
                int selectedIndex = frmSlotPopup.GetEquipmentSlot(entity.quickSlots, false);
                for (int i = 0; i < entity.quickSlots.Length; i++)
                {
                    if (entity.quickSlots[i] == item)
                        entity.quickSlots[i] = null;
                }
                entity.quickSlots[selectedIndex] = item;

            }
            else MessageBox.Show("Invalid item selected");
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (lvInventoryItems.SelectedItems.Count == 0) return;
            Item item = lvInventoryItems.SelectedItems[0].Tag as Item;
            entity.inventory.Remove(item);
            Room.currentRoom.floorItems.Add(new ItemFeature(item));
            updateView();
        }
    }
}
