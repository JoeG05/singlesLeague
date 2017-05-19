namespace SinglesLeague
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thursdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wednesdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thursdayToolStripMenuItem,
            this.wednesdayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // thursdayToolStripMenuItem
            // 
            this.thursdayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreToolStripMenuItem,
            this.standingsToolStripMenuItem});
            this.thursdayToolStripMenuItem.Name = "thursdayToolStripMenuItem";
            this.thursdayToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thursdayToolStripMenuItem.Text = "&Thursday";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.scoreToolStripMenuItem.Text = "Keep Score";
            // 
            // standingsToolStripMenuItem
            // 
            this.standingsToolStripMenuItem.Name = "standingsToolStripMenuItem";
            this.standingsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.standingsToolStripMenuItem.Text = "Standings";
            // 
            // wednesdayToolStripMenuItem
            // 
            this.wednesdayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterStatsToolStripMenuItem,
            this.standingsToolStripMenuItem1});
            this.wednesdayToolStripMenuItem.Name = "wednesdayToolStripMenuItem";
            this.wednesdayToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.wednesdayToolStripMenuItem.Text = "&Wednesday";
            // 
            // enterStatsToolStripMenuItem
            // 
            this.enterStatsToolStripMenuItem.Name = "enterStatsToolStripMenuItem";
            this.enterStatsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enterStatsToolStripMenuItem.Text = "Enter Stats";
            this.enterStatsToolStripMenuItem.Click += new System.EventHandler(this.enterStatsToolStripMenuItem_Click);
            // 
            // standingsToolStripMenuItem1
            // 
            this.standingsToolStripMenuItem1.Name = "standingsToolStripMenuItem1";
            this.standingsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.standingsToolStripMenuItem1.Text = "Standings";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Singles League";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thursdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wednesdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standingsToolStripMenuItem1;
    }
}

