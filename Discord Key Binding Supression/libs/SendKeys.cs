using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Utilities;

namespace Utilities
{
    // https://social.msdn.microsoft.com/Forums/vstudio/en-US/95c1d459-eda3-4e5f-9751-4b5c73b65fc6/how-to-simulate-keyboard-input-to-another-application?forum=csharpgeneral

    class SendKeys
    {
        public static void toWindow(string windowTitle, Keys keys)
        {
            IntPtr windowHandle = NativeMethods.FindWindow(windowTitle, null);
            IntPtr editHandle = NativeMethods.FindWindowEx(windowHandle, IntPtr.Zero, "Edit", null);

            //NativeMethods.SendMessage(editHandle, NativeMethods.WM_SETTEXT, 0, "");
            NativeMethods.PostMessage(editHandle, NativeMethods.WM_KEYDOWN, keys, IntPtr.Zero);
        }
    }
}
