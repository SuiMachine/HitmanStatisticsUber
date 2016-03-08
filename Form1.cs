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
        Initial _initial;
        Hitman2 _hitman2;
        HitmanContracts _hitman3;
        bool darkMode = false;

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
            _initial = new Initial(this);
            _metronome = new Metronome(this);
            _hitman2cheats = new CheatsForms.CheatsHitman2();
            _hitmanbloodmoneycheats = new CheatsForms.CheatsHitmanBloodMoney();
            DisplayPanel.Controls.Add(_initial);
        }

        private void Menu_Game_H2_Click(object sender, EventArgs e)
        {
            setFormTo(2);
        }

        private void Menu_Game_HC_Click(object sender, EventArgs e)
        {
            setFormTo(3);
        }

        private void hitmanBloodMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setFormTo(4);
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

        public void setFormTo(int i)
        {
            if(i==2)
            {
                DisplayPanel.Controls.Clear();
                disposeOfUserControlsForms();
                _hitman2 = new Hitman2();
                if (darkMode) _hitman2.isDark();
                else _hitman2.isNormal();
                SetSizeBecauseIDK(_hitman2.Size.Width, _hitman2.Size.Height);
                DisplayPanel.Controls.Add(_hitman2);
                gameNumber = 2;
            }
            else if(i==3)
            {
                DisplayPanel.Controls.Clear();
                disposeOfUserControlsForms();
                _hitman3 = new HitmanContracts();
                if (darkMode) _hitman3.isDark();
                else _hitman3.isNormal();
                SetSizeBecauseIDK(_hitman3.Size.Width, _hitman3.Size.Height);
                DisplayPanel.Controls.Add(_hitman3);
                gameNumber = 3;
            }
        }

        public void SetSizeBecauseIDK(int x, int y)
        {
            this.Width = x;
            this.Height = y+48;
        }

        private void disposeOfUserControlsForms()
        {
            if (_hitman2 != null)
                _hitman2.Dispose();
            if (_hitman3 != null)
                _hitman3.Dispose();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkToolStripMenuItem.Checked)
            {
                darkMode = true;
                MainMenu.BackColor = Color.FromArgb(15, 15, 15);
                MainMenu.ForeColor = Color.WhiteSmoke;
                this.BackColor = Color.FromArgb(15, 15, 15);

                setDark();
            }
            else
            {
                darkMode = false;
                MainMenu.BackColor = Control.DefaultBackColor;
                MainMenu.ForeColor = Control.DefaultForeColor;

                setNormal();
            }
        }

        private void setDark()
        {
            if (_hitman2 != null)
                _hitman2.isDark();
            else if (_hitman3 != null)
                _hitman3.isDark();
            else if (_initial != null)
                _initial.isDark();
        }

        private void setNormal()
        {
            if (_hitman2 != null)
                _hitman2.isNormal();
            else if (_hitman3 != null)
                _hitman3.isNormal();
        }
    }
}