using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TagUtils
{
    public partial class ColorPicker : Form
    {
        public Color SelectedColor;

        public ColorPicker()
        {
            InitializeComponent();
            colorWheel.Color = colorEditor.Color = colorStrip.BackColor = SelectedColor = Color.FromArgb(TagUtility.TagValues.LevelTransitionColor.Value);
        }

        private void colorWheel_ColorChanged(object sender, EventArgs e)
        {
            colorEditor.Color = colorStrip.BackColor = colorWheel.Color;
            colorStrip.ForeColor = colorEditor.HslColor.L < 0.5 ? Color.White : Color.Black;

        }

        private void colorEditor_ColorChanged(object sender, EventArgs e)
        {
            colorWheel.Color = colorStrip.BackColor = colorEditor.Color;
            colorStrip.ForeColor = colorEditor.HslColor.L < 0.4 ? Color.White : Color.Black;
        }

        private void colorStrip_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            colorStrip.ForeColor = colorEditor.HslColor.L < 0.4 ? Color.White : Color.Black;
        }

        private void colorStrip_Click(object sender, EventArgs e)
        {
            SelectedColor = colorStrip.BackColor;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void creditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker/")
            {
                UseShellExecute = true
            };
            Process.Start(ps);
		}
    }
}
