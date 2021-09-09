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
        Initial _initial;
        Hitman2 _hitman2;
        HitmanContracts _hitman3;
        FontStorage fonts;

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
            fonts = XMLSerialization.ReadFromXMLFile<FontStorage>("HitmanStatisticsUber.xml");
            _hitman2cheats = new CheatsForms.CheatsHitman2();
            DisplayPanel.Controls.Add(_initial);
            if (fonts.DarkMode)
                setDark();
            else
                setNormal();
            darkToolStripMenuItem.Checked = fonts.DarkMode;
        }

        private void Menu_Game_H2_Click(object sender, EventArgs e)
        {
            setFormTo(2);
        }

        private void Menu_Game_HC_Click(object sender, EventArgs e)
        {
            setFormTo(3);
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

        public void setFormTo(int i)
        {
            if(i==2)
            {
                DisplayPanel.Controls.Clear();
                disposeOfUserControlsForms();
                _hitman2 = new Hitman2();
                if (fonts.DarkMode)
                    _hitman2.isDark(fonts);
                else
                    _hitman2.isNormal(fonts);
                SetSizeBecauseIDK(_hitman2.Size.Width, _hitman2.Size.Height);
                DisplayPanel.Controls.Add(_hitman2);
                gameNumber = 2;
            }
            else if(i==3)
            {
                DisplayPanel.Controls.Clear();
                disposeOfUserControlsForms();
                _hitman3 = new HitmanContracts();
                if (fonts.DarkMode)
                    _hitman3.isDark(fonts);
                else
                    _hitman3.isNormal(fonts);
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
                MainMenu.BackColor = Color.FromArgb(15, 15, 15);
                MainMenu.ForeColor = Color.WhiteSmoke;
                this.BackColor = Color.FromArgb(15, 15, 15);

                setDark();
            }
            else
            {
                MainMenu.BackColor = Control.DefaultBackColor;
                MainMenu.ForeColor = Control.DefaultForeColor;

                setNormal();
            }
        }

        private void RestartFont()
		{
            if (fonts.DarkMode)
                setDark();
            else
                setNormal();
		}

        private void setDark()
        {
            if (_hitman2 != null)
                _hitman2.isDark(fonts);
            else if (_hitman3 != null)
                _hitman3.isDark(fonts);
            else if (_initial != null)
                _initial.isDark();
            fonts.DarkMode = true;
        }

        private void setNormal()
        {
            if (_hitman2 != null)
                _hitman2.isNormal(fonts);
            else if (_hitman3 != null)
                _hitman3.isNormal(fonts);
            fonts.DarkMode = false;
        }

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            XMLSerialization.SaveObjectToXML(fonts, "HitmanStatisticsUber.xml");
        }

        private void levelNameFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            dialog.Font = fonts.MapName;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fonts.MapName = dialog.Font;
                RestartFont();
            }
        }

        private void timerTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            dialog.Font = fonts.TimerText;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fonts.TimerText = dialog.Font;
                RestartFont();
            }
        }

        private void timerFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            dialog.Font = fonts.LevelTime;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fonts.LevelTime = dialog.Font;
                RestartFont();
            }
        }

        private void valuesFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var dialog = new FontDialog();
            dialog.Font = fonts.ValuesFont;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fonts.ValuesFont = dialog.Font;
                RestartFont();
            }
        }

        private void valuesTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            dialog.Font = fonts.ValuesTextFont;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fonts.ValuesTextFont = dialog.Font;
                RestartFont();
            }
        }

		private void silentAssassinTextToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var dialog = new FontDialog();
            dialog.Font = fonts.SilentAssassin;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fonts.SilentAssassin = dialog.Font;
                RestartFont();
            }
        }
	}
}