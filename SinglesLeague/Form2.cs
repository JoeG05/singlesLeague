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

            TextBox[] scored = { };
            int scoredTotal = 0;

            TextBox[] thrown = { };
            int thrownTotal = 0;

            TextBox[] allstars = { };
            int allstarsTotal = 0;

            int wins = 0;
            int losses = 0;
            int week = Convert.ToInt32(textBoxWeek.Text);
            string name = comboBox1.Text;

            for (int i = 0; i < 7; i++)
            {
                scoredTotal += Convert.ToInt32(scored[i]);
                thrownTotal += Convert.ToInt32(thrown[i]);
                allstarsTotal += Convert.ToInt32(allstars[i]);

                if (Convert.ToInt32(scored[i]) == 0)
                    wins++;

            }

            this.Close();
        }
    }
}
