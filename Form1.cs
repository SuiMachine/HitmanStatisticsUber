using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;

namespace HitmanStatistics
{
    public partial class Form1 : Form
    {
        Metronome _metronome;
        CheatsForms.CheatsHitman2 _hitman2cheats;
        CheatsForms.CheatsHitmanBloodMoney _hitmanbloodmoneycheats;
        Hitman2 _hitman2;
        HitmanContracts _hitman3;
        HitmanBloodMoney _hitmanbloodmoney;

        // Other variables.
        System.Text.Encoding enc = System.Text.Encoding.UTF8;

        public int gameNumber;


        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _metronome = new Metronome(this);
            _hitman2cheats = new CheatsForms.CheatsHitman2();
            _hitmanbloodmoneycheats = new CheatsForms.CheatsHitmanBloodMoney();
        }

        private void Menu_Game_H2_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();
            disposeOfUserControlsForms();
            _hitman2 = new Hitman2();
            DisplayPanel.Controls.Add(_hitman2);
            gameNumber = 2;
        }

        private void Menu_Game_HC_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();
            disposeOfUserControlsForms();
            _hitman3 = new HitmanContracts();
            DisplayPanel.Controls.Add(_hitman3);
            gameNumber = 3;
        }

        private void hitmanBloodMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();
            disposeOfUserControlsForms();
            _hitmanbloodmoney = new HitmanBloodMoney();
            DisplayPanel.Controls.Add(_hitmanbloodmoney);
            gameNumber = 4;
        }

        private void metronomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _metronome.setgamenumber(3);
            _metronome.SetDesktopLocation(this.DesktopLocation.X + 10, this.DesktopLocation.Y + 10);
            _metronome.ShowDialog();
        }

        private void silentAssassinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _hitman2cheats.SetDesktopLocation(this.DesktopLocation.X + 10, this.DesktopLocation.Y + 10);
            _hitman2cheats.ShowDialog();
        }

        private void bloodMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _hitmanbloodmoneycheats.SetDesktopLocation(this.DesktopLocation.X + 10, this.DesktopLocation.Y + 10);
            _hitmanbloodmoneycheats.ShowDialog();
        }

        private void disposeOfUserControlsForms()
        {
            if (_hitman2 != null)
                _hitman2.Dispose();
            if (_hitman3 != null)
                _hitman3.Dispose();
            if (_hitmanbloodmoney != null)
                _hitmanbloodmoney.Dispose();
        }
    }
}