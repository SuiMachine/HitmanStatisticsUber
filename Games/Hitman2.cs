using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;

namespace HitmanStatistics
{
    public partial class Hitman2 : UserControl
    {
        const int baseAddress = 0x00400000;

        // All the possible Silent Assassin combinations for Hitman 2
        SACombination[] validSACombinationH2 = {
            new SACombination(0, 1, 0, 0, 1, 2, 0, 0), new SACombination(0, 1, 0, 0, 0, 5, 0, 0), new SACombination(0, 1, 0, 0, 0, 2, 0, 1), new SACombination(0, 0, 0, 1, 2, 0, 0, 0), new SACombination(0, 0, 0, 1, 1, 3, 0, 0), 
            new SACombination(0, 0, 0, 1, 1, 0, 0, 1), new SACombination(0, 0, 0, 1, 0, 6, 0, 0), new SACombination(0, 0, 0, 1, 0, 3, 0, 1), new SACombination(0, 0, 0, 1, 0, 0, 1, 0), new SACombination(0, 0, 0, 1, 0, 0, 0, 2), 
            new SACombination(0, 0, 0, 0, 1, 0, 0, 1), new SACombination(1, 1, 1, 0, 0, 2, 0, 0), new SACombination(1, 1, 0, 0, 1, 0, 0, 0), new SACombination(1, 1, 0, 0, 0, 3, 0, 0), new SACombination(1, 1, 0, 0, 0, 0, 0, 1),
            new SACombination(1, 0, 1, 1, 1, 0, 0, 0), new SACombination(1, 0, 1, 1, 0, 3, 0, 0), new SACombination(1, 0, 1, 1, 0, 0, 0, 1), new SACombination(1, 0, 0, 1, 1, 1, 0, 0), new SACombination(1, 0, 0, 1, 0, 4, 0, 0),
            new SACombination(1, 0, 0, 1, 0, 1, 0, 1), new SACombination(1, 0, 0, 0, 1, 1, 0, 0), new SACombination(2, 1, 1, 0, 0, 0, 0, 0), new SACombination(2, 1, 0, 0, 0, 1, 0, 0), new SACombination(2, 0, 2, 1, 0, 0, 0, 0),
            new SACombination(2, 0, 1, 1, 0, 1, 0, 0), new SACombination(3, 0, 0, 1, 0, 0, 0, 0)};

        // Most values are accessed with 3-levels pointers and the second offset is different depending on the current mission.
        // All second offsets are stored here to be accessed according to the correct mission.
        int[] secondOffset = { 0x838, 0xB24, 0x8A0, 0x138, 0xB88, 0xBB8, 0xB48, 0xCE8, 0x136C, 0xAD0, 0xF50, 0x8D4, 0x9EC, 0x400, 0x9EC, 0x644, 0xB08, 0x96C, 0xB00, 0x8 };

        // Dictionary used to convert the raw map names into easily readable names and a map number to access the second offsets declared previously.
        Dictionary<string, Tuple<string, int>> mapValues = new Dictionary<string, Tuple<string, int>>() {
            // Hitman 2
            { "C1-1__MA", new Tuple<string, int>("Anathema", 1) },                  { "C2-1__MA", new Tuple<string, int>("St. Petersburg Stakeout", 2) },   { "C2-2__MA", new Tuple<string, int>("Kirov Park Meeting", 3) },    { "C2-3__MA", new Tuple<string, int>("Tubeway Torpedo", 4) },               { "C2-4__MA", new Tuple<string, int>("Invitation to a Party", 5) },
            { "C3-1__MA", new Tuple<string, int>("Tracking Hayamoto", 6) },         { "\\C3-2a__", new Tuple<string, int>("Hidden Valley", 7) },            { "\\C3-2b__", new Tuple<string, int>("At the Gates", 8) },         { "C3-3__MA", new Tuple<string, int>("Shogun Showdown", 9) },               { "C4-1__MA", new Tuple<string, int>("Basement Killing", 10) },
            { "C4-2__MA", new Tuple<string, int>("The Graveyard Shift", 11) },      { "C4-3__MA", new Tuple<string, int>("The Jacuzzi Job", 12) },          { "C5-1__MA", new Tuple<string, int>("Murder At The Bazaar", 13) }, { "C5-2__MA", new Tuple<string, int>("The Motorcade Interception", 14) },   { "C5-3__MA", new Tuple<string, int>("Tunnel Rat", 15) },
            { "C6-1__MA", new Tuple<string, int>("Temple City Ambush", 16) },       { "C6-2__MA", new Tuple<string, int>("The Death of Hannelore", 17) },   { "C6-3__MA", new Tuple<string, int>("Terminal Hospitality", 18) }, { "C7-1__MA", new Tuple<string, int>("St. Petersburg Revisited", 19) },     { "C8-1__MA", new Tuple<string, int>("Redemption at Gontranno", 20) }};


        // Other variables.
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Image imgSA, imgNotSA;
        Process[] myProcess;
        String mapName;
        float missionTime;
        bool isMissionActive;
        string gameName;
        int mapNumber, nbShotsFired, nbCloseEncounters, nbHeadshots, nbAlerts, nbEnemiesK, nbEnemiesH, nbInnocentsK, nbInnocentsH;


        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public Hitman2()
        {
            InitializeComponent();
            imgSA = Properties.Resources.Yes;
            imgNotSA = Properties.Resources.No;
            gameName = "H2: SA";
            ResetValues();
        }

        /*------------------
        -- MEMORY READING --
        ------------------*/
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Attempt to find if the game is currently running
            if (myProcess == null || myProcess.Length == 0)
            {
                myProcess = Process.GetProcessesByName("hitman2");

                if (myProcess.Length != 0)
                {
                    LB_Running.Text = gameName + " IS RUNNING";
                    LB_Running.ForeColor = Color.Green;
                    Timer.Interval = 50;
                }
            }

            if (myProcess.Length != 0)
            {
                // Reading the raw name of the current mission as an array of bytes and converting it to a string
                byte[] mapBytes = null;

                mapBytes = BitConverter.GetBytes(Trainer.ReadPointerDouble(myProcess, baseAddress + 0x2A6C5C, new int[2] { 0x98, 0xBC7 }));


                string mapBytesStr = enc.GetString(mapBytes);

                if (mapBytesStr == "\0\0\0\0\0\0\0\0")
                {
                    // The game is no longer running
                    ResetGame();
                }
                else if (mapValues.ContainsKey(mapBytesStr))
                {
                    // Get the clean mission name and the mission number from the dictionary
                    isMissionActive = true;
                    mapName = mapValues[mapBytesStr].Item1;
                    mapNumber = mapValues[mapBytesStr].Item2;
                }
                else
                {
                    // The mission name isn't included in the dictionary, meaning that a mission is not active at this moment
                    // The current screen is something like the main menu, the briefing or a cutscene
                    isMissionActive = false;
                }

                if (isMissionActive)
                {
                    // A mission is currently active, ready to read memory
                    // Reading the timer
                    missionTime = Trainer.ReadPointerFloat(myProcess, baseAddress + 0x2A6C5C, new int[1] { 0x24 });

                    // Reading every other value if the mission has started
                    if (missionTime > 0)
                    {
                        nbShotsFired = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x39419, new int[2] { 0xBD, 0x11C7 });
                        nbCloseEncounters = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x220 });
                        nbHeadshots = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x208 });
                        nbAlerts = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x21C });
                        nbEnemiesK = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x210 });
                        nbEnemiesH = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x20C });
                        nbInnocentsK = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x218 });
                        nbInnocentsH = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x214 });
                    }

                    // Checking if the actual rating is SA according to the current stats
                    if (IsSilentAssassin())
                    {
                        IMG_SA.BackgroundImage = imgSA;
                        LB_SilentAssassin.ForeColor = Color.Green;
                    }
                    else
                    {
                        IMG_SA.BackgroundImage = imgNotSA;
                        LB_SilentAssassin.ForeColor = Color.Red;
                    }

                    // Displaying the values
                    LB_MapName.Text = "#" + mapNumber + " " + mapName;
                    LB_Time.Text = ((int)missionTime / 60).ToString("D2") + ":" + (missionTime % 60).ToString("00.000");
                    NB_ShotsFired.Text = nbShotsFired.ToString();
                    NB_CloseEncounters.Text = nbCloseEncounters.ToString();
                    NB_Headshots.Text = nbHeadshots.ToString();
                    NB_Alerts.Text = nbAlerts.ToString();
                    NB_EnemiesKilled.Text = nbEnemiesK.ToString();
                    NB_EnemiesHarmed.Text = nbEnemiesH.ToString();
                    NB_InnocentsKilled.Text = nbInnocentsK.ToString();
                    NB_InnocentsHarmed.Text = nbInnocentsH.ToString();
                }
                else
                {
                    // No mission is active, reseting values
                    ResetValues();
                }
            }
        }


        // Used to reset the current game
        private void ResetGame()
        {
            myProcess = null;
            LB_Running.Text = gameName + " IS NOT RUNNING";
            LB_Running.ForeColor = Color.Red;
            Timer.Interval = 500;
            ResetValues();
        }


        // Called when the game is not running or no mission is active.
        // Used to reset all the values.
        private void ResetValues()
        {
            isMissionActive = false;
            LB_MapName.Text = "No mission currently";
            missionTime = 0;
            LB_Time.Text = "00:00,000";
            nbShotsFired = 0;
            NB_ShotsFired.Text = "0";
            nbCloseEncounters = 0;
            NB_CloseEncounters.Text = "0";
            nbHeadshots = 0;
            NB_Headshots.Text = "0";
            nbAlerts = 0;
            NB_Alerts.Text = "0";
            nbEnemiesK = 0;
            NB_EnemiesKilled.Text = "0";
            nbEnemiesH = 0;
            NB_EnemiesHarmed.Text = "0";
            nbInnocentsK = 0;
            NB_InnocentsKilled.Text = "0";
            nbInnocentsH = 0;
            NB_InnocentsHarmed.Text = "0";

            if (IMG_SA.BackgroundImage != imgSA)
            {
                IMG_SA.BackgroundImage = imgSA;
                LB_SilentAssassin.ForeColor = Color.Green;
            }
        }

        // Used to check if the actual rating is Silent Assassin
        private bool IsSilentAssassin()
        {
            SACombination[] validSACombination = null;
            validSACombination = validSACombinationH2;
            
            // Checking every possible SA combination
            foreach (SACombination combination in validSACombination)
            {
                // If all the current values are equal or inferior to a valid combination, the rating is SA
                if (combination.isSACombination(nbShotsFired, nbCloseEncounters, nbHeadshots, nbAlerts, nbEnemiesK, nbEnemiesH, nbInnocentsK, nbInnocentsH))
                {
                    return true;
                }
            }
            return false;
        }

        public void isDark()
        {
            this.BackColor = Color.FromArgb(15, 15, 15);
            this.LB_MapName.ForeColor = Color.Silver;
            this.LB_Time.ForeColor = Color.WhiteSmoke;
            this.LB_Timer.ForeColor = Color.DarkRed;

            this.LB_ShotsFired.ForeColor = Color.WhiteSmoke;
            this.LB_CloseEncounters.ForeColor = Color.WhiteSmoke;
            this.LB_Headshots.ForeColor = Color.WhiteSmoke;
            this.LB_Alerts.ForeColor = Color.WhiteSmoke;
            this.LB_EnemiesKilled.ForeColor = Color.WhiteSmoke;
            this.LB_EnemiesHarmed.ForeColor = Color.WhiteSmoke;
            this.LB_InnocentsHarmed.ForeColor = Color.WhiteSmoke;
            this.LB_InnocentsKilled.ForeColor = Color.WhiteSmoke;

            this.NB_ShotsFired.ForeColor = Color.DarkRed;
            this.NB_CloseEncounters.ForeColor = Color.DarkRed;
            this.NB_Headshots.ForeColor = Color.DarkRed;
            this.NB_Alerts.ForeColor = Color.DarkRed;
            this.NB_EnemiesKilled.ForeColor = Color.DarkRed;
            this.NB_EnemiesHarmed.ForeColor = Color.DarkRed;
            this.NB_InnocentsHarmed.ForeColor = Color.DarkRed;
            this.NB_InnocentsKilled.ForeColor = Color.DarkRed;
        }
    }
}
