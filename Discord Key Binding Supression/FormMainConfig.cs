using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Discord_Key_Binding_Supression
{
    public partial class FormMainConfig : Form
    {
        private GlobalKeyboardHook gkh = new GlobalKeyboardHook();
        private Keys supressedKey;
        bool enabled = true;
        Process[] processes = Process.GetProcessesByName("discord");
        IntPtr discordHandle;
        Keys mappedKey = Keys.B;

        public FormMainConfig()
        {
            InitializeComponent();

            this.gkh.KeyDown += new KeyEventHandler(gkh_keyDown);
            this.gkh.KeyUp += new KeyEventHandler(gkh_keyUp);

            this.comboBoxMapKeys.Items.AddRange(Enum.GetNames(typeof(Keys)));
            this.populateTextBox();
            this.setHookedKey((Keys)Enum.Parse(typeof(Keys), this.labelKeyToSupress.Text));
        }

        private void populateTextBox()
        {
            foreach (Process process in processes)
            {
                this.textBox1.Text += "=====" + process.Id.ToString("X") + "=====\r\n";
                foreach (IntPtr handle in EnumerateProcessWindowHandles(process.Id))
                {
                    StringBuilder message = new StringBuilder(1000);
                    SendMessage(handle, WM_GETTEXT, message.Capacity, message);
                    this.textBox1.Text += handle.ToString("X") + " --- " + message;
                    if (message.ToString().EndsWith(" - Discord"))
                    {
                        discordHandle = handle;
                        this.textBox1.Text += " --- FOUND IT!!!";
                    }
                    this.textBox1.Text += "\r\n";
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool boxChecked = this.checkBoxToggleOn.Checked;
            this.checkBoxToggleOn.Text = boxChecked ? "On" : "Off";
            this.checkBoxToggleOn.ForeColor = boxChecked ? Color.GreenYellow : Color.DodgerBlue;
            this.enabled = boxChecked;
        }

        public void capturedKey(KeyPressEventArgs e)
        {
            
            //int keyInt = e.KeyChar;
            //string keyName = Enum.GetName(typeof(Keys), keyInt);
            Keys key = Utilities.Convert.ConvertCharToVirtualKey(e.KeyChar);
            this.setHookedKey(key);
        }

        public void setHookedKey(Keys key)
        {
            this.supressedKey = key;
            this.labelKeyToSupress.Text = key.ToString(); //e.KeyChar.ToString().ToUpper();
            this.gkh.HookedKeys.Clear();
            this.gkh.HookedKeys.Add(key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gkh.HookedKeys.Clear();
            FormCaptureKey capture = new FormCaptureKey(this);
            capture.ShowDialog(this);
        }

        private void gkh_keyDown(object sender, KeyEventArgs e)
        {
            if (this.enabled)
            {
                if (e.KeyCode == this.supressedKey)
                {
                    //Process process = Process.GetProcessesByName("notepad")[0];
                    IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
                    uint procId = 0;
                    NativeMethods.GetWindowThreadProcessId(foregroundWindow, out procId);
                    Process process = Process.GetProcessById((int)procId);
                    //Utilities.SendKeys.toWindow(this.processes[0], e.KeyCode);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    Utilities.SendKeys.asKeyboard(this.mappedKey);
                    //Utilities.SendKeys.toWindow(discordHandle, this.mappedKey);
                    //this.textBox1.Text += "\r\nSent to: " + discordHandle.ToString("X") + "\r\n";
                }
            }
        }

        private void gkh_keyUp(object sender, KeyEventArgs e)
        {
            /*IntPtr foregroundWindow = NativeMethods.GetForegroundWindow();
            uint procId = 0;
            NativeMethods.GetWindowThreadProcessId(foregroundWindow, out procId);
            Process process = Process.GetProcessById((int)procId);
            Utilities.SendKeys.toWindow(discordHandle, this.mappedKey, NativeMethods.WM_KEYUP);
            e.Handled = true;*/
            Utilities.SendKeys.asKeyboard(this.mappedKey, false);
        }

        delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn,
            IntPtr lParam);

        static IEnumerable<IntPtr> EnumerateProcessWindowHandles(int processId)
        {
            var handles = new List<IntPtr>();

            foreach (ProcessThread thread in Process.GetProcessById(processId).Threads)
                EnumThreadWindows(thread.Id,
                    (hWnd, lParam) => { handles.Add(hWnd); return true; }, IntPtr.Zero);

            return handles;
        }

        private const uint WM_GETTEXT = 0x000D;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam,
            StringBuilder lParam);

        private void comboBoxMapKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mappedKey = (Keys)Enum.Parse(typeof(Keys), comboBoxMapKeys.Text);
        }
    }
}
