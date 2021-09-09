using System;
using System.Drawing;
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

        public void isDark()
        {
            this.BackColor = Color.FromArgb(15, 15, 15);
            this.label1.ForeColor = Color.Silver;
            this.B_Hitman2.BackColor = Color.FromArgb(30, 30, 30);
            this.B_Hitman2.ForeColor = Color.Red;
            this.B_Hitman2.FlatStyle = FlatStyle.Flat;
            this.B_HitmanContracts.BackColor = Color.FromArgb(30, 30, 30);
            this.B_HitmanContracts.ForeColor = Color.Red;
            this.B_HitmanContracts.FlatStyle = FlatStyle.Flat;
        }
    }
}
