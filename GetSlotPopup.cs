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
    public partial class GetSlotPopup : Form
    {
        public GetSlotPopup()
        {
            InitializeComponent();
            initBoxes();
        }
        int selectedIndex = -1;
        PictureBox[] boxes = new PictureBox[5];
        private void initBoxes()
        {
            boxes[0] = pbItem1;
            boxes[1] = pbItem2;
            boxes[2] = pbItem3;
            boxes[3] = pbItem4;
            boxes[4] = pbItem5;
        }
        public int GetEquipmentSlot(Equipment[] slots)
        {
            if (slots.Length != 5)
            {
                MessageBox.Show("Invalid set of quickslots");
                return -1;
            }

            for (int i = 0; i < 5; i ++)
            {
                boxes[i].Image = slots[i].GetDisplay();
            }

            ShowDialog();

            return selectedIndex;
        }

        private void pbItem1_Click(object sender, EventArgs e)
        {
            selectedIndex = 0;
            DialogResult = DialogResult.OK;
        }
        private void pbItem2_Click(object sender, EventArgs e)
        {

            selectedIndex = 1;
            DialogResult = DialogResult.OK;
        }
        private void pbItem3_Click(object sender, EventArgs e)
        {

            selectedIndex = 2;
            DialogResult = DialogResult.OK;
        }
        private void pbItem4_Click(object sender, EventArgs e)
        {

            selectedIndex = 3;
            DialogResult = DialogResult.OK;
        }
        private void pbItem5_Click(object sender, EventArgs e)
        {

            selectedIndex = 4;
            DialogResult = DialogResult.OK;
        }
    }
}
