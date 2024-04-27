using System;
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
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            baseList.SelectedIndex = Settings.Default.selectedBase;
            answerBase.SelectedIndex = 2;
            lenTxb.Text = Settings.Default.enteredLength.ToString();
            label6.Text = "v" + Program.appVersion;
        }

        private void genButton_Click(object sender, EventArgs e) {
            string selected = baseList.SelectedItem.ToString();
            if (selected == "") {
                MessageBox.Show("no number base selected", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                int len = 0;
                try {
                    len = int.Parse(lenTxb.Text);
                    Settings.Default.enteredLength = len;
                    Settings.Default.Save();
                } catch (Exception ex) {
                    MessageBox.Show("please enter a valid number length.\n\n" + ex.Message, Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("no number base selected", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("couldn't figure out the generated number base", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            answerLabel.Visible = true;
            switch (selectedAnswerBase) {
                case "Binary - 2":
                    try {
                        answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 2);
                    } catch (Exception) {
                        MessageBox.Show("error while converting base of generated number.", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Octal - 8":
                    try {
                        answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 8);
                    } catch (Exception) {
                        MessageBox.Show("error while converting base of generated number.", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } break;
                case "Decimal - 10":
                    try {
                        answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 10);
                    } catch (Exception) {
                        MessageBox.Show("error while converting base of generated number.", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } break;
                case "Hexadecimal - 16":
                    try {
                        answerLabel.Text = Convert.ToString(Convert.ToInt32(genTextbox.Text, fromBase), 16).ToUpper();
                    } catch (Exception) {
                        MessageBox.Show("error while converting base of generated number.", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } break;
                default:
                    MessageBox.Show("error while converting base of generated number.", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            timer1.Enabled = true;
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
            Clipboard.SetText(answerLabel.Text);
            MessageBox.Show("answer copied!", Program.msgTitle);
        }

        private void label6_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This is version "+Program.appVersion+".\nDo you want to check for newer versions?", Program.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                System.Diagnostics.Process.Start("https://github.com/alialmasi/radixconvertpractice/releases/latest/");
            }
        }
    }
}
