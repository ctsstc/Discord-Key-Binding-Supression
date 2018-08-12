using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Utilities
{
    class NativeMethods
    {
        public const int WM_SETTEXT = 0x000c;
        public const int WM_KEYDOWN = 0x0100;

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
    }
}
