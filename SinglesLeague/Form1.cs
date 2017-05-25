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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new SinglesLeague.Form2();
            form2.Show();
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new SinglesLeague.Form3();
            form3.Show();
        }
    }
}
