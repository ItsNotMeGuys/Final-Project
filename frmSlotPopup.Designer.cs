namespace Final_Project
{
    partial class frmSlotPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlotPopup));
            this.pbItem1 = new System.Windows.Forms.PictureBox();
            this.pbItem2 = new System.Windows.Forms.PictureBox();
            this.pbItem3 = new System.Windows.Forms.PictureBox();
            this.pbItem4 = new System.Windows.Forms.PictureBox();
            this.pbItem5 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItem1
            // 
            this.pbItem1.Location = new System.Drawing.Point(12, 12);
            this.pbItem1.Name = "pbItem1";
            this.pbItem1.Size = new System.Drawing.Size(100, 100);
            this.pbItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem1.TabIndex = 0;
            this.pbItem1.TabStop = false;
            this.pbItem1.Click += new System.EventHandler(this.pbItem1_Click);
            // 
            // pbItem2
            // 
            this.pbItem2.Location = new System.Drawing.Point(118, 12);
            this.pbItem2.Name = "pbItem2";
            this.pbItem2.Size = new System.Drawing.Size(100, 100);
            this.pbItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem2.TabIndex = 1;
            this.pbItem2.TabStop = false;
            this.pbItem2.Click += new System.EventHandler(this.pbItem2_Click);
            // 
            // pbItem3
            // 
            this.pbItem3.Location = new System.Drawing.Point(224, 12);
            this.pbItem3.Name = "pbItem3";
            this.pbItem3.Size = new System.Drawing.Size(100, 100);
            this.pbItem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem3.TabIndex = 2;
            this.pbItem3.TabStop = false;
            this.pbItem3.Click += new System.EventHandler(this.pbItem3_Click);
            // 
            // pbItem4
            // 
            this.pbItem4.Location = new System.Drawing.Point(330, 12);
            this.pbItem4.Name = "pbItem4";
            this.pbItem4.Size = new System.Drawing.Size(100, 100);
            this.pbItem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem4.TabIndex = 3;
            this.pbItem4.TabStop = false;
            this.pbItem4.Click += new System.EventHandler(this.pbItem4_Click);
            // 
            // pbItem5
            // 
            this.pbItem5.Location = new System.Drawing.Point(436, 12);
            this.pbItem5.Name = "pbItem5";
            this.pbItem5.Size = new System.Drawing.Size(100, 100);
            this.pbItem5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem5.TabIndex = 4;
            this.pbItem5.TabStop = false;
            this.pbItem5.Click += new System.EventHandler(this.pbItem5_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDescription.Location = new System.Drawing.Point(12, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(418, 153);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "...";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOK.Location = new System.Drawing.Point(436, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 153);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // GetSlotPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 277);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pbItem5);
            this.Controls.Add(this.pbItem4);
            this.Controls.Add(this.pbItem3);
            this.Controls.Add(this.pbItem2);
            this.Controls.Add(this.pbItem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetSlotPopup";
            this.Text = "Select the slot";
            ((System.ComponentModel.ISupportInitialize)(this.pbItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItem1;
        private System.Windows.Forms.PictureBox pbItem2;
        private System.Windows.Forms.PictureBox pbItem3;
        private System.Windows.Forms.PictureBox pbItem4;
        private System.Windows.Forms.PictureBox pbItem5;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnOK;
    }
}