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
        Keys mappedKey;

        public FormMainConfig()
        {
            InitializeComponent();

            this.gkh.KeyDown += new KeyEventHandler(gkh_keyDown);
            this.gkh.KeyUp += new KeyEventHandler(gkh_keyUp);

            this.comboBoxMapKeys.Items.AddRange(Enum.GetNames(typeof(Keys)));
            this.setHookedKey((Keys)Enum.Parse(typeof(Keys), this.labelKeyToSupress.Text));
            this.updateMappedKey();
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

        private void checkBoxToggleOn_CheckedChanged(object sender, EventArgs e)
        {
            bool boxChecked = this.checkBoxToggleOn.Checked;
            this.checkBoxToggleOn.Text = boxChecked ? "On" : "Off";
            this.checkBoxToggleOn.ForeColor = boxChecked ? Color.GreenYellow : Color.DodgerBlue;
            this.enabled = boxChecked;
        }

        public void capturedKey(KeyPressEventArgs e)
        {
            Keys key = Utilities.Convert.ConvertCharToVirtualKey(e.KeyChar);
            this.setHookedKey(key);
        }

        public void setHookedKey(Keys key)
        {
            this.supressedKey = key;
            this.labelKeyToSupress.Text = key.ToString(); 
            this.gkh.HookedKeys.Clear();
            this.gkh.HookedKeys.Add(key);
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            FormCaptureKey capture = new FormCaptureKey(this);
            capture.ShowDialog(this);
        }

        private void gkh_keyDown(object sender, KeyEventArgs e)
        {
            if (this.enabled && e.KeyCode == this.supressedKey)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Utilities.SendKeys.asKeyboard(this.mappedKey);
            }
        }

        private void gkh_keyUp(object sender, KeyEventArgs e)
        {
            Utilities.SendKeys.asKeyboard(this.mappedKey, false);
        }

        private void updateMappedKey()
        {
            this.mappedKey = (Keys)Enum.Parse(typeof(Keys), comboBoxMapKeys.Text);
        }

        private void comboBoxMapKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateMappedKey();
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            FormDebug window = new FormDebug();
            window.ShowDialog(this);
        }
    }
}
