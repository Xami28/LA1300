using movement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_1300_C
{
    public partial class levelOverview : Form
    {
        public levelOverview()
        {
            InitializeComponent();
        }
        public void properties()
        {
            this.Text = "Levelauswahl";
            this.Icon = Properties.Resources.game_icon;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Level01().Show();
            this.Hide();
        }

        private void enterLevel02_Click(object sender, EventArgs e)
        {
            new Level02().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Level03().Show();
            this.Hide();
        }

        private void enterLevel04_Click(object sender, EventArgs e)
        {
            new Level04().Show();
            this.Hide();
        }
    }
}
