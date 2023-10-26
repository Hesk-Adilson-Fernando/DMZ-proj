using System;
using System.Runtime.InteropServices;
using System.Text;

//using System.Security.Permissions;

//[assembly: SecurityPermission(SecurityAction.RequestMinimum, UnmanagedCode = true)]
namespace ANEA.WF.Classes
{
    public static class MessageBoxManager
    {
        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private delegate bool EnumChildProc(IntPtr hWnd, IntPtr lParam);

        private const int WH_CALLWNDPROCRET = 12;
        private const int WM_INITDIALOG = 0x0110;

        private const int MBOK = 1;
        private const int MBCancel = 2;
        private const int MBAbort = 3;
        private const int MBRetry = 4;
        private const int MBIgnore = 5;
        private const int MBYes = 6;
        private const int MBNo = 7;


        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll")]
        private static extern int UnhookWindowsHookEx(IntPtr idHook);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthW", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetClassNameW", CharSet = CharSet.Unicode)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern int GetDlgCtrlID(IntPtr hwndCtl);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", EntryPoint = "SetWindowTextW", CharSet = CharSet.Unicode)]
        private static extern bool SetWindowText(IntPtr hWnd, string lpString);


        [StructLayout(LayoutKind.Sequential)]
        public struct CWPRETSTRUCT
        {
            public IntPtr lResult;
            public IntPtr lParam;
            public IntPtr wParam;
            public uint message;
            public IntPtr hwnd;
        };

        private static readonly HookProc _hookProc;
        private static readonly EnumChildProc _enumProc;
        [ThreadStatic]
        private static IntPtr _hHook;
        [ThreadStatic]
        private static int _nButton;

        /// <summary>
        /// OK text
        /// </summary>
        public static string OK = "&OK";
        /// <summary>
        /// Cancel text
        /// </summary>
        public static string Cancel = "&Cancelar";
        /// <summary>
        /// Abort text
        /// </summary>
        public static string Abort = "&Abortar";
        /// <summary>
        /// Retry text
        /// </summary>
        public static string Retry = "&Retry";
        /// <summary>
        /// Ignore text
        /// </summary>
        public static string Ignore = "&Ignorar";
        /// <summary>
        /// Yes text
        /// </summary>
        public static string Yes = "&Sim";
        /// <summary>
        /// No text
        /// </summary>
        public static string No = "&Não";

        static MessageBoxManager()
        {
            _hookProc = MessageBoxHookProc;
            _enumProc = MessageBoxEnumProc;
            _hHook = IntPtr.Zero;
        }

        /// <summary>
        /// Enables MessageBoxManager functionality
        /// </summary>
        /// <remarks>
        /// MessageBoxManager functionality is enabled on current thread only.
        /// Each thread that needs MessageBoxManager functionality has to call this method.
        /// </remarks>
        public static void Register()
        {
            if (_hHook != IntPtr.Zero)
                throw new NotSupportedException("One hook per thread allowed.");
            _hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, _hookProc, IntPtr.Zero, 28488);
        }

        /// <summary>
        /// Disables MessageBoxManager functionality
        /// </summary>
        /// <remarks>
        /// Disables MessageBoxManager functionality on current thread only.
        /// </remarks>
        public static void Unregister()
        {
            if (_hHook == IntPtr.Zero) return;
            UnhookWindowsHookEx(_hHook);
            _hHook = IntPtr.Zero;
        }

        private static IntPtr MessageBoxHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0)
                return CallNextHookEx(_hHook, nCode, wParam, lParam);

            var msg = (CWPRETSTRUCT)Marshal.PtrToStructure(lParam, typeof(CWPRETSTRUCT));
            var hook = _hHook;

            if (msg.message != WM_INITDIALOG) return CallNextHookEx(hook, nCode, wParam, lParam);
            GetWindowTextLength(msg.hwnd);
            var className = new StringBuilder(10);
            GetClassName(msg.hwnd, className, className.Capacity);
            if (className.ToString() != "#32770") return CallNextHookEx(hook, nCode, wParam, lParam);
            _nButton = 0;
            EnumChildWindows(msg.hwnd, _enumProc, IntPtr.Zero);
            if (_nButton != 1) return CallNextHookEx(hook, nCode, wParam, lParam);
            var hButton = GetDlgItem(msg.hwnd, MBCancel);
            if (hButton != IntPtr.Zero)
                SetWindowText(hButton, OK);

            return CallNextHookEx(hook, nCode, wParam, lParam);
        }

        private static bool MessageBoxEnumProc(IntPtr hWnd, IntPtr lParam)
        {
            var className = new StringBuilder(10);
            GetClassName(hWnd, className, className.Capacity);
            if (className.ToString() != "Button") return true;
            var ctlId = GetDlgCtrlID(hWnd);
            switch (ctlId)
            {
                case MBOK:
                    SetWindowText(hWnd, OK);
                    break;
                case MBCancel:
                    SetWindowText(hWnd, Cancel);
                    break;
                case MBAbort:
                    SetWindowText(hWnd, Abort);
                    break;
                case MBRetry:
                    SetWindowText(hWnd, Retry);
                    break;
                case MBIgnore:
                    SetWindowText(hWnd, Ignore);
                    break;
                case MBYes:
                    SetWindowText(hWnd, Yes);
                    break;
                case MBNo:
                    SetWindowText(hWnd, No);
                    break;

            }
            _nButton++;

            return true;
        }

    }
}
