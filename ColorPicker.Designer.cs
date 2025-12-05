namespace TagUtils
{
    partial class ColorPicker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            colorEditor = new Cyotek.Windows.Forms.ColorEditor();
            colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            colorStrip = new Button();
            credit = new Label();
            creditLink = new LinkLabel();
            tltLink = new ToolTip(components);
            SuspendLayout();
            // 
            // colorEditor
            // 
            colorEditor.Location = new Point(13, 12);
            colorEditor.Margin = new Padding(4, 3, 4, 3);
            colorEditor.Name = "colorEditor";
            colorEditor.ShowAlphaChannel = false;
            colorEditor.Size = new Size(200, 236);
            colorEditor.TabIndex = 0;
            colorEditor.ColorChanged += colorEditor_ColorChanged;
            // 
            // colorWheel
            // 
            colorWheel.Location = new Point(220, 38);
            colorWheel.Name = "colorWheel";
            colorWheel.Size = new Size(174, 157);
            colorWheel.TabIndex = 1;
            colorWheel.ColorChanged += colorWheel_ColorChanged;
            // 
            // colorStrip
            // 
            colorStrip.Location = new Point(220, 201);
            colorStrip.Name = "colorStrip";
            colorStrip.Size = new Size(174, 47);
            colorStrip.TabIndex = 2;
            colorStrip.Text = "Apply Color";
            colorStrip.UseVisualStyleBackColor = true;
            colorStrip.Click += colorStrip_Click;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Location = new Point(220, 9);
            credit.Name = "credit";
            credit.Size = new Size(133, 15);
            credit.TabIndex = 3;
            credit.Text = "Color Picker courtesy of";
            // 
            // creditLink
            // 
            creditLink.AutoSize = true;
            creditLink.Location = new Point(350, 9);
            creditLink.Name = "creditLink";
            creditLink.Size = new Size(44, 15);
            creditLink.TabIndex = 4;
            creditLink.TabStop = true;
            creditLink.Text = "Cyotek";
            tltLink.SetToolTip(creditLink, resources.GetString("creditLink.ToolTip"));
            creditLink.LinkClicked += creditLink_LinkClicked;
            // 
            // ColorPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(403, 257);
            Controls.Add(creditLink);
            Controls.Add(credit);
            Controls.Add(colorStrip);
            Controls.Add(colorWheel);
            Controls.Add(colorEditor);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ColorPicker";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Color Picker";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Cyotek.Windows.Forms.ColorEditor colorEditor;
        private Cyotek.Windows.Forms.ColorWheel colorWheel;
        private Button colorStrip;
        private Label credit;
        private LinkLabel creditLink;
        private ToolTip tltLink;
    }
}