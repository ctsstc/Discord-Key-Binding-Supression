using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Utilities;

namespace Utilities
{
    // https://social.msdn.microsoft.com/Forums/vstudio/en-US/95c1d459-eda3-4e5f-9751-4b5c73b65fc6/how-to-simulate-keyboard-input-to-another-application?forum=csharpgeneral

    class SendKeys
    {
        public static void toWindow(Process process, Keys keys, int type = NativeMethods.WM_KEYDOWN)
        {
            toWindow(process.MainWindowHandle, keys, type);
        }

        public static void toWindow(string windowTitle, Keys keys, int type = NativeMethods.WM_KEYDOWN)
        {
            IntPtr windowHandle = NativeMethods.FindWindow(windowTitle, null);
            toWindow(windowHandle, keys, type);
        }

        public static void toWindow(IntPtr windowHandle, Keys keys, int type = NativeMethods.WM_KEYDOWN)
        {
            IntPtr editHandle = NativeMethods.FindWindowEx(windowHandle, IntPtr.Zero, "Edit", null);

            //NativeMethods.SendMessage(editHandle, NativeMethods.WM_SETTEXT, 0, "");
            NativeMethods.PostMessage(windowHandle, type, keys, IntPtr.Zero);
            //NativeMethods.PostMessage(editHandle, NativeMethods.WM_CHAR, keys, IntPtr.Zero);
        }

        public static void asKeyboard(Keys key, bool down = true)
        {
            uint pressType = down ? NativeMethods.KEYEVENTF_EXTENDEDKEY : NativeMethods.KEYEVENTF_KEYUP;
            NativeMethods.keybd_event((byte)key, 0, pressType, 0);
        }
    }
}
