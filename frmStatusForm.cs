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
    public partial class frmStatusForm : Form
    {
        public frmStatusForm()
        {
            InitializeComponent();
        }
        public static void ShowStatus(Entity entity)
        {
            frmStatusForm statusForm = new frmStatusForm();
            statusForm.Text = $"Status ({entity.name})";
            statusForm.lblStatus.Text = $"{entity.name}\nHealth: {entity.health.ToString()}\nStrength: {entity.strength.ToString()}";
            statusForm.pbEntity.Image = entity.image;

            statusForm.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
