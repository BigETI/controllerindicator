using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControllerIndicator
{
    public partial class SNESControllerForm : Form
    {
        new public enum Region
        {
            Japan,
            Europe,
            America
        };

        private bool update_form = false;
        private List<SNESControllerButton> snes_buttons = new List<SNESControllerButton>();
        private Region region;


        public bool UpdateForm
        {
            get
            {
                return update_form;
            }
            set
            {
                update_form = value;
            }
        }

        public Region ControllerRegion
        {
            get
            {
                return region;
            }
            set
            {
                toolStripMenuItemSetBackgroundJapan.Checked = false;
                toolStripMenuItemSetBackgroundEurope.Checked = false;
                toolStripMenuItemSetBackgroundAmerica.Checked = false;
                switch (value)
                {
                    case Region.Japan:
                        toolStripMenuItemSetBackgroundJapan.Checked = true;
                        break;
                    case Region.Europe:
                        toolStripMenuItemSetBackgroundEurope.Checked = true;
                        break;
                    case Region.America:
                        toolStripMenuItemSetBackgroundAmerica.Checked = true;
                        break;
                    default:
                        return;
                }
                region = value;
                Refresh();
            }
        }

        public SNESControllerForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_a_glow, SNESControllerButton.Buttons.A));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_b_glow, SNESControllerButton.Buttons.B));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_x_glow, SNESControllerButton.Buttons.X));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_y_glow, SNESControllerButton.Buttons.Y));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_up_glow, SNESControllerButton.Buttons.Up));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_down_glow, SNESControllerButton.Buttons.Down));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_left_glow, SNESControllerButton.Buttons.Left));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_right_glow, SNESControllerButton.Buttons.Right));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_select_glow, SNESControllerButton.Buttons.Select));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_start_glow, SNESControllerButton.Buttons.Start));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_l_glow, SNESControllerButton.Buttons.L));
            snes_buttons.Add(new SNESControllerButton(this, Properties.Resources.SNESController_r_glow, SNESControllerButton.Buttons.R));
            ControllerRegion = Region.Europe;
        }

        private Image getRegionBackground()
        {
            Image ret = null;
            switch (region)
            {
                case Region.Japan:
                    ret = Properties.Resources.SNESController_main_jap;
                    break;
                case Region.Europe:
                    ret = Properties.Resources.SNESController_main_eu;
                    break;
            }
            return ret;
        }

        private void setBackgroundSize(double factor = 1.0)
        {
            FormBorderStyle fbs = FormBorderStyle;
            Image bg = getRegionBackground();
            FormBorderStyle = FormBorderStyle.None;
            Size = new Size((int)(bg.Size.Width * factor), (int)(bg.Size.Height * factor));
            FormBorderStyle = fbs;
            Refresh();
        }

        private void SNESControllerForm_Paint(object sender, PaintEventArgs e)
        {
            if (snes_buttons != null)
            {
                e.Graphics.DrawImage(getRegionBackground(), 0, 0, Size.Width, Size.Height);
                foreach (SNESControllerButton i in snes_buttons)
                {
                    if (i.Pressed)
                        e.Graphics.DrawImage(i.Image, 0, 0, Size.Width, Size.Height);
                }
            }
        }

        private void SNESControllerForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.Sizable)
            {
                menuStrip.Visible = false;
                TransparencyKey = Color.Black;
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                menuStrip.Visible = true;
                TransparencyKey = Color.Transparent;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (SNESControllerButton i in snes_buttons)
                i.update();
            if (update_form)
            {
                Refresh();
                update_form = false;
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1x_Click(object sender, EventArgs e)
        {
            setBackgroundSize();
        }

        private void toolStripMenuItem0_5x_Click(object sender, EventArgs e)
        {
            setBackgroundSize(0.5);
        }

        private void toolStripMenuItem0_2x_Click(object sender, EventArgs e)
        {
            setBackgroundSize(0.2);
        }

        private void toolStripMenuItem0_1x_Click(object sender, EventArgs e)
        {
            setBackgroundSize(0.1);
        }

        private void toolStripMenuItemSetBackgroundJapan_Click(object sender, EventArgs e)
        {
            ControllerRegion = Region.Japan;
        }

        private void toolStripMenuItemSetBackgroundEurope_Click(object sender, EventArgs e)
        {
            ControllerRegion = Region.Europe;
        }

        private void toolStripMenuItemSetBackgroundAmerica_Click(object sender, EventArgs e)
        {
            ControllerRegion = Region.America;
        }
    }
}
