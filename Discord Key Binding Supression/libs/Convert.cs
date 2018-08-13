using System.Windows.Forms;

namespace Utilities
{
    class Convert
    {
        public static Keys ConvertCharToVirtualKey(char ch)
        {
            short vkey = NativeMethods.VkKeyScan(ch);
            Keys retval = (Keys)(vkey & 0xff);
            int modifiers = vkey >> 8;
            if ((modifiers & 1) != 0) retval |= Keys.Shift;
            if ((modifiers & 2) != 0) retval |= Keys.Control;
            if ((modifiers & 4) != 0) retval |= Keys.Alt;
            return retval;
        }
    }
}
