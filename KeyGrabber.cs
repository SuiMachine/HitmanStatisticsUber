using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace HitmanStatistics
{
    class KeyGrabber
    {
        public static EventHandler keyPressEvent;
        public static List<Keys> key = new List<Keys>();

        public static bool Hooked;

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13; 
        const int WM_KEYDOWN = 0x100; 

        private static LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public static void SetHook()
        {

            if (keyPressEvent == null)
                return;

            Hooked = true;
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            Hooked = false;
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
           {
                
                int keyCode = Marshal.ReadInt32(lParam);

                foreach (var k in key)
                {
                    if (keyCode == (int)k)
                    {
                        keyPressEvent(k, new EventArgs());
                    }
                }


                return CallNextHookEx(hhook, code, (int)wParam, lParam);
            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }
    }
}
