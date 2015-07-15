using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HitmanStatistics
{
    public partial class HitmanContracts : UserControl
    {
        const int baseAddress = 0x00400000;

        SACombination[] validSACombinationHC = {
            new SACombination(999, 0, 999, 1, 0, 0, 0, 0),  new SACombination(2, 1, 1, 0, 0, 0, 0, 0), new SACombination(2, 1, 0, 0, 0, 1, 0, 0), new SACombination(2, 0, 1, 1, 0, 1, 0, 0), new SACombination(2, 0, 0, 0, 0, 2, 0, 0), new SACombination(1, 1, 1, 0, 0, 2, 0, 0),
            new SACombination(1, 1, 0, 0, 1, 0, 0, 0),      new SACombination(1, 1, 0, 0, 0, 3, 0, 0), new SACombination(1, 0, 1, 1, 1, 0, 0, 0), new SACombination(1, 0, 1, 1, 0, 3, 0, 0), new SACombination(1, 0, 0, 1, 1, 1, 0, 0),
            new SACombination(1, 0, 0, 1, 0, 4, 0, 0),      new SACombination(0, 1, 0, 0, 1, 2, 0, 0), new SACombination(0, 1, 0, 0, 0, 5, 0, 0), new SACombination(0, 0, 0, 1, 1, 3, 0, 0), new SACombination(0, 0, 0, 1, 2, 0, 0, 0),
            new SACombination(0, 0, 0, 1, 0, 6, 0, 0)};

        // Dictionary used to convert the raw map names into easily readable names and a map number to access the second offsets declared previously.
        Dictionary<string, Tuple<string, int>> mapValues = new Dictionary<string, Tuple<string, int>>() {
            { "C01-1_MA", new Tuple<string, int>("Asylum Aftermath", 1) },          { "C01-2_MA", new Tuple<string, int>("The Meat King's Party", 2) },     { "C02-1_MA", new Tuple<string, int>("The Bjarkhov Bomb", 3) },     { "C03-1_MA", new Tuple<string, int>("Beldingford Manor", 4) },             { "C06-1_MA", new Tuple<string, int>("Rendezvous in Rotterdam", 5) },
            { "C06-2_MA", new Tuple<string, int>("Deadly Cargo", 6) },              { "C07-1_MA", new Tuple<string, int>("Traditions of the Trade", 7) },   { "C08-1_MA", new Tuple<string, int>("Slaying a Dragon", 8) },      { "C08-2_MA", new Tuple<string, int>("The Wang Fou Incident", 9) },         { "C08-3_MA", new Tuple<string, int>("The Seafood Massacre", 10) },
            { "C08-4_MA", new Tuple<string, int>("Lee Hong Assassination", 11) },   { "C09-1_MA", new Tuple<string, int>("Hunter and Hunted", 12) }};

        // Map pointers for HC
        Pointer[] HCmapPointers = {
            new Pointer(0x00393D58, new int[2] { 0x234, 0xBDE }), new Pointer(0x00394598, new int[3] { 0x10, 0x194, 0xC0E }), new Pointer(0x00394598, new int[2] { 0x214, 0xC0E }), new Pointer(0x00394578, new int[2] { 0x1EC0, 0x49FA }), new Pointer(0x00394578, new int[3] { 0x1E00, 0xBC, 0x49FA }), new Pointer(0x00394578, new int[4] { 0x1D80, 0x7C, 0xBC, 0x49FA }),
            new Pointer(0x00394578, new int[5] { 0x1D00, 0x7C, 0x7C, 0xBC, 0x49FA }), new Pointer(0x0039457C, new int[2] { 0x1E40, 0x49FA }), new Pointer(0x0039457C, new int[3] { 0x1D80, 0xBC, 0x49FA }), new Pointer(0x0039457C, new int[4] { 0x1D00, 0x7C, 0xBC, 0x49FA }), new Pointer(0x0039457C, new int[5] { 0x1C80, 0x7C, 0x7C, 0xBC, 0x49FA })};

        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Image imgSA, imgNotSA;
        Process[] myProcess;
        String mapName;
        float missionTime;
        bool isMissionActive;
        string gameName;
        public int gameNumber;
        int mapNumber, nbShotsFired, nbCloseEncounters, nbHeadshots, nbAlerts, nbEnemiesK, nbEnemiesH, nbInnocentsK, nbInnocentsH, currentShotsFired, HCpointerNumber;
        

        public HitmanContracts()
        {
            InitializeComponent();
            imgSA = Properties.Resources.Yes;
            imgNotSA = Properties.Resources.No;
            currentShotsFired = 0;
            HCpointerNumber = 0;
            gameName = "HC";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Attempt to find if the game is currently running.
            myProcess = Process.GetProcessesByName("HitmanContracts");

            if (myProcess.Length != 0)
            {
                // The game is running, ready for memory reading.
                LB_Running.Text = gameName + " IS RUNNING";
                LB_Running.ForeColor = Color.Green;
                isMissionActive = true;

                // Reading the raw name of the current mission as an array of bytes and converting it to a string.
                byte[] mapBytes = null;

                mapBytes = BitConverter.GetBytes(Trainer.ReadPointerDouble("HitmanContracts", baseAddress + HCmapPointers[HCpointerNumber].address, HCmapPointers[HCpointerNumber].offsets));

                string mapBytesStr = enc.GetString(mapBytes);

                try
                {
                    // Trying to get the clean mission name and the mission number from the dictionary.
                    mapName = mapValues[mapBytesStr].Item1;
                    mapNumber = mapValues[mapBytesStr].Item2;
                }
                catch (KeyNotFoundException)
                {
                    // The mission name isn't included in the dictionary, meaning that a mission is not active at this moment.
                    // The current screen is something like the main menu, the briefing or a cutscene.
                    isMissionActive = false;
                    currentShotsFired = 0;

                    HCpointerNumber++;
                    if (HCpointerNumber > 10)
                        HCpointerNumber = 0;
                }

                if (isMissionActive) // A mission is currently active, ready to read memory.
                {
                    //Reading timer
                    missionTime = Trainer.ReadPointerFloat("HitmanContracts", baseAddress + 0x0039457C, new int[1] { 0x24 });
                    LB_Time.Text = ((int)missionTime / 60).ToString("D2") + ":" + (missionTime % 60).ToString("00.000");
                    //Rest of stuff
                    nbShotsFired = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947B0, new int[3] { 0xBA0, 0x104, 0x82F });
                    nbCloseEncounters = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947C0, new int[1] { 0xB2F });
                    nbHeadshots = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947C0, new int[1] { 0xB17 });
                    nbAlerts = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947C0, new int[1] { 0xB2B });
                    nbEnemiesK = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947C0, new int[1] { 0xB1F });
                    nbEnemiesH = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947C0, new int[1] { 0xB1B });
                    nbInnocentsK = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947C0, new int[1] { 0xB27 });
                    nbInnocentsH = Trainer.ReadPointerInteger("HitmanContracts", baseAddress + 0x003947C0, new int[1] { 0xB23 });
                    NB_ShotsFired.Text = nbShotsFired.ToString();

                    // Checking if the actual rating is SA according to the current stats
                    if (SilentAssassin())
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
                    NB_CloseEncounters.Text = nbCloseEncounters.ToString();
                    NB_Headshots.Text = nbHeadshots.ToString();
                    NB_Alerts.Text = nbAlerts.ToString();
                    NB_EnemiesKilled.Text = nbEnemiesK.ToString();
                    NB_EnemiesHarmed.Text = nbEnemiesH.ToString();
                    NB_InnocentsKilled.Text = nbInnocentsK.ToString();
                    NB_InnocentsHarmed.Text = nbInnocentsH.ToString();
                }
                else // No mission is active, reseting values.
                {
                    ResetValues();
                }
            }
            else
            {
                // The game process has not been found, reseting values.
                LB_Running.Text = gameName + " IS NOT RUNNING";
                LB_Running.ForeColor = Color.Red;
                ResetValues();
            }
        }

        private void ResetValues()
        {
            LB_Time.Text = "00:00,000";

            LB_MapName.Text = "No mission currently";
            NB_ShotsFired.Text = "0";
            NB_CloseEncounters.Text = "0";
            NB_Headshots.Text = "0";
            NB_Alerts.Text = "0";
            NB_EnemiesKilled.Text = "0";
            NB_EnemiesHarmed.Text = "0";
            NB_InnocentsKilled.Text = "0";
            NB_InnocentsHarmed.Text = "0";

            if (IMG_SA.BackgroundImage != imgSA)
            {
                IMG_SA.BackgroundImage = imgSA;
                LB_SilentAssassin.ForeColor = Color.Green;
            }
        }

        private bool SilentAssassin()
        {
            SACombination[] validSACombination = null;
            validSACombination = validSACombinationHC;

            // Checking every possible SA combination
            foreach (SACombination combination in validSACombination)
            {
                // If all the current values are equal or inferior to a valid combination, the rating is SA
                if (combination.isSACombination(currentShotsFired, nbCloseEncounters, nbHeadshots, nbAlerts, nbEnemiesK, nbEnemiesH, nbInnocentsK, nbInnocentsH))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
