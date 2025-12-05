using Microsoft.VisualBasic;

namespace TagUtils
{
    partial class TagUtilsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagUtilsMain));
            OpnFileSelect = new OpenFileDialog();
            LblFileInfo = new Label();
            LblDetected = new Label();
            BtnSelectFile = new PictureBox();
            LblRenderDistance = new Label();
            TbRenderDistance = new TextBox();
            BtnApplyAndPlay = new Button();
            BtnApply = new Button();
            BtnResetRenderDist = new Button();
            TltResetValue = new ToolTip(components);
            BtnResetMovement = new Button();
            BtnResetCanSelect = new Button();
            BtnResetCanCheats = new Button();
            LblMovement = new Label();
            TbMovementUp = new TextBox();
            TbMovementDown = new TextBox();
            TbMovementLeft = new TextBox();
            TbMovementRight = new TextBox();
            LblCanSelect = new Label();
            TbCanSelect1 = new TextBox();
            TbCanSelect2 = new TextBox();
            TbCanSelect3 = new TextBox();
            LblCanSelect1 = new Label();
            LblCanSelect2 = new Label();
            LblCanSelect3 = new Label();
            TbCanCheats1 = new TextBox();
            TbCanCheats2 = new TextBox();
            TbCanCheats3 = new TextBox();
            LblCanCheats1 = new Label();
            LblCanCheats2 = new Label();
            LblCanCheats3 = new Label();
            LblCanCheats = new Label();
            ((System.ComponentModel.ISupportInitialize)BtnSelectFile).BeginInit();
            SuspendLayout();
            // 
            // OpnFileSelect
            // 
            OpnFileSelect.FileName = "Tag.exe";
            OpnFileSelect.Filter = "Executable|*.exe";
            // 
            // LblFileInfo
            // 
            LblFileInfo.AutoSize = true;
            LblFileInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblFileInfo.Location = new Point(155, 30);
            LblFileInfo.Name = "LblFileInfo";
            LblFileInfo.Size = new Size(118, 20);
            LblFileInfo.TabIndex = 2;
            LblFileInfo.Text = "No .exe selected";
            // 
            // LblDetected
            // 
            LblDetected.AutoSize = true;
            LblDetected.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDetected.ForeColor = SystemColors.ControlLightLight;
            LblDetected.Location = new Point(73, 30);
            LblDetected.Name = "LblDetected";
            LblDetected.Size = new Size(76, 20);
            LblDetected.TabIndex = 3;
            LblDetected.Text = "Detected:";
            // 
            // BtnSelectFile
            // 
            BtnSelectFile.BackColor = SystemColors.ButtonFace;
            BtnSelectFile.BorderStyle = BorderStyle.Fixed3D;
            BtnSelectFile.Cursor = Cursors.Hand;
			BtnSelectFile.Image = Properties.Resources.icons8_exe_48;
			BtnSelectFile.Location = new Point(27, 21);
            BtnSelectFile.Name = "BtnSelectFile";
            BtnSelectFile.Size = new Size(40, 40);
            BtnSelectFile.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSelectFile.TabIndex = 4;
            BtnSelectFile.TabStop = false;
            BtnSelectFile.Click += BtnSelectFile_Click;
            BtnSelectFile.MouseEnter += BtnSelectFile_MouseHover;
            BtnSelectFile.MouseLeave += BtnSelectFile_MouseLeave;
            // 
            // LblRenderDistance
            // 
            LblRenderDistance.AutoSize = true;
            LblRenderDistance.Location = new Point(30, 92);
            LblRenderDistance.Name = "LblRenderDistance";
            LblRenderDistance.Size = new Size(95, 15);
            LblRenderDistance.TabIndex = 5;
            LblRenderDistance.Text = "Render Distance:";
            LblRenderDistance.Visible = false;
            // 
            // TbRenderDistance
            // 
            TbRenderDistance.Location = new Point(131, 89);
            TbRenderDistance.Name = "TbRenderDistance";
            TbRenderDistance.Size = new Size(100, 23);
            TbRenderDistance.TabIndex = 6;
            TbRenderDistance.Visible = false;
            TbRenderDistance.TextChanged += TbRenderDistance_TextChanged;
            // 
            // BtnApplyAndPlay
            // 
            BtnApplyAndPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnApplyAndPlay.BackgroundImageLayout = ImageLayout.Zoom;
            BtnApplyAndPlay.Enabled = false;
            BtnApplyAndPlay.ForeColor = SystemColors.ControlText;
            BtnApplyAndPlay.Image = Properties.Resources.icons8_play_100;
            BtnApplyAndPlay.ImageAlign = ContentAlignment.MiddleLeft;
            BtnApplyAndPlay.Location = new Point(429, 226);
            BtnApplyAndPlay.Name = "BtnApplyAndPlay";
            BtnApplyAndPlay.Size = new Size(103, 23);
            BtnApplyAndPlay.TabIndex = 7;
            BtnApplyAndPlay.Text = "Apply & Play";
            BtnApplyAndPlay.TextAlign = ContentAlignment.MiddleLeft;
            BtnApplyAndPlay.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnApplyAndPlay.UseMnemonic = false;
            BtnApplyAndPlay.UseVisualStyleBackColor = true;
            BtnApplyAndPlay.Click += BtnApplyAndPlay_Click;
            // 
            // BtnApply
            // 
            BtnApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnApply.Enabled = false;
            BtnApply.ForeColor = SystemColors.ControlText;
            BtnApply.Image = Properties.Resources.icons8_save_24;
            BtnApply.ImageAlign = ContentAlignment.MiddleLeft;
            BtnApply.Location = new Point(361, 226);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new Size(62, 23);
            BtnApply.TabIndex = 8;
            BtnApply.Text = "Apply";
            BtnApply.TextAlign = ContentAlignment.MiddleLeft;
            BtnApply.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
            // 
            // BtnResetRenderDist
            // 
            BtnResetRenderDist.Image = Properties.Resources.icons8_reset_50;
            BtnResetRenderDist.Location = new Point(237, 88);
            BtnResetRenderDist.Name = "BtnResetRenderDist";
            BtnResetRenderDist.Size = new Size(24, 24);
            BtnResetRenderDist.TabIndex = 9;
            TltResetValue.SetToolTip(BtnResetRenderDist, "Set to Default (1350)");
            BtnResetRenderDist.UseVisualStyleBackColor = true;
            BtnResetRenderDist.Visible = false;
            BtnResetRenderDist.Click += BtnResetRenderDist_Click;
            // 
            // BtnResetMovement
            // 
            BtnResetMovement.Image = Properties.Resources.icons8_reset_50;
            BtnResetMovement.Location = new Point(207, 121);
            BtnResetMovement.Name = "BtnResetMovement";
            BtnResetMovement.Size = new Size(24, 24);
            BtnResetMovement.TabIndex = 15;
            TltResetValue.SetToolTip(BtnResetMovement, "Set to Default (W, A, S, D)");
            BtnResetMovement.UseVisualStyleBackColor = true;
            BtnResetMovement.Visible = false;
            BtnResetMovement.Click += BtnResetMovement_Click;
            // 
            // BtnResetCanSelect
            // 
            BtnResetCanSelect.Image = Properties.Resources.icons8_reset_50;
            BtnResetCanSelect.Location = new Point(371, 65);
            BtnResetCanSelect.Name = "BtnResetCanSelect";
            BtnResetCanSelect.Size = new Size(24, 24);
            BtnResetCanSelect.TabIndex = 21;
            TltResetValue.SetToolTip(BtnResetCanSelect, "Set to Default (1, 2, 3)");
            BtnResetCanSelect.UseVisualStyleBackColor = true;
            BtnResetCanSelect.Visible = false;
            BtnResetCanSelect.Click += BtnResetCanSelect_Click;
            // 
            // BtnResetCanCheats
            // 
            BtnResetCanCheats.Image = Properties.Resources.icons8_reset_50;
            BtnResetCanCheats.Location = new Point(207, 188);
            BtnResetCanCheats.Name = "BtnResetCanCheats";
            BtnResetCanCheats.Size = new Size(24, 24);
            BtnResetCanCheats.TabIndex = 32;
            TltResetValue.SetToolTip(BtnResetCanCheats, "Set to Default (8, 9, 0)");
            BtnResetCanCheats.UseVisualStyleBackColor = true;
            BtnResetCanCheats.Visible = false;
            BtnResetCanCheats.Click += BtnResetCanCheats_Click;
            // 
            // LblMovement
            // 
            LblMovement.AutoSize = true;
            LblMovement.Location = new Point(57, 124);
            LblMovement.Name = "LblMovement";
            LblMovement.Size = new Size(68, 15);
            LblMovement.TabIndex = 10;
            LblMovement.Text = "Movement:";
            LblMovement.Visible = false;
            // 
            // TbMovementUp
            // 
            TbMovementUp.Location = new Point(131, 121);
            TbMovementUp.Name = "TbMovementUp";
            TbMovementUp.Size = new Size(54, 23);
            TbMovementUp.TabIndex = 11;
            TbMovementUp.Visible = false;
            TbMovementUp.TextChanged += TbMovementUp_TextChanged;
            // 
            // TbMovementDown
            // 
            TbMovementDown.Location = new Point(131, 150);
            TbMovementDown.Name = "TbMovementDown";
            TbMovementDown.Size = new Size(54, 23);
            TbMovementDown.TabIndex = 12;
            TbMovementDown.Visible = false;
            TbMovementDown.TextChanged += TbMovementDown_TextChanged;
            // 
            // TbMovementLeft
            // 
            TbMovementLeft.Location = new Point(71, 150);
            TbMovementLeft.Name = "TbMovementLeft";
            TbMovementLeft.Size = new Size(54, 23);
            TbMovementLeft.TabIndex = 13;
            TbMovementLeft.Visible = false;
            TbMovementLeft.TextChanged += TbMovementLeft_TextChanged;
            // 
            // TbMovementRight
            // 
            TbMovementRight.Location = new Point(191, 150);
            TbMovementRight.Name = "TbMovementRight";
            TbMovementRight.Size = new Size(54, 23);
            TbMovementRight.TabIndex = 14;
            TbMovementRight.Visible = false;
            TbMovementRight.TextChanged += TbMovementRight_TextChanged;
            // 
            // LblCanSelect
            // 
            LblCanSelect.AutoSize = true;
            LblCanSelect.Location = new Point(300, 74);
            LblCanSelect.Name = "LblCanSelect";
            LblCanSelect.Size = new Size(65, 15);
            LblCanSelect.TabIndex = 16;
            LblCanSelect.Text = "Can Select:";
            LblCanSelect.Visible = false;
            // 
            // TbCanSelect1
            // 
            TbCanSelect1.Location = new Point(300, 94);
            TbCanSelect1.Name = "TbCanSelect1";
            TbCanSelect1.Size = new Size(95, 23);
            TbCanSelect1.TabIndex = 17;
            TbCanSelect1.Visible = false;
            TbCanSelect1.TextChanged += TbCanSelect1_TextChanged;
            // 
            // TbCanSelect2
            // 
            TbCanSelect2.Location = new Point(300, 123);
            TbCanSelect2.Name = "TbCanSelect2";
            TbCanSelect2.Size = new Size(95, 23);
            TbCanSelect2.TabIndex = 18;
            TbCanSelect2.Visible = false;
            TbCanSelect2.TextChanged += TbCanSelect2_TextChanged;
            // 
            // TbCanSelect3
            // 
            TbCanSelect3.Location = new Point(300, 152);
            TbCanSelect3.Name = "TbCanSelect3";
            TbCanSelect3.Size = new Size(95, 23);
            TbCanSelect3.TabIndex = 19;
            TbCanSelect3.Visible = false;
            TbCanSelect3.TextChanged += TbCanSelect3_TextChanged;
            // 
            // LblCanSelect1
            // 
            LblCanSelect1.AutoSize = true;
            LblCanSelect1.Location = new Point(401, 99);
            LblCanSelect1.Name = "LblCanSelect1";
            LblCanSelect1.Size = new Size(38, 15);
            LblCanSelect1.TabIndex = 22;
            LblCanSelect1.Text = "Green";
            LblCanSelect1.Visible = false;
            // 
            // LblCanSelect2
            // 
            LblCanSelect2.AutoSize = true;
            LblCanSelect2.Location = new Point(401, 127);
            LblCanSelect2.Name = "LblCanSelect2";
            LblCanSelect2.Size = new Size(27, 15);
            LblCanSelect2.TabIndex = 23;
            LblCanSelect2.Text = "Red";
            LblCanSelect2.Visible = false;
            // 
            // LblCanSelect3
            // 
            LblCanSelect3.AutoSize = true;
            LblCanSelect3.Location = new Point(401, 155);
            LblCanSelect3.Name = "LblCanSelect3";
            LblCanSelect3.Size = new Size(30, 15);
            LblCanSelect3.TabIndex = 24;
            LblCanSelect3.Text = "Blue";
            LblCanSelect3.Visible = false;
            // 
            // TbCanCheats1
            // 
            TbCanCheats1.Location = new Point(30, 226);
            TbCanCheats1.Name = "TbCanCheats1";
            TbCanCheats1.Size = new Size(95, 23);
            TbCanCheats1.TabIndex = 25;
            TbCanCheats1.Visible = false;
            TbCanCheats1.TextChanged += TbCanCheats1_TextChanged;
            // 
            // TbCanCheats2
            // 
            TbCanCheats2.Location = new Point(131, 226);
            TbCanCheats2.Name = "TbCanCheats2";
            TbCanCheats2.Size = new Size(95, 23);
            TbCanCheats2.TabIndex = 26;
            TbCanCheats2.Visible = false;
            TbCanCheats2.TextChanged += TbCanCheats2_TextChanged;
            // 
            // TbCanCheats3
            // 
            TbCanCheats3.Location = new Point(232, 226);
            TbCanCheats3.Name = "TbCanCheats3";
            TbCanCheats3.Size = new Size(95, 23);
            TbCanCheats3.TabIndex = 27;
            TbCanCheats3.Visible = false;
            TbCanCheats3.TextChanged += TbCanCheats3_TextChanged;
            // 
            // LblCanCheats1
            // 
            LblCanCheats1.AutoSize = true;
            LblCanCheats1.Location = new Point(57, 208);
            LblCanCheats1.Name = "LblCanCheats1";
            LblCanCheats1.Size = new Size(38, 15);
            LblCanCheats1.TabIndex = 28;
            LblCanCheats1.Text = "Green";
            LblCanCheats1.TextAlign = ContentAlignment.MiddleCenter;
            LblCanCheats1.Visible = false;
            // 
            // LblCanCheats2
            // 
            LblCanCheats2.AutoSize = true;
            LblCanCheats2.Location = new Point(167, 208);
            LblCanCheats2.Name = "LblCanCheats2";
            LblCanCheats2.Size = new Size(27, 15);
            LblCanCheats2.TabIndex = 29;
            LblCanCheats2.Text = "Red";
            LblCanCheats2.TextAlign = ContentAlignment.MiddleCenter;
            LblCanCheats2.Visible = false;
            // 
            // LblCanCheats3
            // 
            LblCanCheats3.AutoSize = true;
            LblCanCheats3.Location = new Point(265, 208);
            LblCanCheats3.Name = "LblCanCheats3";
            LblCanCheats3.Size = new Size(30, 15);
            LblCanCheats3.TabIndex = 30;
            LblCanCheats3.Text = "Blue";
            LblCanCheats3.TextAlign = ContentAlignment.MiddleCenter;
            LblCanCheats3.Visible = false;
            // 
            // LblCanCheats
            // 
            LblCanCheats.AutoSize = true;
            LblCanCheats.Location = new Point(131, 193);
            LblCanCheats.Name = "LblCanCheats";
            LblCanCheats.Size = new Size(70, 15);
            LblCanCheats.TabIndex = 31;
            LblCanCheats.Text = "Can Cheats:";
            LblCanCheats.Visible = false;
            // 
            // TagUtilsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(544, 261);
            Controls.Add(BtnResetCanCheats);
            Controls.Add(LblCanCheats);
            Controls.Add(LblCanCheats3);
            Controls.Add(LblCanCheats2);
            Controls.Add(LblCanCheats1);
            Controls.Add(TbCanCheats3);
            Controls.Add(TbCanCheats2);
            Controls.Add(TbCanCheats1);
            Controls.Add(LblCanSelect3);
            Controls.Add(LblCanSelect2);
            Controls.Add(LblCanSelect1);
            Controls.Add(BtnResetCanSelect);
            Controls.Add(TbCanSelect3);
            Controls.Add(TbCanSelect2);
            Controls.Add(TbCanSelect1);
            Controls.Add(LblCanSelect);
            Controls.Add(BtnResetMovement);
            Controls.Add(TbMovementRight);
            Controls.Add(TbMovementLeft);
            Controls.Add(TbMovementDown);
            Controls.Add(TbMovementUp);
            Controls.Add(LblMovement);
            Controls.Add(BtnResetRenderDist);
            Controls.Add(BtnApply);
            Controls.Add(BtnApplyAndPlay);
            Controls.Add(TbRenderDistance);
            Controls.Add(LblRenderDistance);
            Controls.Add(BtnSelectFile);
            Controls.Add(LblDetected);
            Controls.Add(LblFileInfo);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(560, 300);
            Name = "TagUtilsMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tag Utils";
            ((System.ComponentModel.ISupportInitialize)BtnSelectFile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog OpnFileSelect;
        private Label LblFileInfo;
        private Label LblDetected;
        private PictureBox BtnSelectFile;
        private Label LblRenderDistance;
        private TextBox TbRenderDistance;
        private Button BtnApplyAndPlay;
        private Button BtnApply;
        private Button BtnResetRenderDist;
        private ToolTip TltResetValue;
        private Label LblMovement;
        private TextBox TbMovementUp;
        private TextBox TbMovementDown;
        private TextBox TbMovementLeft;
        private TextBox TbMovementRight;
        private Button BtnResetMovement;
        private Label LblCanSelect;
        private TextBox TbCanSelect1;
        private TextBox TbCanSelect2;
        private TextBox TbCanSelect3;
        private Button BtnResetCanSelect;
        private Label LblCanSelect1;
        private Label LblCanSelect2;
        private Label LblCanSelect3;
        private TextBox TbCanCheats1;
        private TextBox TbCanCheats2;
        private TextBox TbCanCheats3;
        private Label LblCanCheats1;
        private Label LblCanCheats2;
        private Label LblCanCheats3;
        private Label LblCanCheats;
        private Button BtnResetCanCheats;
    }
}