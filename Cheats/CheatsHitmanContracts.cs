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
    public partial class CheatsHitmanContracts : Form
    {
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        const int baseAddress = 0x00400000;
        String mapName;
        static string processName = "hitmancontracts";
        Process myProcess;
        bool foundProcess = false;
        bool isMissionActive;
        int mapNumber;
        int[] secondOffset = { 0x838, 0xB24, 0x8A0, 0x138, 0xB88, 0xBB8, 0xB48, 0xCE8, 0x136C, 0xAD0, 0xF50, 0x8D4, 0x9EC, 0x400, 0x9EC, 0x644, 0xB08, 0x96C, 0xB00, 0x8 };
        byte value = 0;

        // Dictionary used to convert the raw map names into easily readable names and a map number to access the second offsets declared previously.
        Dictionary<string, Tuple<string, int>> mapValues = new Dictionary<string, Tuple<string, int>>(){
            // Hitman Contracts
            { "C01-1_MA", new Tuple<string, int>("Asylum Aftermath", 1) },          { "C01-2_MA", new Tuple<string, int>("The Meat King's Party", 2) },     { "C02-1_MA", new Tuple<string, int>("The Bjarkhov Bomb", 3) },     { "C03-1_MA", new Tuple<string, int>("Beldingford Manor", 4) },             { "C06-1_MA", new Tuple<string, int>("Rendezvous in Rotterdam", 5) },
            { "C06-2_MA", new Tuple<string, int>("Deadly Cargo", 6) },              { "C07-1_MA", new Tuple<string, int>("Traditions of the Trade", 7) },   { "C08-1_MA", new Tuple<string, int>("Slaying a Dragon", 8) },      { "C08-2_MA", new Tuple<string, int>("The Wang Fou Incident", 9) },         { "C08-3_MA", new Tuple<string, int>("The Seafood Massacre", 10) },
            { "C08-4_MA", new Tuple<string, int>("Lee Hong Assassination", 11) },   { "C09-1_MA", new Tuple<string, int>("Hunter and Hunted", 12) },

            { "C01-1_Lo", new Tuple<string, int>("Asylum Aftermath", 1) },          { "C01-2_Lo", new Tuple<string, int>("The Meat King's Party", 2) },     { "C02-1_Lo", new Tuple<string, int>("The Bjarkhov Bomb", 3) },     { "C03-1_Lo", new Tuple<string, int>("Beldingford Manor", 4) },             { "C06-1_Lo", new Tuple<string, int>("Rendezvous in Rotterdam", 5) },
            { "C06-2_Lo", new Tuple<string, int>("Deadly Cargo", 6) },              { "C07-1_Lo", new Tuple<string, int>("Traditions of the Trade", 7) },   { "C08-1_Lo", new Tuple<string, int>("Slaying a Dragon", 8) },      { "C08-2_Lo", new Tuple<string, int>("The Wang Fou Incident", 9) },         { "C08-3_Lo", new Tuple<string, int>("The Seafood Massacre", 10) },
            { "C08-4_Lo", new Tuple<string, int>("Lee Hong Assassination", 11) },   { "C09-1_Lo", new Tuple<string, int>("Hunter and Hunted", 12) }
        };

        public CheatsHitmanContracts()
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
                    value = Trainer.ReadPointerByte("hitmancontracts", baseAddress + 0x002A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x245 });
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
                Trainer.WritePointerByte("hitmancontracts", baseAddress + 0x002A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x245 }, value);
            }
        }

        private void TB_Value_TextChanged(object sender, EventArgs e)
        {
            var res = 0;
            if (int.TryParse(TB_Value.Text, out res))
            {
                value = Convert.ToByte(res);
            }
        }

        private void RTB_MainCheats_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
