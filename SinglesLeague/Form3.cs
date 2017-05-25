using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinglesLeague
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBoxWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql s = new sql();
            List<string> home = new List<string>();
            List<string> away = new List<string>();
            
            List <string> combo= new List <string>();
            

            string q = "SELECT Home FROM abschedule WHERE Week = '" + comboBoxWeek.Text + "'";
            home = s.Select(q, "Home");

            q = "SELECT Away FROM abschedule WHERE Week ='" + comboBoxWeek.Text + "'";
            away = s.Select(q, "Away");

            
            
            for (int i = 0; i < home.Count; i++)
            {
                combo.Add ( away[i] + " @ " + home[i]);
            }
            comboBoxMatch.DataSource = combo;

            labelMatch.Visible = true;
            comboBoxMatch.Visible = true;
            labelStart.Visible = true;
            radioButtonAway.Visible = true;
            radioButtonHome.Visible = true;
            buttonGo.Visible = true;

            
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (radioButtonAway.Checked == true)
            {
                x = 1;
            }

            if (radioButtonHome.Checked == true)
            {
                x = 2;
            }

            int week = Convert.ToInt32(comboBoxWeek.Text);

            scoreBoard sb = new scoreBoard(comboBoxMatch.Text, x, week);
            sb.Show();
        }
    }
}
