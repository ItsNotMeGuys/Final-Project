namespace Final_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbActions = new System.Windows.Forms.ListBox();
            this.btnCommitAction = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblItemDisplay = new System.Windows.Forms.Label();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.lvRoomObjects = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbActions
            // 
            this.lbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbActions.FormattingEnabled = true;
            this.lbActions.HorizontalScrollbar = true;
            this.lbActions.IntegralHeight = false;
            this.lbActions.ItemHeight = 20;
            this.lbActions.Location = new System.Drawing.Point(12, 34);
            this.lbActions.Name = "lbActions";
            this.lbActions.Size = new System.Drawing.Size(173, 330);
            this.lbActions.TabIndex = 1;
            // 
            // btnCommitAction
            // 
            this.btnCommitAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCommitAction.Location = new System.Drawing.Point(13, 369);
            this.btnCommitAction.Name = "btnCommitAction";
            this.btnCommitAction.Size = new System.Drawing.Size(173, 83);
            this.btnCommitAction.TabIndex = 2;
            this.btnCommitAction.Text = "Commit";
            this.btnCommitAction.UseVisualStyleBackColor = true;
            this.btnCommitAction.Click += new System.EventHandler(this.btnCommitAction_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.viewStatsToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // viewStatsToolStripMenuItem
            // 
            this.viewStatsToolStripMenuItem.Name = "viewStatsToolStripMenuItem";
            this.viewStatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewStatsToolStripMenuItem.Text = "View Stats";
            this.viewStatsToolStripMenuItem.Click += new System.EventHandler(this.viewStatsToolStripMenuItem_Click);
            // 
            // lblItemDisplay
            // 
            this.lblItemDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblItemDisplay.Location = new System.Drawing.Point(439, 337);
            this.lblItemDisplay.Name = "lblItemDisplay";
            this.lblItemDisplay.Size = new System.Drawing.Size(300, 115);
            this.lblItemDisplay.TabIndex = 8;
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(439, 34);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(300, 300);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 3;
            this.pbItemImage.TabStop = false;
            // 
            // lvRoomObjects
            // 
            this.lvRoomObjects.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvRoomObjects.AutoArrange = false;
            this.lvRoomObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvRoomObjects.HideSelection = false;
            this.lvRoomObjects.Location = new System.Drawing.Point(192, 34);
            this.lvRoomObjects.MultiSelect = false;
            this.lvRoomObjects.Name = "lvRoomObjects";
            this.lvRoomObjects.Size = new System.Drawing.Size(241, 418);
            this.lvRoomObjects.TabIndex = 9;
            this.lvRoomObjects.UseCompatibleStateImageBehavior = false;
            this.lvRoomObjects.View = System.Windows.Forms.View.List;
            this.lvRoomObjects.SelectedIndexChanged += new System.EventHandler(this.lvRoomObjects_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 464);
            this.Controls.Add(this.lvRoomObjects);
            this.Controls.Add(this.lblItemDisplay);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.btnCommitAction);
            this.Controls.Add(this.lbActions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbActions;
        private System.Windows.Forms.Button btnCommitAction;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatsToolStripMenuItem;
        private System.Windows.Forms.Label lblItemDisplay;
        private System.Windows.Forms.ListView lvRoomObjects;
    }
}

