using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public FormMainConfig()
        {
            InitializeComponent();
            this.gkh.KeyDown += new KeyEventHandler(gkh_keyDown);
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
                    Utilities.SendKeys.toWindow("Notepad", e.KeyCode);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.textBox1.Text = e.KeyData.ToString();
        }
    }
}
