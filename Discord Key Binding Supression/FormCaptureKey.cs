using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Key_Binding_Supression
{
    public partial class FormCaptureKey : Form
    {
        private FormMainConfig parent;

        public FormCaptureKey(FormMainConfig mainWindow)
        {
            InitializeComponent();
            this.parent = mainWindow;
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            this.parent.capturedKey(e);
            this.Close();
        }
    }
}
