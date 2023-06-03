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
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory.ViewInventory(Globals.player, false);
        }
        private void displayActions()
        {
            lbActions.Items.Clear();
            
        }
    }
}
