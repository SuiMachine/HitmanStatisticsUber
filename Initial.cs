using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HitmanStatistics
{
    public partial class Initial : UserControl
    {
        Form1 _main;
        public Initial(Form1 _parent)
        {
            _main = _parent;
            InitializeComponent();
        }

        private void B_Hitman2_Click(object sender, EventArgs e)
        {
            _main.setFormTo(2);
        }

        private void B_HitmanContracts_Click(object sender, EventArgs e)
        {
            _main.setFormTo(3);
        }

        private void B_HitmanBloodMoney_Click(object sender, EventArgs e)
        {
            _main.setFormTo(4);
        }
    }
}
