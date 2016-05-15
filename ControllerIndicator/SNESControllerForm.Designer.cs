namespace ControllerIndicator
{
    partial class SNESControllerForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1x = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem0_5x = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem0_2x = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem0_1x = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetBackgroundJapan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetBackgroundEurope = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetBackgroundAmerica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 7;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1501, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.toolStripMenuItemSetBackground});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItemEdit.Text = "Edit";
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1x,
            this.toolStripMenuItem0_5x,
            this.toolStripMenuItem0_2x,
            this.toolStripMenuItem0_1x});
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            // 
            // toolStripMenuItem1x
            // 
            this.toolStripMenuItem1x.Name = "toolStripMenuItem1x";
            this.toolStripMenuItem1x.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem1x.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem1x.Text = "1x";
            this.toolStripMenuItem1x.Click += new System.EventHandler(this.toolStripMenuItem1x_Click);
            // 
            // toolStripMenuItem0_5x
            // 
            this.toolStripMenuItem0_5x.Name = "toolStripMenuItem0_5x";
            this.toolStripMenuItem0_5x.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuItem0_5x.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem0_5x.Text = "0.5x";
            this.toolStripMenuItem0_5x.Click += new System.EventHandler(this.toolStripMenuItem0_5x_Click);
            // 
            // toolStripMenuItem0_2x
            // 
            this.toolStripMenuItem0_2x.Name = "toolStripMenuItem0_2x";
            this.toolStripMenuItem0_2x.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.toolStripMenuItem0_2x.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem0_2x.Text = "0.2x";
            this.toolStripMenuItem0_2x.Click += new System.EventHandler(this.toolStripMenuItem0_2x_Click);
            // 
            // toolStripMenuItem0_1x
            // 
            this.toolStripMenuItem0_1x.Name = "toolStripMenuItem0_1x";
            this.toolStripMenuItem0_1x.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.toolStripMenuItem0_1x.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem0_1x.Text = "0.1x";
            this.toolStripMenuItem0_1x.Click += new System.EventHandler(this.toolStripMenuItem0_1x_Click);
            // 
            // toolStripMenuItemSetBackground
            // 
            this.toolStripMenuItemSetBackground.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSetBackgroundJapan,
            this.toolStripMenuItemSetBackgroundEurope,
            this.toolStripMenuItemSetBackgroundAmerica});
            this.toolStripMenuItemSetBackground.Name = "toolStripMenuItemSetBackground";
            this.toolStripMenuItemSetBackground.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemSetBackground.Text = "Set background";
            // 
            // toolStripMenuItemSetBackgroundJapan
            // 
            this.toolStripMenuItemSetBackgroundJapan.Name = "toolStripMenuItemSetBackgroundJapan";
            this.toolStripMenuItemSetBackgroundJapan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.toolStripMenuItemSetBackgroundJapan.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemSetBackgroundJapan.Text = "Japan";
            this.toolStripMenuItemSetBackgroundJapan.Click += new System.EventHandler(this.toolStripMenuItemSetBackgroundJapan_Click);
            // 
            // toolStripMenuItemSetBackgroundEurope
            // 
            this.toolStripMenuItemSetBackgroundEurope.Checked = true;
            this.toolStripMenuItemSetBackgroundEurope.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemSetBackgroundEurope.Name = "toolStripMenuItemSetBackgroundEurope";
            this.toolStripMenuItemSetBackgroundEurope.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.toolStripMenuItemSetBackgroundEurope.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemSetBackgroundEurope.Text = "Europe";
            this.toolStripMenuItemSetBackgroundEurope.Click += new System.EventHandler(this.toolStripMenuItemSetBackgroundEurope_Click);
            // 
            // toolStripMenuItemSetBackgroundAmerica
            // 
            this.toolStripMenuItemSetBackgroundAmerica.Enabled = false;
            this.toolStripMenuItemSetBackgroundAmerica.Name = "toolStripMenuItemSetBackgroundAmerica";
            this.toolStripMenuItemSetBackgroundAmerica.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.toolStripMenuItemSetBackgroundAmerica.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemSetBackgroundAmerica.Text = "America";
            this.toolStripMenuItemSetBackgroundAmerica.Click += new System.EventHandler(this.toolStripMenuItemSetBackgroundAmerica_Click);
            // 
            // SNESControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1501, 661);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SNESControllerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNES Controller";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SNESControllerForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SNESControllerForm_MouseClick);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1x;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem0_5x;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem0_2x;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem0_1x;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetBackground;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetBackgroundJapan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetBackgroundEurope;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetBackgroundAmerica;
    }
}

