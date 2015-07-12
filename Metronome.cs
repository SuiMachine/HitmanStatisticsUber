using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace HitmanStatistics
{
    public partial class Metronome : Form
    {
        bool threesounds = false;
        static int s_Minute = 1000 * 60;
        int TickInterval = 200;
        //static int s_BPM_Hitman2 = s_Minute;
        static int s_BPM_HitmanContracts = 220;
        int bpm = s_BPM_HitmanContracts;
        Keys BPMToggleKey = Keys.X;
        int i = 0;
        int gamenumber = 0;
        ToolTip tip = new ToolTip();
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.sound1);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.sound2);
        SoundPlayer player3 = new SoundPlayer(Properties.Resources.sound4);

        bool timerRunning;
        bool settingInputKey;

        public Metronome(Form1 parent)
        {
            InitializeComponent();
        }
        
        public void setgamenumber(int number)
        {
            gamenumber = number;
        }

        private void Metronome_Load(object sender, EventArgs e)
        {
            InitHotkey();
            if (gamenumber == 2)
                RB_H2SA.Checked = true;
            else
                RB_HC.Checked = true;

            PlaySoundInterval.Interval = TickInterval;
        }

        private void RB_H2SA_CheckedChanged(object sender, EventArgs e)
        {
            //insert stuff for H2SA
        }

        private void RB_HC_CheckedChanged(object sender, EventArgs e)
        {
            int bpm = s_BPM_HitmanContracts;
            int TickInterval = s_Minute / s_BPM_HitmanContracts;
            PlaySoundInterval.Interval = TickInterval;
        }

        private void RB_CustomBPM_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_CustomBPM.Checked)
            {
                TB_CustomBPM.Enabled = true;
            }
            else
            {
                TB_CustomBPM.Enabled = false;
            }

        }

        public void InitHotkey()
        {
            if (!KeyGrabber.Hooked)
            {
                KeyGrabber.key.Clear();
                KeyGrabber.keyPressEvent += KeyGrabber_KeyPress;
                if (BPMToggleKey != Keys.None)
                    KeyGrabber.key.Add(BPMToggleKey);

                KeyGrabber.SetHook();
            }
            else
            {
                if (BPMToggleKey != Keys.None)
                {
                    KeyGrabber.key.Clear();
                    KeyGrabber.key.Add(BPMToggleKey);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (settingInputKey)
            {
                BPMToggleKey = keyData;
                B_UsedKey.Text = BPMToggleKey.ToString();
                B_UsedKey.Checked = false;
                InitHotkey();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void KeyGrabber_KeyPress(object sender, EventArgs e)
        {
            if (!timerRunning)
            {
                PlaySoundInterval.Start();
                timerRunning = true;
            }
            else
            {
                PlaySoundInterval.Stop();
                timerRunning = false;
            }
        }

        public void UnHook()
        {
            KeyGrabber.UnHook();
        }

        private void PlaySoundInterval_Tick(object sender, EventArgs e)
        {
            if(threesounds)
            {
                switch (i % 4)
                {
                    case 0:
                        player1.Play();
                        break;
                    case 1:
                        player2.Play();
                        break;
                    case 2:
                        player3.Play();
                        break;
                    case 3:
                        player2.Play();
                        break;
                }
                i++;
            }
            else
                player3.Play();
        }

        private void B_UsedKey_CheckedChanged(object sender, EventArgs e)
        {
            if(B_UsedKey.Checked)
            {
                settingInputKey = true;
                B_UsedKey.Text = "";
            }
            else
            {
                settingInputKey = false;
            }
        }

        private void TB_CustomBPM_TextChanged(object sender, EventArgs e)
        {
            var res = 500;
            if(int.TryParse(TB_CustomBPM.Text, out res))
            {
                if(res > 400)
                {
                    tip.Show("Value can't higher than 400", this, TB_CustomBPM.Location.X, TB_CustomBPM.Location.Y + 75, 1000);
                }
                else if(res<50)
                {
                    tip.Show("Value can't be lower than 50", this, TB_CustomBPM.Location.X, TB_CustomBPM.Location.Y+75, 1000);
                }
                else
                {
                    bpm = res;
                    TickInterval = s_Minute / bpm;
                    PlaySoundInterval.Interval = TickInterval;
                }
            }
        }

        private void Metronome_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
            PlaySoundInterval.Stop();
        }

        private void Metronome_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void R2_OneSound_CheckedChanged(object sender, EventArgs e)
        {
            threesounds = false;
        }

        private void R2_ThreeSound_CheckedChanged(object sender, EventArgs e)
        {
            threesounds = true;
        }
    }
}
