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
    public partial class HitmanBloodMoney : UserControl
    {
        const int baseAddress = 0x00400000;

        // Dictionary used to convert the raw map names into easily readable names and a map number to access the second offsets declared previously.
        Dictionary<string, Tuple<string, int>> mapValues = new Dictionary<string, Tuple<string, int>>() {
            { "00_main.", new Tuple<string, int>("Death of a Showman", 1) },          { "01_main.", new Tuple<string, int>("Vintage Year", 2) },     { "03_main.", new Tuple<string, int>("Curtains Down", 3) },     { "04_main.", new Tuple<string, int>("Flatline", 4) },             { "05_main.", new Tuple<string, int>("A New Life", 5) },
            { "06_main.", new Tuple<string, int>("The Murder of Crows", 6) },         { "02_main.", new Tuple<string, int>("You Better Watch Out", 7) },   { "08_main.", new Tuple<string, int>("Death of the Mississippi", 8) },      { "09_main.", new Tuple<string, int>("Till Death Do Us Part", 9) },         { "10_main.", new Tuple<string, int>("The House of Cards", 10) },
            { "11_main.", new Tuple<string, int>("Dance with the Devil", 11) },   { "12_main.", new Tuple<string, int>("Amendment XXV", 12) },   { "13_main.", new Tuple<string, int>("Requiem", 13)}, { "ut/hideo", new Tuple<string, int>("WHAT THE FUCK?!", 99)}};


        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Image imgSA, imgNotSA;
        Process[] myProcess;
        String mapName;
        float missionTime;
        bool isMissionActive;
        string gameName;
        public int gameNumber;
        bool isSA;
        int mapNumber, nbTargetKills, nbGatorGangKills, nbGuardKills1, nbGuardKills2, nbCivilianKills, nbShotsFired, nbShotsHit, nbCloseCombatKills, nbGuardsHarmed, nbCiviliansHarmed, nbAccidents, nbHeadshots, nbBodiesFoundTarget, nbBodiesFoundNonTarget, nbCoversBlown, nbWitnesses, nbSeenByACamera;
        int nbGatorGangKills_zero = 0;

        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public HitmanBloodMoney()
        {
            InitializeComponent();
            imgSA = Properties.Resources.Yes;
            imgNotSA = Properties.Resources.No;
            gameName = "H:BM";
            ResetValues();
            NB_Witnessess.ForeColor = Color.Gray;
        }
        /*------------------
        -- MEMORY READING --
        ------------------*/
        private void OccasionalProcessCheck_Tick(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName("HitmanBloodMoney");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Attempt to find if the game is currently running
            if (myProcess == null || myProcess.Length == 0)
            {
                OccasionalProcessCheck.Stop();
                myProcess = Process.GetProcessesByName("HitmanBloodMoney");

                if (myProcess.Length != 0)
                {
                    LB_Running.Text = gameName + " IS RUNNING";
                    LB_Running.ForeColor = Color.Green;
                    OccasionalProcessCheck.Start();
                    Timer.Interval = 50;
                }
            }

            if (myProcess.Length != 0)
            {
                // Reading the raw name of the current mission as an array of bytes and converting it to a string.
                byte[] mapBytes = null;
                mapBytes = BitConverter.GetBytes(Trainer.ReadPointerDouble(myProcess, baseAddress + 0x000BF8E0, new int[2] { 0x7b8, 0x65c }));
                    
                string mapBytesStr = enc.GetString(mapBytes);
                
                if (mapValues.ContainsKey(mapBytesStr))
                {
                    // Get the clean mission name and the mission number frm the dictionary
                    isMissionActive = true;
                    mapName = mapValues[mapBytesStr].Item1;
                    mapNumber = mapValues[mapBytesStr].Item2;
                }
                else if("nbloodmo" == mapBytesStr)
                {
                    // The mission name isn't included in the dictionary, meaning that a mission is not active at this moment
                    // The current screen is something like the main menu, the briefing or a cutscene
                    isMissionActive = false;
                }

                if (isMissionActive)
                {
                    //Reading timer
                    missionTime = Trainer.ReadPointerFloat(myProcess, baseAddress + 0x038544, new int[4] { 0x354, 0xc, 0x58, 0xc });
                    LB_Time.Text = ((int)missionTime / 60).ToString("D2") + ":" + (missionTime % 60).ToString("00.000");
                    //Rest of stuff
                    nbTargetKills = Trainer.ReadInteger(myProcess, baseAddress + 0x5B25A4);
                    nbGuardKills1 = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2578);
                    nbGuardKills2 = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2588);
                    nbCivilianKills = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2590);
                    //nbGuardsHarmed = Trainer.ReadInteger(myProcess, baseAddress + 0x5B258C);
                    //nbCiviliansHarmed = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2594);
                    nbShotsFired = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2554);
                    nbShotsHit = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2558);
                    nbCloseCombatKills = Trainer.ReadInteger(myProcess, baseAddress + 0x5B25B0);
                    nbAccidents = Trainer.ReadInteger(myProcess, baseAddress + 0x5B256C);
                    nbHeadshots = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2560);
                    nbBodiesFoundTarget = Trainer.ReadInteger(myProcess, baseAddress + 0x5B260C);
                    nbBodiesFoundNonTarget = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2608);
                    nbCoversBlown = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2614);
                    nbWitnesses = Trainer.ReadInteger(myProcess, baseAddress + 0x5B2574);
                    nbSeenByACamera = Trainer.ReadByte(myProcess, baseAddress + 0x5B2624);
                    isSA = isSilentAssassinYet();

                    // Checking if the actual rating is SA according to the current stats

                    if (isSA)
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
                    if (!(mapName == "Death of the Mississippi" || mapName == "Till Death Do Us Part"))
                        NB_TotalKills.Text = (nbTargetKills + nbGuardKills1 + nbGuardKills2 + nbCivilianKills).ToString();
                    else
                    {
                        if (missionTime == 0)
                            nbGatorGangKills_zero = nbGatorGangKills;
                        nbGatorGangKills = Trainer.ReadInteger(myProcess, baseAddress + 0x5B304C);
                        NB_TotalKills.Text = (nbTargetKills + nbGuardKills1 + nbGuardKills2 + nbCivilianKills + (nbGatorGangKills - nbGatorGangKills_zero)).ToString();
                    }
                    NB_ShotsFired.Text = nbShotsFired.ToString();
                    NB_CloseEncounterKills.Text = nbCloseCombatKills.ToString();
                    NB_ShotsHit.Text = nbShotsHit.ToString();
                    //NB_EnemiesHarmed.Text = nbGuardsHarmed.ToString();
                    //NB_CiviliansHarmed.Text = nbCiviliansHarmed.ToString();
                    NB_Accidents.Text = nbAccidents.ToString();
                    NB_Headshots.Text = nbHeadshots.ToString();
                    NB_BodiesFound.Text = (nbBodiesFoundTarget + nbBodiesFoundNonTarget).ToString();
                    NB_CoversBlown.Text = nbCoversBlown.ToString();
                    NB_Witnessess.Text = nbWitnesses.ToString();
                    
                    if (nbSeenByACamera == 0)
                    {
                        NB_SeenByACamera.Text = "0";
                    }
                    else
                        NB_SeenByACamera.Text = "1";
                }
                else
                {
                    // No mission is active, reseting values
                    ResetValues();
                }
            }
            else
                ResetGame();
        }

        // Used to reset the current game
        private void ResetGame()
        {
            LB_Running.Text = gameName + " IS NOT RUNNING";
            LB_Running.ForeColor = Color.Red;
            Timer.Interval = 500;
            ResetValues();
        }

        private void ResetValues()
        {
            isMissionActive = false;
            LB_Time.Text = "00:00,000";

            LB_MapName.Text = "No mission currently running";
        }

        bool isSilentAssassinYet()
        {
            bool sarating;
            if (nbSeenByACamera != 0 || nbCoversBlown != 0 || nbGuardKills1 != 0 || nbGuardKills2 != 0 || nbCivilianKills != 0 || nbGuardsHarmed != 0 || nbCiviliansHarmed != 0)
                sarating = false;
            else
                sarating = true;

            return sarating;
        }
    }
}
