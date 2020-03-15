using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheatsForms
{
    public partial class CheatsHitman2 : Form
    {
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        const int baseAddress = 0x00400000;
        String mapName;
        static string processName = "hitman2";
        Process myProcess;
        bool foundProcess = false;
        bool isMissionActive;
        int mapNumber;
        int[] secondOffset = { 0x838, 0xB24, 0x8A0, 0x138, 0xB88, 0xBB8, 0xB48, 0xCE8, 0x136C, 0xAD0, 0xF50, 0x8D4, 0x9EC, 0x400, 0x9EC, 0x644, 0xB08, 0x96C, 0xB00, 0x8 };
        byte value=0;

        // Dictionary used to convert the raw map names into easily readable names and a map number to access the second offsets declared previously.
        Dictionary<string, Tuple<string, int>> mapValues = new Dictionary<string, Tuple<string, int>>() {
            { "C1-1__MA", new Tuple<string, int>("Anathema", 1) },                  { "C2-1__MA", new Tuple<string, int>("St. Petersburg Stakeout", 2) },   { "C2-2__MA", new Tuple<string, int>("Kirov Park Meeting", 3) },    { "C2-3__MA", new Tuple<string, int>("Tubeway Torpedo", 4) },               { "C2-4__MA", new Tuple<string, int>("Invitation to a Party", 5) },
            { "C3-1__MA", new Tuple<string, int>("Tracking Hayamoto", 6) },         { "\\C3-2a__", new Tuple<string, int>("Hidden Valley", 7) },            { "\\C3-2b__", new Tuple<string, int>("At the Gates", 8) },         { "C3-3__MA", new Tuple<string, int>("Shogun Showdown", 9) },               { "C4-1__MA", new Tuple<string, int>("Basement Killing", 10) },
            { "C4-2__MA", new Tuple<string, int>("The Graveyard Shift", 11) },      { "C4-3__MA", new Tuple<string, int>("The Jacuzzi Job", 12) },          { "C5-1__MA", new Tuple<string, int>("Murder At The Bazaar", 13) }, { "C5-2__MA", new Tuple<string, int>("The Motorcade Interception", 14) },   { "C5-3__MA", new Tuple<string, int>("Tunnel Rat", 15) },
            { "C6-1__MA", new Tuple<string, int>("Temple City Ambush", 16) },       { "C6-2__MA", new Tuple<string, int>("The Death of Hannelore", 17) },   { "C6-3__MA", new Tuple<string, int>("Terminal Hospitality", 18) }, { "C7-1__MA", new Tuple<string, int>("St. Petersburg Revisited", 19) },     { "C8-1__MA", new Tuple<string, int>("Redemption at Gontranno", 20) }};

        public CheatsHitman2()
        {
            InitializeComponent();
        }

        private void B_SigScan_Click(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName(processName).FirstOrDefault();

            if (myProcess != null)
            {
                foundProcess = true;
            }
            else
                foundProcess = false;

            if (foundProcess)
            {
                byte[] mapBytes = null;
                mapBytes = BitConverter.GetBytes(Trainer.ReadPointerDouble(myProcess, baseAddress + 0x002A6C5C, new int[2] { 0x98, 0xBC7 }));
                string mapBytesStr = enc.GetString(mapBytes);
                isMissionActive = true;

                try
                {
                    // Trying to get the clean mission name and the mission number from the dictionary.
                    mapName = mapValues[mapBytesStr].Item1;
                    mapNumber = mapValues[mapBytesStr].Item2;
                }
                catch (KeyNotFoundException)
                {
                    isMissionActive = false;
                }

                if (isMissionActive) // A mission is currently active, ready to read memory.
                {
                    value = Trainer.ReadPointerByte("hitman2", baseAddress + 0x002A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x245 });
                    TB_Value.Text = value.ToString();
                }
            }
            else
                MessageBox.Show("Process not running");
        }

        private void B_WriteToMemory_Click(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName(processName).FirstOrDefault();

            if (myProcess != null)
            {
                foundProcess = true;
            }
            else
                foundProcess = false;

            if (foundProcess)
            {
                Trainer.WritePointerByte("hitman2", baseAddress + 0x002A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x245 }, value);
            }
        }

        private void TB_Value_TextChanged(object sender, EventArgs e)
        {
            var res = 0;
            if(int.TryParse(TB_Value.Text, out res))
            {
                value = Convert.ToByte(res);
            }
        }
    }
}
