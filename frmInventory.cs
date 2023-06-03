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
            foreach (Item item in entity.inventory)
            {
                lbInventoryItems.Items.Add(item);  // possibly change later?
            }
        }
        Entity entity;
        public static void ViewInventory(Entity entity, bool read_only)
        {
            frmInventory inventory = new frmInventory();

            inventory.btnUse.Enabled = !read_only;
            inventory.btnDrop.Enabled = !read_only;
            inventory.btnEquip.Enabled = !read_only;
            inventory.entity = entity;
            inventory.lbInventoryItems.Items.Clear();
            inventory.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btnUse_Click(object sender, EventArgs e)
        {

            if (lbInventoryItems.SelectedIndex > lbInventoryItems.Items.Count || lbInventoryItems.SelectedIndex < 0)
                return;

            Item selected = (Item) lbInventoryItems.Items[lbInventoryItems.SelectedIndex];
            selected.Use(entity);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (lbInventoryItems.SelectedIndex > lbInventoryItems.Items.Count || lbInventoryItems.SelectedIndex < 0)
                return;

            Item selected = (Item) lbInventoryItems.Items[lbInventoryItems.SelectedIndex];
            selected.Display(pbItemImage, lblItemStats);
        }
        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (lbInventoryItems.SelectedIndex > lbInventoryItems.Items.Count || lbInventoryItems.SelectedIndex < 0)
                return;

            Equipment item = lbInventoryItems.Items[lbInventoryItems.SelectedIndex] as Equipment;

            if (item != null)
            {
                int selectedIndex = frmSlotPopup.GetEquipmentSlot(entity.quickSlots);
                entity.quickSlots[selectedIndex] = item;
            }
            else MessageBox.Show("Invalid item selected");
        }
    }
}
