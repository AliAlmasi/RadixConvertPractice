using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RadixConvertPractice {
    public partial class Form2: Form {
        public static string history = "";
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            this.Text = Program.msgTitle;
            textBox1.Text = history;
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox1.Clear();
            history = "";
            MessageBox.Show("History is cleared", Program.msgTitle);
        }

        private void button1_Click(object sender, EventArgs e) {
            SaveFileDialog savefile = new SaveFileDialog {
                InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal)), "Documents"),
                Title = "Save history as text file - " + Program.msgTitle,
                CheckFileExists = false,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text file|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (savefile.ShowDialog() == DialogResult.OK) {
                try {
                    StreamWriter sw = new StreamWriter(savefile.FileName);
                    sw.Write(textBox1.Text);
                    sw.Close();
                    MessageBox.Show("Saved successfully." + Environment.NewLine + "File name: " + savefile.FileName, Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Text = "Notepad - " + savefile.FileName;
                } catch (Exception ex) {
                    Program.showError(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("All history was copied.", Program.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
