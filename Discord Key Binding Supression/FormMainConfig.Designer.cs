namespace Discord_Key_Binding_Supression
{
    partial class FormMainConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainConfig));
            this.notifyIconTaskBar = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotificationIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxToggleOn = new System.Windows.Forms.CheckBox();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.labelKeyToSupress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMapKeys = new System.Windows.Forms.ComboBox();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.contextMenuStripNotificationIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconTaskBar
            // 
            this.notifyIconTaskBar.ContextMenuStrip = this.contextMenuStripNotificationIcon;
            this.notifyIconTaskBar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTaskBar.Icon")));
            this.notifyIconTaskBar.Text = "notifyIcon1";
            this.notifyIconTaskBar.Visible = true;
            // 
            // contextMenuStripNotificationIcon
            // 
            this.contextMenuStripNotificationIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStripNotificationIcon.Name = "contextMenuStripNotificationIcon";
            this.contextMenuStripNotificationIcon.Size = new System.Drawing.Size(143, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "Open Config";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key to Supress:";
            // 
            // checkBoxToggleOn
            // 
            this.checkBoxToggleOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxToggleOn.Checked = true;
            this.checkBoxToggleOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxToggleOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxToggleOn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxToggleOn.FlatAppearance.BorderSize = 2;
            this.checkBoxToggleOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxToggleOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxToggleOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxToggleOn.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBoxToggleOn.Location = new System.Drawing.Point(12, 9);
            this.checkBoxToggleOn.Name = "checkBoxToggleOn";
            this.checkBoxToggleOn.Size = new System.Drawing.Size(60, 30);
            this.checkBoxToggleOn.TabIndex = 3;
            this.checkBoxToggleOn.Text = "On ";
            this.checkBoxToggleOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxToggleOn.UseVisualStyleBackColor = false;
            this.checkBoxToggleOn.CheckedChanged += new System.EventHandler(this.checkBoxToggleOn_CheckedChanged);
            // 
            // buttonCapture
            // 
            this.buttonCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCapture.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonCapture.FlatAppearance.BorderSize = 2;
            this.buttonCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapture.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonCapture.Location = new System.Drawing.Point(306, 7);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(83, 35);
            this.buttonCapture.TabIndex = 5;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // labelKeyToSupress
            // 
            this.labelKeyToSupress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKeyToSupress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelKeyToSupress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyToSupress.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelKeyToSupress.Location = new System.Drawing.Point(200, 7);
            this.labelKeyToSupress.Name = "labelKeyToSupress";
            this.labelKeyToSupress.Size = new System.Drawing.Size(100, 35);
            this.labelKeyToSupress.TabIndex = 6;
            this.labelKeyToSupress.Text = "Oemtilde";
            this.labelKeyToSupress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Map to Key:";
            // 
            // comboBoxMapKeys
            // 
            this.comboBoxMapKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.comboBoxMapKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMapKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMapKeys.ForeColor = System.Drawing.Color.GreenYellow;
            this.comboBoxMapKeys.FormattingEnabled = true;
            this.comboBoxMapKeys.Location = new System.Drawing.Point(199, 48);
            this.comboBoxMapKeys.Name = "comboBoxMapKeys";
            this.comboBoxMapKeys.Size = new System.Drawing.Size(190, 28);
            this.comboBoxMapKeys.TabIndex = 8;
            this.comboBoxMapKeys.Text = "F13";
            this.comboBoxMapKeys.SelectedIndexChanged += new System.EventHandler(this.comboBoxMapKeys_SelectedIndexChanged);
            // 
            // buttonDebug
            // 
            this.buttonDebug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDebug.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDebug.FlatAppearance.BorderSize = 2;
            this.buttonDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebug.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonDebug.Location = new System.Drawing.Point(12, 44);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(83, 35);
            this.buttonDebug.TabIndex = 9;
            this.buttonDebug.Text = "Debug";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // FormMainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(401, 87);
            this.Controls.Add(this.buttonDebug);
            this.Controls.Add(this.comboBoxMapKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKeyToSupress);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.checkBoxToggleOn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Key Binding Supression";
            this.contextMenuStripNotificationIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconTaskBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotificationIcon;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxToggleOn;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.Label labelKeyToSupress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMapKeys;
        private System.Windows.Forms.Button buttonDebug;
    }
}

