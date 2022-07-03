using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADK.Windows
{
    public class API
    {
        public API() : base()
        {
        }

        public enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x18,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }

        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        public static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);

    }
}
