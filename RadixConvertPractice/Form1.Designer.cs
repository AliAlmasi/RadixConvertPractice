namespace RadixConvertPractice {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.baseList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lenTxb = new System.Windows.Forms.TextBox();
            this.genTextbox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.answerBase = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseList
            // 
            this.baseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseList.FormattingEnabled = true;
            this.baseList.Items.AddRange(new object[] {
            "Binary - 2",
            "Octal - 8",
            "Decimal - 10",
            "Hexadecimal - 16"});
            this.baseList.Location = new System.Drawing.Point(185, 65);
            this.baseList.Name = "baseList";
            this.baseList.Size = new System.Drawing.Size(130, 26);
            this.baseList.TabIndex = 1;
            this.baseList.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a number base:";
            // 
            // answerButton
            // 
            this.answerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton.Location = new System.Drawing.Point(28, 283);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(288, 28);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "Give me the answer";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter number length:";
            // 
            // lenTxb
            // 
            this.lenTxb.Location = new System.Drawing.Point(185, 115);
            this.lenTxb.Name = "lenTxb";
            this.lenTxb.Size = new System.Drawing.Size(130, 24);
            this.lenTxb.TabIndex = 6;
            // 
            // genTextbox
            // 
            this.genTextbox.Location = new System.Drawing.Point(27, 203);
            this.genTextbox.Name = "genTextbox";
            this.genTextbox.ReadOnly = true;
            this.genTextbox.Size = new System.Drawing.Size(288, 24);
            this.genTextbox.TabIndex = 7;
            this.genTextbox.TabStop = false;
            this.genTextbox.Text = "See generated number here";
            this.genTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(27, 316);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(288, 28);
            this.answerLabel.TabIndex = 8;
            this.answerLabel.Text = "See answer here";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.Visible = false;
            // 
            // genButton
            // 
            this.genButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.genButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButton.Location = new System.Drawing.Point(28, 167);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(287, 28);
            this.genButton.TabIndex = 9;
            this.genButton.Text = "Generate number";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select answer base:";
            // 
            // answerBase
            // 
            this.answerBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answerBase.FormattingEnabled = true;
            this.answerBase.Items.AddRange(new object[] {
            "Binary - 2",
            "Octal - 8",
            "Decimal - 10",
            "Hexadecimal - 16"});
            this.answerBase.Location = new System.Drawing.Point(186, 250);
            this.answerBase.Name = "answerBase";
            this.answerBase.Size = new System.Drawing.Size(129, 26);
            this.answerBase.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(-12, -8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 55);
            this.label4.TabIndex = 12;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "RadixConvertPractice";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerBase);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.genTextbox);
            this.Controls.Add(this.lenTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadixConvertPractice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox baseList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lenTxb;
        private System.Windows.Forms.TextBox genTextbox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox answerBase;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

