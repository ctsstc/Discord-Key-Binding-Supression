using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    class NativeMethods
    {
        public const int WM_SETTEXT = 0x000c;
        public const uint WM_GETTEXT = 0x000D;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        public const int WM_CHAR = 0x0102;
        // https://stackoverflow.com/questions/14395377/how-to-simulate-a-ctrl-a-ctrl-c-using-keybd-event
        public const uint KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const uint KEYEVENTF_KEYUP = 0x0002; //Key up flag

        // https://social.msdn.microsoft.com/Forums/vstudio/en-US/95c1d459-eda3-4e5f-9751-4b5c73b65fc6/how-to-simulate-keyboard-input-to-another-application?forum=csharpgeneral

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, int Msg, Keys wParam, IntPtr lParam);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        // https://stackoverflow.com/questions/17345202/get-the-current-active-application-name

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        // https://www.pinvoke.net/default.aspx/user32.keybd_event
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        // https://stackoverflow.com/questions/2531828/how-to-enumerate-all-windows-belonging-to-a-particular-process-using-net/2584672#2584672
        public delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);
    }
}
