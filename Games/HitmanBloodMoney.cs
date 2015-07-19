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

        Dictionary<string, Tuple<string, int>> mapValues = new Dictionary<string, Tuple<string, int>>() {
            { "00_main.", new Tuple<string, int>("Death of a Showman", 1) },          { "01_main.", new Tuple<string, int>("Vintage Year", 2) },     { "03_main.", new Tuple<string, int>("Curtains Down", 3) },     { "04_main.", new Tuple<string, int>("Flatline", 4) },             { "05_main.", new Tuple<string, int>("A New Life", 5) },
            { "06_main.", new Tuple<string, int>("The Murder of Crows", 6) },         { "02_main.", new Tuple<string, int>("You Better Watch Out", 7) },   { "08_main.", new Tuple<string, int>("Death of the Mississippi", 8) },      { "09_main.", new Tuple<string, int>("Till Death Do Us Part", 9) },         { "10_main.", new Tuple<string, int>("The House of Cards", 10) },
            { "11_main.", new Tuple<string, int>("Dance with the Devil", 11) },   { "12_main.", new Tuple<string, int>("Amendment XXV", 12) },   { "13_main.", new Tuple<string, int>("Requiem", 13) }};


        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Image imgSA, imgNotSA;
        Process[] myProcess;
        String mapName;
        float missionTime;
        bool isMissionActive;
        string gameName="H:BM";
        public int gameNumber;
        int mapNumber, nbTargetKills, nbGatorGangKills, nbGuardKills1, nbGuardKills2, nbCivilianKills, nbShotsFired, nbShotsHit, nbCloseCombatKills, nbGuardsHarmed, nbCiviliansHarmed, nbAccidents, nbHeadshots, nbBodiesFoundTarget, nbBodiesFoundNonTarget, nbCoversBlown, nbWitnesses, nbSeenByACamera;
        int nbGatorGangKills_zero = 0;

        public HitmanBloodMoney()
        {
            InitializeComponent();
            imgSA = Properties.Resources.Yes;
            imgNotSA = Properties.Resources.No;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName("HitmanBloodMoney");

            if (myProcess.Length != 0)
            {
                // The game is running, ready for memory reading.
                LB_Running.Text = gameName + " IS RUNNING";
                LB_Running.ForeColor = Color.Green;
                isMissionActive = true;

                // Reading the raw name of the current mission as an array of bytes and converting it to a string.
                byte[] mapBytes = null;
                mapBytes = BitConverter.GetBytes(Trainer.ReadPointerDouble("HitmanBloodMoney", baseAddress + 0x000BF8E0, new int[2] { 0x7b8, 0x65c }));

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
                }

                if (isMissionActive) // A mission is currently active, ready to read memory.
                {
                    //Reading timer
                    missionTime = Trainer.ReadPointerFloat("HitmanBloodMoney", baseAddress + 0x038544, new int[4] {0x354, 0xc, 0x58, 0xc});
                    LB_Time.Text = ((int)missionTime / 60).ToString("D2") + ":" + (missionTime % 60).ToString("00.000");
                    //Rest of stuff
                    nbTargetKills = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B25A4);
                    nbGuardKills1 = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2578);
                    nbGuardKills2 = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2588);
                    nbCivilianKills = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2590);
                    nbGuardsHarmed = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B258C);
                    nbCiviliansHarmed = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2594);
                    nbShotsFired = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2554);
                    nbShotsHit = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2558);
                    nbCloseCombatKills = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B25B0);
                    nbAccidents = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B256C);
                    nbHeadshots = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2560);
                    nbBodiesFoundTarget = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B260C);
                    nbBodiesFoundNonTarget = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2608);
                    nbCoversBlown = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2614);
                    nbWitnesses = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B2574);
                    nbSeenByACamera = Trainer.ReadByte("HitmanBloodMoney", baseAddress + 0x5B2624);
                    

                    // Checking if the actual rating is SA according to the current stats

                    if (true)
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
                    if(!(mapName == "Death of the Mississippi" || mapName == "Till Death Do Us Part"))
                        NB_TotalKills.Text = (nbTargetKills + nbGuardKills1 + nbGuardKills2 + nbCivilianKills).ToString();
                    else
                    {
                        if (missionTime == 0)
                            nbGatorGangKills_zero = nbGatorGangKills;
                        nbGatorGangKills = Trainer.ReadInteger("HitmanBloodMoney", baseAddress + 0x5B304C);
                        NB_TotalKills.Text = (nbTargetKills + nbGuardKills1 + nbGuardKills2 + nbCivilianKills + (nbGatorGangKills -nbGatorGangKills_zero)).ToString();
                    }
                    NB_ShotsFired.Text = nbShotsFired.ToString();
                    NB_ShotsHit.Text = nbShotsHit.ToString();
                    NB_CloseEncounterKills.Text = nbCloseCombatKills.ToString();
                    NB_Accidents.Text = nbAccidents.ToString();
                    NB_Headshots.Text = nbHeadshots.ToString();
                    NB_BodiesFound.Text = (nbBodiesFoundTarget + nbBodiesFoundNonTarget).ToString();
                    NB_CoversBlown.Text = nbCoversBlown.ToString();
                    NB_Witnessess.Text = nbWitnesses.ToString();
                    NB_Witnessess.ForeColor = Color.Gray;
                    if (nbSeenByACamera == 0)
                    {
                        NB_SeenByACamera.Text = "0";
                    }
                    else
                        NB_SeenByACamera.Text = "1";

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
        }
    }
}
