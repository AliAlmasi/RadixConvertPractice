using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadixConvertPractice {
    public partial class aboutForm: Form {
        public aboutForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://al1almasi.ir/RadixConvertPractice/");
        }

        private void button3_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://al1almasi.ir/");
        }

        private void button4_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/AliAlmasi/RadixConvertPractice/");
        }

        private void aboutForm_Load(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.label5, "RadixConvertPractice");
            tooltip.SetToolTip(this.button2, "https://al1almasi.ir/RadixConvertPractice/");
            tooltip.SetToolTip(this.button3, "https://al1almasi.ir/");
            tooltip.SetToolTip(this.button4, "https://github.com/AliAlmasi/RadixConvertPractice/");
        }
    }
}
