using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Discord_Key_Binding_Supression
{
    public partial class FormDebug : Form
    {
        Process[] processes = Process.GetProcessesByName("discord");
        IntPtr discordHandle;

        public FormDebug()
        {
            InitializeComponent();
            this.populateTextBox();
        }

        private void populateTextBox()
        {
            this.textBox1.Text += "Discord Processes with Handles and Window Titles\r\n";
            foreach (Process process in processes)
            {
                this.textBox1.Text += "=====" + process.Id.ToString("X") + "=====\r\n";
                foreach (IntPtr handle in EnumerateProcessWindowHandles(process.Id))
                {
                    StringBuilder message = new StringBuilder(1000);
                    NativeMethods.SendMessage(handle, NativeMethods.WM_GETTEXT, message.Capacity, message);
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

        static IEnumerable<IntPtr> EnumerateProcessWindowHandles(int processId)
        {
            var handles = new List<IntPtr>();

            foreach (ProcessThread thread in Process.GetProcessById(processId).Threads)
                NativeMethods.EnumThreadWindows(thread.Id,
                    (hWnd, lParam) => { handles.Add(hWnd); return true; }, IntPtr.Zero);

            return handles;
        }
    }
}
