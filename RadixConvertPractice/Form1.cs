﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RadixConvertPractice;
using RadixConvertPractice.Properties;

namespace RadixConvertPractice {
    public partial class Form1: Form {
        public static bool hasFirstGenerated = false; // checks if anything has beem generated from the time program started.
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Text = Program.msgTitle;
            baseList.SelectedIndex = Settings.Default.selectedBase;
            answerBase.SelectedIndex = 2;
            lenTxb.Text = Settings.Default.enteredLength.ToString();
            label6.Text = "v" + Program.appVersion;
            ToolTip history_tp = new ToolTip();
            history_tp.SetToolTip(this.button2, this.button2.Tag.ToString());
            ToolTip exit_tp = new ToolTip();
            exit_tp.SetToolTip(this.button1, this.button1.Tag.ToString());
        }

        private void genButton_Click(object sender, EventArgs e) {
            hasFirstGenerated = true;
            string selected = baseList.SelectedItem.ToString();
            if (selected == "") {
                Program.showError("No number base selected");
            } else {
                int len = 0;
                try {
                    len = int.Parse(lenTxb.Text);
                    Settings.Default.enteredLength = len;
                    Settings.Default.Save();
                } catch (Exception ex) {
                    Program.showError("Please enter a valid number length.\n\n" + ex.Message);
                }
                switch (selected) {
                    case "Binary - 2":
                        string binGen = Program.generateBinary(len);
                        genTextbox.Text = binGen;
                        break;
                    case "Octal - 8":
                        string octGen = Program.generateOctal(len);
                        genTextbox.Text = octGen;
                        break;
                    case "Decimal - 10":
                        string decGen = Program.generateDecimal(len);
                        genTextbox.Text = decGen;
                        break;
                    case "Hexadecimal - 16":
                        string hexGen = Program.generateHexadecimal(len);
                        genTextbox.Text = hexGen;
                        break;
                    default:
                        Program.showError("No number base selected");
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            answerLabel.Visible = false;
            timer1.Enabled = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox) sender;
            Settings.Default.selectedBase = comboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void answerButton_Click(object sender, EventArgs e) {
            if (hasFirstGenerated) {
                if (genTextbox.Text == "error") {
                    Program.showError("Generate a number first.");
                    return;
                }
                if (timer1.Enabled) {
                    timer1.Stop();
                    timer1.Start();
                }
                string selectedAnswerBase = answerBase.SelectedItem.ToString();
                int fromBase = 0;
                switch (baseList.SelectedIndex) {
                    case 0:
                        fromBase = 2;
                        break;
                    case 1:
                        fromBase = 8;
                        break;
                    case 2:
                        fromBase = 10;
                        break;
                    case 3:
                        fromBase = 16;
                        break;
                    default:
                        Program.showError("Couldn't understand the generated number base. Please check again.");
                        break;
                }
                answerLabel.Visible = true;
                switch (selectedAnswerBase) {
                    case "Binary - 2":
                        try {
                            answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 2);
                        } catch (Exception) {
                            Program.showError("Error while converting base of generated number.");
                        }
                        break;
                    case "Octal - 8":
                        try {
                            answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 8);
                        } catch (Exception) {
                            Program.showError("Error while converting base of generated number.");
                        } break;
                    case "Decimal - 10":
                        try {
                            answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 10);
                        } catch (Exception) {
                            Program.showError("Error while converting base of generated number.");
                        } break;
                    case "Hexadecimal - 16":
                        try {
                            answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 16).ToUpper();
                        } catch (Exception) {
                            Program.showError("Error while converting base of generated number.");
                        } break;
                    default:
                        Program.showError("Error while converting base of generated number.");
                        break;
                }
                Form2.history += "Generated base: "+ baseList.SelectedItem.ToString() + Environment.NewLine + "Generated number: " + genTextbox.Text + Environment.NewLine + Environment.NewLine + "Answer base: " + selectedAnswerBase + Environment.NewLine + "Answer number: " + answerLabel.Text + Environment.NewLine + "~~~~~~~~" + Environment.NewLine;
                timer1.Enabled = true;
            } else Program.showError("Generate a number first.");
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.Cursor = Cursors.SizeAll;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void answerLabel_Click(object sender, EventArgs e) {
            if (hasFirstGenerated) {
                Clipboard.SetText(answerLabel.Text);
                Program.showError("answer copied!");
            } else Program.showError("nothing to copy. Generate a number first.");
        }

        private void label6_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This is version " + Program.appVersion + "\nDo you want to check for newer versions?", Program.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                System.Diagnostics.Process.Start("https://github.com/alialmasi/radixconvertpractice/releases/latest/");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
