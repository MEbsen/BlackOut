using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace BlackOut
{
    public static class ScreenController
    {
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 dwData, UIntPtr dwExtraInfo);
        
        const int SC_MONITORPOWER = 0xF170;
        const int WM_SYSCOMMAND = 0x112;
        const int MONITOR_OFF = 2;
        const int MONITOR_ON = -1;
        const int MONITOR_Standby = 1;
        const int MOUSEEVENTF_MOVE = 0x0001;

        // Sluk skærmen
        public static void TurnOff() => _ = SendMessage(GetConsoleWindow(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);

        // Tænd skærmen
        public static void TurnOn()
        {
            _ = SendMessage(GetConsoleWindow(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_ON);
            Wake();
        }

        private static void Wake()
        {
            mouse_event(MOUSEEVENTF_MOVE, 0, 1, 0, UIntPtr.Zero);
            Thread.Sleep(40);
            mouse_event(MOUSEEVENTF_MOVE, 0, -1, 0, UIntPtr.Zero);
        }

    }
}
