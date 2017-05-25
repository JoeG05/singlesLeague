namespace SinglesLeague
{
    partial class Form3
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
            this.labelWeek = new System.Windows.Forms.Label();
            this.comboBoxWeek = new System.Windows.Forms.ComboBox();
            this.comboBoxMatch = new System.Windows.Forms.ComboBox();
            this.labelMatch = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.radioButtonHome = new System.Windows.Forms.RadioButton();
            this.radioButtonAway = new System.Windows.Forms.RadioButton();
            this.buttonGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Location = new System.Drawing.Point(13, 24);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(39, 13);
            this.labelWeek.TabIndex = 0;
            this.labelWeek.Text = "Week:";
            // 
            // comboBoxWeek
            // 
            this.comboBoxWeek.FormattingEnabled = true;
            this.comboBoxWeek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.comboBoxWeek.Location = new System.Drawing.Point(58, 21);
            this.comboBoxWeek.Name = "comboBoxWeek";
            this.comboBoxWeek.Size = new System.Drawing.Size(46, 21);
            this.comboBoxWeek.TabIndex = 1;
            this.comboBoxWeek.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeek_SelectedIndexChanged);
            // 
            // comboBoxMatch
            // 
            this.comboBoxMatch.FormattingEnabled = true;
            this.comboBoxMatch.Location = new System.Drawing.Point(58, 51);
            this.comboBoxMatch.Name = "comboBoxMatch";
            this.comboBoxMatch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMatch.TabIndex = 2;
            this.comboBoxMatch.Visible = false;
            // 
            // labelMatch
            // 
            this.labelMatch.AutoSize = true;
            this.labelMatch.Location = new System.Drawing.Point(13, 54);
            this.labelMatch.Name = "labelMatch";
            this.labelMatch.Size = new System.Drawing.Size(40, 13);
            this.labelMatch.TabIndex = 3;
            this.labelMatch.Text = "Match:";
            this.labelMatch.Visible = false;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(18, 92);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(32, 13);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "Start:";
            this.labelStart.Visible = false;
            // 
            // radioButtonHome
            // 
            this.radioButtonHome.AutoSize = true;
            this.radioButtonHome.Location = new System.Drawing.Point(126, 90);
            this.radioButtonHome.Name = "radioButtonHome";
            this.radioButtonHome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonHome.TabIndex = 5;
            this.radioButtonHome.TabStop = true;
            this.radioButtonHome.Text = "Home";
            this.radioButtonHome.UseVisualStyleBackColor = true;
            this.radioButtonHome.Visible = false;
            // 
            // radioButtonAway
            // 
            this.radioButtonAway.AutoSize = true;
            this.radioButtonAway.Location = new System.Drawing.Point(69, 90);
            this.radioButtonAway.Name = "radioButtonAway";
            this.radioButtonAway.Size = new System.Drawing.Size(51, 17);
            this.radioButtonAway.TabIndex = 6;
            this.radioButtonAway.TabStop = true;
            this.radioButtonAway.Text = "Away";
            this.radioButtonAway.UseVisualStyleBackColor = true;
            this.radioButtonAway.Visible = false;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(69, 117);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 7;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Visible = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 152);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.radioButtonAway);
            this.Controls.Add(this.radioButtonHome);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelMatch);
            this.Controls.Add(this.comboBoxMatch);
            this.Controls.Add(this.comboBoxWeek);
            this.Controls.Add(this.labelWeek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.ComboBox comboBoxWeek;
        private System.Windows.Forms.ComboBox comboBoxMatch;
        private System.Windows.Forms.Label labelMatch;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.RadioButton radioButtonHome;
        private System.Windows.Forms.RadioButton radioButtonAway;
        private System.Windows.Forms.Button buttonGo;
    }
}