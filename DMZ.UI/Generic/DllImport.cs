

using System;
using System.Runtime.InteropServices;

namespace DMZ.UI.Generic
{
    public static class Dllimport
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwmd, int wmsg, int wparam, int lparam);

    }

}
