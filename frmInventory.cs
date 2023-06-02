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
                lbInventoryItems.Items.Add(item);  // possibly change later?
            foreach (Equipment item in entity.quickSlots)
                lbInventoryItems.Items.Add(item);
        }
        Entity entity;
        public void ViewInventory(Entity entity, bool read_only)
        {
            btnUse.Enabled = !read_only;
            btnDrop.Enabled = !read_only;
            btnEquip.Enabled = !read_only;
            this.entity = entity;
            lbInventoryItems.Items.Clear();
            ShowDialog();            
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

    }
}
