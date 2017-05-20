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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            sql s = new sql();

            TextBox[] left = { left1, left2, left3, left4, left5, left6, left7 };
            int scoredTotal = 0;

            TextBox[] thrown = { thrown1, thrown2, thrown3, thrown4, thrown5, thrown6, thrown7 };
            int thrownTotal = 0;

            TextBox[] allstars = { allstars1, allstars2, allstars3, allstars4, allstars5, allstars6, allstars7 };
            int allstarsTotal = 0;

            int wins = 0;
            int losses = 0;

            if (textBoxWeek.Text == "")
            {
                MessageBox.Show("Week required.");
                return;
            }

            int week = Convert.ToInt32(textBoxWeek.Text);
            string name = comboBox1.Text;
            if (name == "")
            {
                MessageBox.Show("Player required.");
                return;
            }
            
            int j = 1;

            foreach(var x in left)
            {
                if (x.Text == "")
                {
                    MessageBox.Show("Required value missing in leg " + j);
                    return;
                }

                j++;
                
            }

            j = 1;
            foreach (var x in thrown)
            {
                if (x.Text == "")
                {
                    MessageBox.Show("Required value missing in leg " + j);
                    return;
                }
                j++;
               
            }
            
            for (int i = 0; i < 7; i++)
            {

                int scored = 501 - Convert.ToInt32(left[i].Text);
                scoredTotal += scored;

                thrownTotal += Convert.ToInt32(thrown[i].Text);

                if (allstars[i].Text != "")
                    allstarsTotal += Convert.ToInt32(allstars[i].Text);

                if (Convert.ToInt32(left[i].Text) == 0)
                    wins++;

            }
            losses = 7 - wins;

            string q = "INSERT INTO cdstats (Week, Name, W, L, scored, thrown, Allstars) VALUES ('" + week + "', '"
                + name + "', '" + wins + "', '" + losses + "', '" + scoredTotal + "', '" + thrownTotal + "', '" + allstarsTotal + "')";
            //s.Insert(q);

            MessageBox.Show("");
            this.Close();
        }
    }
}
