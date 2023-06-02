namespace Final_Project
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblItemStats = new System.Windows.Forms.Label();
            this.btnEquip = new System.Windows.Forms.Button();
            this.lbInventoryItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(188, 28);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(280, 280);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 1;
            this.pbItemImage.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnView.Location = new System.Drawing.Point(474, 314);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(263, 81);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDrop.Location = new System.Drawing.Point(380, 314);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(88, 81);
            this.btnDrop.TabIndex = 3;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = true;
            // 
            // btnUse
            // 
            this.btnUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUse.Location = new System.Drawing.Point(282, 314);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(92, 81);
            this.btnUse.TabIndex = 4;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblItemStats
            // 
            this.lblItemStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblItemStats.Location = new System.Drawing.Point(474, 28);
            this.lblItemStats.Name = "lblItemStats";
            this.lblItemStats.Size = new System.Drawing.Size(263, 280);
            this.lblItemStats.TabIndex = 6;
            // 
            // btnEquip
            // 
            this.btnEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEquip.Location = new System.Drawing.Point(188, 314);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(88, 81);
            this.btnEquip.TabIndex = 7;
            this.btnEquip.Text = "Equip";
            this.btnEquip.UseVisualStyleBackColor = true;
            // 
            // lbInventoryItems
            // 
            this.lbInventoryItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbInventoryItems.FormattingEnabled = true;
            this.lbInventoryItems.IntegralHeight = false;
            this.lbInventoryItems.ItemHeight = 20;
            this.lbInventoryItems.Location = new System.Drawing.Point(12, 28);
            this.lbInventoryItems.Name = "lbInventoryItems";
            this.lbInventoryItems.Size = new System.Drawing.Size(170, 367);
            this.lbInventoryItems.TabIndex = 0;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 407);
            this.ControlBox = false;
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.lblItemStats);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.lbInventoryItems);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblItemStats;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.ListBox lbInventoryItems;
    }
}