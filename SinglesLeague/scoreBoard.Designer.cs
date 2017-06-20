namespace SinglesLeague
{
    partial class scoreBoard
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
            this.textBoxAwayScore = new System.Windows.Forms.TextBox();
            this.textBoxHomeScore = new System.Windows.Forms.TextBox();
            this.buttonAway = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelAwayScore = new System.Windows.Forms.Label();
            this.labelHomeScore = new System.Windows.Forms.Label();
            this.textBoxAwayName = new System.Windows.Forms.TextBox();
            this.textBoxHomeName = new System.Windows.Forms.TextBox();
            this.labelLeg = new System.Windows.Forms.Label();
            this.comboBoxOut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelThrown = new System.Windows.Forms.Label();
            this.comboBoxThrown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxAwayScore
            // 
            this.textBoxAwayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAwayScore.Location = new System.Drawing.Point(184, 340);
            this.textBoxAwayScore.Name = "textBoxAwayScore";
            this.textBoxAwayScore.Size = new System.Drawing.Size(204, 116);
            this.textBoxAwayScore.TabIndex = 2;
            this.textBoxAwayScore.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAwayScore_KeyUp);
            // 
            // textBoxHomeScore
            // 
            this.textBoxHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHomeScore.Location = new System.Drawing.Point(1144, 340);
            this.textBoxHomeScore.Name = "textBoxHomeScore";
            this.textBoxHomeScore.Size = new System.Drawing.Size(204, 116);
            this.textBoxHomeScore.TabIndex = 3;
            this.textBoxHomeScore.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxHomeScore_KeyUp);
            // 
            // buttonAway
            // 
            this.buttonAway.Location = new System.Drawing.Point(184, 496);
            this.buttonAway.Name = "buttonAway";
            this.buttonAway.Size = new System.Drawing.Size(204, 23);
            this.buttonAway.TabIndex = 4;
            this.buttonAway.TabStop = false;
            this.buttonAway.Text = "Enter";
            this.buttonAway.UseVisualStyleBackColor = true;
            this.buttonAway.Click += new System.EventHandler(this.buttonAway_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(1144, 496);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(204, 23);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.TabStop = false;
            this.buttonHome.Text = "Enter";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelAwayScore
            // 
            this.labelAwayScore.AutoSize = true;
            this.labelAwayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAwayScore.Location = new System.Drawing.Point(184, 194);
            this.labelAwayScore.Name = "labelAwayScore";
            this.labelAwayScore.Size = new System.Drawing.Size(204, 108);
            this.labelAwayScore.TabIndex = 6;
            this.labelAwayScore.Text = "501";
            // 
            // labelHomeScore
            // 
            this.labelHomeScore.AutoSize = true;
            this.labelHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeScore.Location = new System.Drawing.Point(1144, 194);
            this.labelHomeScore.Name = "labelHomeScore";
            this.labelHomeScore.Size = new System.Drawing.Size(204, 108);
            this.labelHomeScore.TabIndex = 7;
            this.labelHomeScore.Text = "501";
            // 
            // textBoxAwayName
            // 
            this.textBoxAwayName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAwayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAwayName.Location = new System.Drawing.Point(12, 28);
            this.textBoxAwayName.Name = "textBoxAwayName";
            this.textBoxAwayName.Size = new System.Drawing.Size(618, 116);
            this.textBoxAwayName.TabIndex = 8;
            this.textBoxAwayName.TabStop = false;
            this.textBoxAwayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHomeName
            // 
            this.textBoxHomeName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxHomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHomeName.Location = new System.Drawing.Point(903, 28);
            this.textBoxHomeName.Name = "textBoxHomeName";
            this.textBoxHomeName.Size = new System.Drawing.Size(618, 116);
            this.textBoxHomeName.TabIndex = 9;
            this.textBoxHomeName.TabStop = false;
            this.textBoxHomeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLeg
            // 
            this.labelLeg.AutoSize = true;
            this.labelLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeg.Location = new System.Drawing.Point(746, 28);
            this.labelLeg.Name = "labelLeg";
            this.labelLeg.Size = new System.Drawing.Size(48, 52);
            this.labelLeg.TabIndex = 10;
            this.labelLeg.Text = "0";
            // 
            // comboBoxOut
            // 
            this.comboBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOut.FormattingEnabled = true;
            this.comboBoxOut.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxOut.Location = new System.Drawing.Point(750, 340);
            this.comboBoxOut.Name = "comboBoxOut";
            this.comboBoxOut.Size = new System.Drawing.Size(44, 32);
            this.comboBoxOut.TabIndex = 12;
            this.comboBoxOut.TabStop = false;
            this.comboBoxOut.Text = "0";
            this.comboBoxOut.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Out";
            // 
            // labelThrown
            // 
            this.labelThrown.AutoSize = true;
            this.labelThrown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThrown.Location = new System.Drawing.Point(746, 385);
            this.labelThrown.Name = "labelThrown";
            this.labelThrown.Size = new System.Drawing.Size(52, 24);
            this.labelThrown.TabIndex = 14;
            this.labelThrown.Text = "Darts";
            // 
            // comboBoxThrown
            // 
            this.comboBoxThrown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThrown.FormattingEnabled = true;
            this.comboBoxThrown.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxThrown.Location = new System.Drawing.Point(750, 412);
            this.comboBoxThrown.Name = "comboBoxThrown";
            this.comboBoxThrown.Size = new System.Drawing.Size(44, 32);
            this.comboBoxThrown.TabIndex = 15;
            this.comboBoxThrown.TabStop = false;
            this.comboBoxThrown.Text = "3";
            this.comboBoxThrown.Visible = false;
            // 
            // scoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 714);
            this.Controls.Add(this.comboBoxThrown);
            this.Controls.Add(this.labelThrown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOut);
            this.Controls.Add(this.labelLeg);
            this.Controls.Add(this.textBoxHomeName);
            this.Controls.Add(this.textBoxAwayName);
            this.Controls.Add(this.labelHomeScore);
            this.Controls.Add(this.labelAwayScore);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonAway);
            this.Controls.Add(this.textBoxHomeScore);
            this.Controls.Add(this.textBoxAwayScore);
            this.Name = "scoreBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAwayScore;
        private System.Windows.Forms.TextBox textBoxHomeScore;
        private System.Windows.Forms.Button buttonAway;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelAwayScore;
        private System.Windows.Forms.Label labelHomeScore;
        private System.Windows.Forms.TextBox textBoxAwayName;
        private System.Windows.Forms.TextBox textBoxHomeName;
        private System.Windows.Forms.Label labelLeg;
        private System.Windows.Forms.ComboBox comboBoxOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelThrown;
        private System.Windows.Forms.ComboBox comboBoxThrown;
    }
}