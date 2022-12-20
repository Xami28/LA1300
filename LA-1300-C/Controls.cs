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
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
            properties();
        }
        public void properties()
        {
            this.Text = "Dinosaurier Spiel - v.0.0.3 - Controls";
            this.Icon = Properties.Resources.settings_icon;
        }
    }
}
