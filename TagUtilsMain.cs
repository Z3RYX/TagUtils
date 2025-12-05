using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagUtils
{
    public partial class TagUtilsMain : Form
    {
        string TagFile = "";
        TagVersion Version;
        int ErrorCount = 0;
        int ChangeCount = 0;

        public TagUtilsMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Looks for the text "Tag:" at the given address
        /// </summary>
        /// <param name="address">Address pointing to the window title string</param>
        /// <returns></returns>
        private bool IsTagExe(int address)
        {
            using var f = File.OpenRead(TagFile);
            f.Seek(address, SeekOrigin.Begin);
            var b = new byte[4];
            f.ReadExactly(b);
            return b.SequenceEqual(new byte[] { 0x54, 0x61, 0x67, 0x3a });
        }

        private void AnalyzeFile()
        {
            if (!File.Exists(TagFile))
            {
                LblFileInfo.Text = "No/Invalid file, please try again.";
                LblFileInfo.ForeColor = Color.Red;
                return;
            }

            LblFileInfo.Text = "Analyzing...";

            using var f = File.OpenRead(TagFile);
            f.Seek(0x3C, SeekOrigin.Begin);
            var b = f.ReadByte();
            if (b == 0x10 && IsTagExe(0x00141144)) // Version 1.0
            {
                LblFileInfo.Text = "Tag v1.0";
                Version = TagVersion.V1_0;
            }
            else if (b == 0x8 && IsTagExe(0x00141f24)) // Version 1.1
            {
                LblFileInfo.Text = "Tag v1.1";
                Version = TagVersion.V1_1;
            }
            else // Unknown
            {
                LblFileInfo.Text = "Unknown file ";
                return;
            }


            //! Find render distance
            var valFloat = TagUtility.TagValues.RenderDistance;
            f.Seek(valFloat.Address[Version], SeekOrigin.Begin);
            var buffer = new byte[4];
            f.ReadExactly(buffer);
            valFloat.Value = BitConverter.ToSingle(buffer);

			//! Find level transition
			// Enabled
            var valBool = TagUtility.TagValues.LevelTransitionEnabled;
            f.Seek(valBool.Address[Version], SeekOrigin.Begin);
            buffer = new byte[1];
            f.ReadExactly(buffer);
            valBool.Value = buffer[0] == 0xE8;

			// Color
			var valInt = TagUtility.TagValues.LevelTransitionColor;
            f.Seek(valInt.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valInt.Value = TagUtility.TagValues.LevelTransitionEnabled.Value ? -1 : BitConverter.ToInt32(buffer);

            //! Find movement keys
            // Up Prime
            var valKey = TagUtility.TagValues.MovementUpPrime;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            // Up Secondary
            valKey = TagUtility.TagValues.MovementUpSecond;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            // Down Prime
            valKey = TagUtility.TagValues.MovementDownPrime;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            // Down Secondary
            valKey = TagUtility.TagValues.MovementDownSecond;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            // Left Prime
            valKey = TagUtility.TagValues.MovementLeftPrime;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            // Left Secondary
            valKey = TagUtility.TagValues.MovementLeftSecond;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            // Right Prime
            valKey = TagUtility.TagValues.MovementRightPrime;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            // Right Secondary
            valKey = TagUtility.TagValues.MovementRightSecond;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[4];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)BitConverter.ToInt32(buffer);

            //! Find Can Select
            // 1
            valKey = TagUtility.TagValues.CanSelect1_First;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[1];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)buffer[0];

            // 2
            valKey = TagUtility.TagValues.CanSelect2_First;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[1];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)buffer[0];

            // 3
            valKey = TagUtility.TagValues.CanSelect3_First;
            f.Seek(valKey.Address[Version], SeekOrigin.Begin);
            buffer = new byte[1];
            f.ReadExactly(buffer);
            valKey.Value = (Keys)buffer[0];

            //! Find Can Cheats (Version 1.1)
            if (Version == TagVersion.V1_1)
            {
                // 1
                valKey = TagUtility.TagValues.CanCheats1_First;
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                buffer = new byte[1];
                f.ReadExactly(buffer);
                valKey.Value = (Keys)buffer[0];

                // 2
                valKey = TagUtility.TagValues.CanCheats2_First;
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                buffer = new byte[1];
                f.ReadExactly(buffer);
                valKey.Value = (Keys)buffer[0];

                // 3
                valKey = TagUtility.TagValues.CanCheats3_First;
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                buffer = new byte[1];
                f.ReadExactly(buffer);
                valKey.Value = (Keys)buffer[0];
            }

            //! Activate fields
            // Render Distance
            TbRenderDistance.Text = TagUtility.TagValues.RenderDistance.Value.ToString();
            LblRenderDistance.Visible = true;
            TbRenderDistance.Visible = true;
            BtnResetRenderDist.Visible = true;

            // Level Transition
            CbLevelTransition.Checked = TagUtility.TagValues.LevelTransitionEnabled.Value;
            CbLevelTransition.Visible = true;
            BtnLevelTransition.Visible = true;
            BtnLevelTransition.Enabled = !CbLevelTransition.Checked;
            BtnLevelTransition.BackColor = CbLevelTransition.Checked
                ? Color.White
                : Color.FromArgb(TagUtility.TagValues.LevelTransitionColor.Value);
            BtnLevelTransition.ForeColor = BtnLevelTransition.BackColor.GetBrightness() < 0.4 ? SystemColors.ControlLight : Color.Black;

			// Movement
			TbMovementUp.Text = KeyConverter.ToString(TagUtility.TagValues.MovementUpPrime.Value);
            TbMovementDown.Text = KeyConverter.ToString(TagUtility.TagValues.MovementDownPrime.Value);
            TbMovementLeft.Text = KeyConverter.ToString(TagUtility.TagValues.MovementLeftPrime.Value);
            TbMovementRight.Text = KeyConverter.ToString(TagUtility.TagValues.MovementRightPrime.Value);
            LblMovement.Visible = true;
            TbMovementUp.Visible = true;
            TbMovementDown.Visible = true;
            TbMovementLeft.Visible = true;
            TbMovementRight.Visible = true;
            BtnResetMovement.Visible = true;

            // Can Select
            TbCanSelect1.Text = KeyConverter.ToString(TagUtility.TagValues.CanSelect1_First.Value);
            TbCanSelect2.Text = KeyConverter.ToString(TagUtility.TagValues.CanSelect2_First.Value);
            TbCanSelect3.Text = KeyConverter.ToString(TagUtility.TagValues.CanSelect3_First.Value);
            LblCanSelect.Visible = true;
            TbCanSelect1.Visible = true;
            TbCanSelect2.Visible = true;
            TbCanSelect3.Visible = true;
            LblCanSelect1.Visible = true;
            LblCanSelect2.Visible = true;
            LblCanSelect3.Visible = true;
            BtnResetCanSelect.Visible = true;

            // Can Cheats (Version 1.1)
            if (Version == TagVersion.V1_1)
            {
                TbCanCheats1.Text = KeyConverter.ToString(TagUtility.TagValues.CanCheats1_First.Value);
                TbCanCheats2.Text = KeyConverter.ToString(TagUtility.TagValues.CanCheats2_First.Value);
                TbCanCheats3.Text = KeyConverter.ToString(TagUtility.TagValues.CanCheats3_First.Value);
                LblCanCheats.Visible = true;
                TbCanCheats1.Visible = true;
                TbCanCheats2.Visible = true;
                TbCanCheats3.Visible = true;
                LblCanCheats1.Visible = true;
                LblCanCheats2.Visible = true;
                LblCanCheats3.Visible = true;
                BtnResetCanCheats.Visible = true;
            }

            // Activate Play Button
            BtnApplyAndPlay.Enabled = true;
        }

        private void ApplyValues()
        {
            if (!File.Exists(TagFile))
            {
                DisplayErrorMessage("Tag executable no longer found. Please reselect the executable.");
            }

            using var f = File.OpenWrite(TagFile);
            TagValue<float> valFloat;
            TagValue<Keys> valKey;

            //! Render Distance
            if (TbRenderDistance.Font.Bold)
            {
                valFloat = TagUtility.TagValues.RenderDistance;
                valFloat.Value = float.Parse(TbRenderDistance.Text);
                f.Seek(TagUtility.TagValues.RenderDistance.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes(valFloat.Value));
                TbRenderDistance.Font = new Font(TbRenderDistance.Font, FontStyle.Regular);
            }

			//! Level Transition
            f.Seek(TagUtility.TagValues.LevelTransitionEnabled.Address[Version], SeekOrigin.Begin);

            if (CbLevelTransition.Checked && !TagUtility.TagValues.LevelTransitionEnabled.Value)
            {
                f.Write([0xE8,0x85,0x4D,0xFD,0xFF]);
            } else if (!CbLevelTransition.Checked)
            {
                var ba = new byte[5];
                ba[0] = 0xB8;
                BitConverter.GetBytes(TagUtility.TagValues.LevelTransitionColor.Value).CopyTo(ba, 1);
                f.Write(ba);
            }

            //! Movement
            // Up
            if (TbMovementUp.Font.Bold)
            {
                var t = TbMovementUp;
                valKey = TagUtility.TagValues.MovementUpPrime;

                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));
                t.Font = new Font(t.Font, FontStyle.Regular);
            }

            // Down
            if (TbMovementDown.Font.Bold)
            {
                var t = TbMovementDown;
                valKey = TagUtility.TagValues.MovementDownPrime;

                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));
                t.Font = new Font(t.Font, FontStyle.Regular);
            }

            // Left
            if (TbMovementLeft.Font.Bold)
            {
                var t = TbMovementLeft;
                valKey = TagUtility.TagValues.MovementLeftPrime;

                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));
                t.Font = new Font(t.Font, FontStyle.Regular);
            }

            // Right
            if (TbMovementRight.Font.Bold)
            {
                var t = TbMovementRight;
                valKey = TagUtility.TagValues.MovementRightPrime;

                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));
                t.Font = new Font(t.Font, FontStyle.Regular);
            }

            //! Can Select
            // 1
            if (TbCanSelect1.Font.Bold)
            {
                var t = TbCanSelect1;

                valKey = TagUtility.TagValues.CanSelect1_First;
                valKey.Value = KeyConverter.ToKey(t.Text, false);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                valKey = TagUtility.TagValues.CanSelect1_Second;
                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));

                // Third check reuses result of the first check

                valKey = TagUtility.TagValues.CanSelect1_Fourth;
                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));

                t.Font = new Font(t.Font, FontStyle.Regular);
            }

            // 2
            if (TbCanSelect2.Font.Bold)
            {
                var t = TbCanSelect2;

                valKey = TagUtility.TagValues.CanSelect2_First;
                valKey.Value = KeyConverter.ToKey(t.Text, false);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                valKey = TagUtility.TagValues.CanSelect2_Second;
                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));

                valKey = TagUtility.TagValues.CanSelect2_Third;
                valKey.Value = KeyConverter.ToKey(t.Text, false);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                valKey = TagUtility.TagValues.CanSelect2_Fourth;
                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));

                t.Font = new Font(t.Font, FontStyle.Regular);
            }

            // 3
            if (TbCanSelect3.Font.Bold)
            {
                var t = TbCanSelect3;

                valKey = TagUtility.TagValues.CanSelect3_First;
                valKey.Value = KeyConverter.ToKey(t.Text, false);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                valKey = TagUtility.TagValues.CanSelect3_Second;
                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));

                valKey = TagUtility.TagValues.CanSelect3_Third;
                valKey.Value = KeyConverter.ToKey(t.Text, false);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                valKey = TagUtility.TagValues.CanSelect3_Fourth;
                valKey.Value = KeyConverter.ToKey(t.Text, true);
                f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                f.Write(BitConverter.GetBytes((int)valKey.Value));

                t.Font = new Font(t.Font, FontStyle.Regular);
            }

            //! Can Cheats
            if (Version == TagVersion.V1_1)
            {
                // 1
                if (TbCanCheats1.Font.Bold)
                {
                    var t = TbCanCheats1;

                    valKey = TagUtility.TagValues.CanCheats1_First;
                    valKey.Value = KeyConverter.ToKey(t.Text, false);
                    f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                    f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                    valKey = TagUtility.TagValues.CanCheats1_Second;
                    valKey.Value = KeyConverter.ToKey(t.Text, true);
                    f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                    f.Write(BitConverter.GetBytes((int)valKey.Value));

                    t.Font = new Font(t.Font, FontStyle.Regular);
                }

                // 2
                if (TbCanCheats2.Font.Bold)
                {
                    var t = TbCanCheats2;

                    valKey = TagUtility.TagValues.CanCheats2_First;
                    valKey.Value = KeyConverter.ToKey(t.Text, false);
                    f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                    f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                    valKey = TagUtility.TagValues.CanCheats2_Second;
                    valKey.Value = KeyConverter.ToKey(t.Text, true);
                    f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                    f.Write(BitConverter.GetBytes((int)valKey.Value));

                    t.Font = new Font(t.Font, FontStyle.Regular);
                }

                // 3
                if (TbCanCheats3.Font.Bold)
                {
                    var t = TbCanCheats3;

                    valKey = TagUtility.TagValues.CanCheats3_First;
                    valKey.Value = KeyConverter.ToKey(t.Text, false);
                    f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                    f.Write(BitConverter.GetBytes((int)valKey.Value), 0, 1);

                    valKey = TagUtility.TagValues.CanCheats3_Second;
                    valKey.Value = KeyConverter.ToKey(t.Text, true);
                    f.Seek(valKey.Address[Version], SeekOrigin.Begin);
                    f.Write(BitConverter.GetBytes((int)valKey.Value));

                    t.Font = new Font(t.Font, FontStyle.Regular);
                }
            }

            //! Resets error and change count, and disables the button
            ErrorCount = ChangeCount = 0;
            BtnApply.Enabled = false;
        }

        // Generic method to handle changed Movement keys in TextBox
        private void MovementTextChange(TextBox tb, TagValue<Keys> tv)
        {
            var k = KeyConverter.ToKey(tb.Text, true);

            // If key was recognized, check if it is the same or different to the applied value
            if (k != Keys.NULL)
            {
                // If wrong value was resolved, remove an error count and set the bg to normal
                if (tb.BackColor == Color.Red) ErrorCount--;
                tb.BackColor = SystemColors.Window;

                // If value is same as applied value, change font to regular
                if (k == tv.Value)
                {
                    // If font was bold before (changed value) set it to regular and remove a change count
                    if (tb.Font.Bold)
                    {
                        ChangeCount--;
                        tb.Font = new Font(tb.Font, FontStyle.Regular);
                    }
                }
                // Else if value is different from applied value, change font to bold
                else
                {
                    // If font was regular before (same value) set it to bold and add a change count
                    if (!tb.Font.Bold) ChangeCount++;
                    tb.Font = new Font(tb.Font, FontStyle.Bold);
                }
            }
            // Else if key was not recognized, change bg to red
            else
            {
                // If value wasn't wrong before, change bg to red and add an error count
                if (tb.BackColor != Color.Red)
                {
                    ErrorCount++;
                    tb.BackColor = Color.Red;
                }
            }

            // Enables the Apply button only when all errors are resolved and at least one value was changed
            BtnApply.Enabled = ErrorCount == 0 && ChangeCount > 0;
        }

        // Generic method to handle changed Can Select and Cheats keys in TextBox
        private void CanTextChange(TextBox tb, TagValue<Keys> tv)
        {
            var k = KeyConverter.ToKey(tb.Text, false);

            // If key was recognized and is not a mouse action, check if it is the same or different to the applied value
            if (k != Keys.NULL && (int)k < 0x100)
            {
                // If wrong value was resolved, remove an error count and set the bg to normal
                if (tb.BackColor == Color.Red) ErrorCount--;
                tb.BackColor = SystemColors.Window;

                // If value is same as applied value, change font to regular
                if (k == tv.Value)
                {
                    // If font was bold before (changed value) set it to regular and remove a change count
                    if (tb.Font.Bold)
                    {
                        ChangeCount--;
                        tb.Font = new Font(tb.Font, FontStyle.Regular);
                    }
                }
                // Else if value is different from applied value, change font to bold
                else
                {
                    // If font was regular before (same value) set it to bold and add a change count
                    if (!tb.Font.Bold) ChangeCount++;
                    tb.Font = new Font(tb.Font, FontStyle.Bold);
                }
            }
            // Else if key was not recognized, change bg to red
            else
            {
                // If value wasn't wrong before, change bg to red and add an error count
                if (tb.BackColor != Color.Red)
                {
                    ErrorCount++;
                    tb.BackColor = Color.Red;
                }
            }

            // Enables the Apply button only when all errors are resolved and at least one value was changed
            BtnApply.Enabled = ErrorCount == 0 && ChangeCount > 0;
        }

        // In case something breaks
        private void DisplayErrorMessage(string text)
        {
            MessageBox.Show("Something went wrong", text, MessageBoxButtons.OK);
        }

        // Open Select EXE Dialog
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            var fileSelect = OpnFileSelect.ShowDialog();
            if (fileSelect == DialogResult.OK)
            {
                TagFile = OpnFileSelect.FileName;
                AnalyzeFile();
            }
        }

        // Hover event for Select EXE Button
        private void BtnSelectFile_MouseHover(object sender, EventArgs e)
            => BtnSelectFile.BackColor = SystemColors.ButtonHighlight;
        private void BtnSelectFile_MouseLeave(object sender, EventArgs e)
            => BtnSelectFile.BackColor = SystemColors.ButtonFace;

        // Apply changes
        private void BtnApply_Click(object sender, EventArgs e)
            => ApplyValues();

        // Apply changes (if any) and start the game; closes the utility program
        private void BtnApplyAndPlay_Click(object sender, EventArgs e)
        {
            // Applies all changes if applicable
            ApplyValues();

            // Sets startinfo for the game process
            try
            {
                var startInfo = new ProcessStartInfo(TagFile)
                {
                    UseShellExecute = true,
                    WorkingDirectory = Path.GetDirectoryName(TagFile) ?? throw new Exception("Tag executable no longer found. Please reselect the executable.")
                };

                // Starts the game
                var p = Process.Start(startInfo);

                //! Sets the started game top-most
                [DllImport("user32.dll")]
                static extern bool SetForegroundWindow(IntPtr hWnd);
                if (p != null) SetForegroundWindow(p.Handle);

                // Closes this application
                Close();
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
                throw;
            }
        }

        //! Render Distance Text Changed
        private void TbRenderDistance_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TbRenderDistance.Text, out var rd))
            {
                if (TbRenderDistance.BackColor == Color.Red) ErrorCount--;
                TbRenderDistance.BackColor = SystemColors.Window;
                if (rd == TagUtility.TagValues.RenderDistance.Value)
                {
                    TbRenderDistance.Font = new Font(TbRenderDistance.Font, FontStyle.Regular);
                }
                else
                {
                    TbRenderDistance.Font = new Font(TbRenderDistance.Font, FontStyle.Bold);
                }
            }
            else
            {
                if (TbRenderDistance.BackColor != Color.Red) ErrorCount++;
                TbRenderDistance.BackColor = Color.Red;
            }

            BtnApply.Enabled = ErrorCount == 0 && ChangeCount > 0;
        }

        // Render Distance to Default
        private void BtnResetRenderDist_Click(object sender, EventArgs e)
        {
            TbRenderDistance.Text = TagUtility.TagValues.RenderDistance.Default.ToString();
        }

        //! Movement Text Changed
        private void TbMovementUp_TextChanged(object sender, EventArgs e)
            => MovementTextChange(TbMovementUp, TagUtility.TagValues.MovementUpPrime);
        private void TbMovementDown_TextChanged(object sender, EventArgs e)
            => MovementTextChange(TbMovementDown, TagUtility.TagValues.MovementDownPrime);
        private void TbMovementLeft_TextChanged(object sender, EventArgs e)
            => MovementTextChange(TbMovementLeft, TagUtility.TagValues.MovementLeftPrime);
        private void TbMovementRight_TextChanged(object sender, EventArgs e)
            => MovementTextChange(TbMovementRight, TagUtility.TagValues.MovementRightPrime);

        // Movement to Default
        private void BtnResetMovement_Click(object sender, EventArgs e)
        {
            TbMovementUp.Text = KeyConverter.ToString(TagUtility.TagValues.MovementUpPrime.Default);
            TbMovementDown.Text = KeyConverter.ToString(TagUtility.TagValues.MovementDownPrime.Default);
            TbMovementLeft.Text = KeyConverter.ToString(TagUtility.TagValues.MovementLeftPrime.Default);
            TbMovementRight.Text = KeyConverter.ToString(TagUtility.TagValues.MovementRightPrime.Default);
        }

        //! Can Select Text Changed
        private void TbCanSelect1_TextChanged(object sender, EventArgs e)
            => CanTextChange(TbCanSelect1, TagUtility.TagValues.CanSelect1_First);
        private void TbCanSelect2_TextChanged(object sender, EventArgs e)
            => CanTextChange(TbCanSelect2, TagUtility.TagValues.CanSelect2_First);
        private void TbCanSelect3_TextChanged(object sender, EventArgs e)
            => CanTextChange(TbCanSelect3, TagUtility.TagValues.CanSelect3_First);

        // Can Select to Default
        private void BtnResetCanSelect_Click(object sender, EventArgs e)
        {
            TbCanSelect1.Text = KeyConverter.ToString(TagUtility.TagValues.CanSelect1_First.Default);
            TbCanSelect2.Text = KeyConverter.ToString(TagUtility.TagValues.CanSelect2_First.Default);
            TbCanSelect3.Text = KeyConverter.ToString(TagUtility.TagValues.CanSelect3_First.Default);
        }

        //! Can Cheats Text Changed
        private void TbCanCheats1_TextChanged(object sender, EventArgs e)
            => CanTextChange(TbCanCheats1, TagUtility.TagValues.CanCheats1_First);
        private void TbCanCheats2_TextChanged(object sender, EventArgs e)
            => CanTextChange(TbCanCheats2, TagUtility.TagValues.CanCheats2_First);
        private void TbCanCheats3_TextChanged(object sender, EventArgs e)
            => CanTextChange(TbCanCheats3, TagUtility.TagValues.CanCheats3_First);

        // Can Cheats to Default
        private void BtnResetCanCheats_Click(object sender, EventArgs e)
        {
            TbCanCheats1.Text = KeyConverter.ToString(TagUtility.TagValues.CanCheats1_First.Default);
            TbCanCheats2.Text = KeyConverter.ToString(TagUtility.TagValues.CanCheats2_First.Default);
            TbCanCheats3.Text = KeyConverter.ToString(TagUtility.TagValues.CanCheats3_First.Default);
        }

        // Level Transition Checkbox Changed
        private void CbLevelTransition_CheckedChanged(object sender, EventArgs e)
        {
            BtnLevelTransition.Enabled = !CbLevelTransition.Checked;
        }

		// Level Transition Color Picker
		private void BtnLevelTransition_Click(object sender, EventArgs e)
        {
            var colorpicker = new ColorPicker();
            var colorres = colorpicker.ShowDialog();
            if (colorres == DialogResult.OK)
            {
                // CS1690 fix: Copy the value to a local variable before accessing its members
                var selectedColor = colorpicker.SelectedColor;
                TagUtility.TagValues.LevelTransitionColor.Value = selectedColor.ToArgb();
                BtnLevelTransition.BackColor = selectedColor;
				BtnLevelTransition.ForeColor = selectedColor.GetBrightness() < 0.4 ? SystemColors.ControlLight : Color.Black;
			}
		}
    }

    public enum TagVersion
    {
        V1_0,
        V1_1
    }
}
