namespace Final_Project
{
    partial class frmMonsterFight
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
            this.lbActions = new System.Windows.Forms.ListBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lblMonsterDisplay = new System.Windows.Forms.Label();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.pbMonster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // lbActions
            // 
            this.lbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbActions.FormattingEnabled = true;
            this.lbActions.HorizontalScrollbar = true;
            this.lbActions.IntegralHeight = false;
            this.lbActions.ItemHeight = 20;
            this.lbActions.Location = new System.Drawing.Point(12, 12);
            this.lbActions.Name = "lbActions";
            this.lbActions.Size = new System.Drawing.Size(144, 222);
            this.lbActions.TabIndex = 0;
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCommit.Location = new System.Drawing.Point(12, 240);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(144, 40);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // lblMonsterDisplay
            // 
            this.lblMonsterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMonsterDisplay.Location = new System.Drawing.Point(426, 215);
            this.lblMonsterDisplay.Name = "lblMonsterDisplay";
            this.lblMonsterDisplay.Size = new System.Drawing.Size(204, 65);
            this.lblMonsterDisplay.TabIndex = 3;
            // 
            // lbEvents
            // 
            this.lbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.HorizontalScrollbar = true;
            this.lbEvents.IntegralHeight = false;
            this.lbEvents.ItemHeight = 20;
            this.lbEvents.Location = new System.Drawing.Point(162, 12);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(258, 268);
            this.lbEvents.TabIndex = 4;
            // 
            // pbMonster
            // 
            this.pbMonster.Location = new System.Drawing.Point(430, 12);
            this.pbMonster.Name = "pbMonster";
            this.pbMonster.Size = new System.Drawing.Size(200, 200);
            this.pbMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonster.TabIndex = 2;
            this.pbMonster.TabStop = false;
            // 
            // frmMonsterFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 292);
            this.ControlBox = false;
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.lblMonsterDisplay);
            this.Controls.Add(this.pbMonster);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.lbActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMonsterFight";
            this.Text = "Battle!";
            this.Load += new System.EventHandler(this.frmMonsterFight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbActions;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.PictureBox pbMonster;
        private System.Windows.Forms.Label lblMonsterDisplay;
        private System.Windows.Forms.ListBox lbEvents;
    }
}