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
    public partial class frmSlotPopup : Form
    {
        public frmSlotPopup()
        {
            InitializeComponent();
            initBoxes();
        }
        int selectedIndex = -1;
        PictureBox[] boxes = new PictureBox[5];
        Equipment[] slots;
        private void initBoxes()
        {
            boxes[0] = pbItem1;
            boxes[1] = pbItem2;
            boxes[2] = pbItem3;
            boxes[3] = pbItem4;
            boxes[4] = pbItem5;
        }
        public static int GetEquipmentSlot(Equipment[] slots, bool weaponsOnly)
        {
            if (slots.Length != 5)
            {
                MessageBox.Show("Invalid set of quickslots");
                return -1;
            }

            frmSlotPopup slotPopup = new frmSlotPopup();
            for (int i = 0; i < 5; i ++)
            {
                if (slots[i] != null)
                {
                    slotPopup.boxes[i].Image = slots[i].GetDisplay();
                    if (slots[i] as BasicWeapon == null)
                        slotPopup.boxes[i].Enabled = false;
                }
            }
            slotPopup.slots = slots;

            slotPopup.ShowDialog();

            return slotPopup.selectedIndex;
        }

        private void pbItem1_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1)
                boxes[selectedIndex].BorderStyle = BorderStyle.None;
            selectedIndex = 0;
            boxes[selectedIndex].BorderStyle = BorderStyle.Fixed3D;
            display();
        }
        private void pbItem2_Click(object sender, EventArgs e)
        {

            if (selectedIndex != -1)
                boxes[selectedIndex].BorderStyle = BorderStyle.None;
            selectedIndex = 1;
            boxes[selectedIndex].BorderStyle = BorderStyle.Fixed3D;
            display();
        }
        private void pbItem3_Click(object sender, EventArgs e)
        {

            if (selectedIndex != -1)
                boxes[selectedIndex].BorderStyle = BorderStyle.None;
            selectedIndex = 2;
            boxes[selectedIndex].BorderStyle = BorderStyle.Fixed3D;
            display();
        }
        private void pbItem4_Click(object sender, EventArgs e)
        {

            if (selectedIndex != -1)
                boxes[selectedIndex].BorderStyle = BorderStyle.None;
            selectedIndex = 3;
            boxes[selectedIndex].BorderStyle = BorderStyle.Fixed3D;
            display();
        }
        private void pbItem5_Click(object sender, EventArgs e)
        {

            if (selectedIndex != -1)
                boxes[selectedIndex].BorderStyle = BorderStyle.None;
            selectedIndex = 4;
            boxes[selectedIndex].BorderStyle = BorderStyle.Fixed3D;
            display();
        }
        private void display()
        {
            if (slots[selectedIndex] != null)
            {
                slots[selectedIndex].Display(null, lblDescription);
            }
            else lblDescription.Text = "An empty slot";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
                return;
            this.DialogResult = DialogResult.OK;
        }
    }
}
