namespace RadixConvertPractice {
    partial class mainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
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
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(294, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 48);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Tag = "Exit";
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseList
            // 
            this.baseList.BackColor = System.Drawing.SystemColors.WindowText;
            this.baseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseList.Font = new System.Drawing.Font("Arial", 11.25F);
            this.baseList.ForeColor = System.Drawing.SystemColors.Window;
            this.baseList.FormattingEnabled = true;
            this.baseList.Items.AddRange(new object[] {
            "Binary - 2",
            "Octal - 8",
            "Decimal - 10",
            "Hexadecimal - 16"});
            this.baseList.Location = new System.Drawing.Point(174, 65);
            this.baseList.Name = "baseList";
            this.baseList.Size = new System.Drawing.Size(141, 25);
            this.baseList.TabIndex = 1;
            this.baseList.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select number base:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // answerButton
            // 
            this.answerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.answerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton.Font = new System.Drawing.Font("Arial", 11.25F);
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
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter number length:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // lenTxb
            // 
            this.lenTxb.BackColor = System.Drawing.SystemColors.WindowText;
            this.lenTxb.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lenTxb.ForeColor = System.Drawing.SystemColors.Window;
            this.lenTxb.Location = new System.Drawing.Point(174, 115);
            this.lenTxb.Name = "lenTxb";
            this.lenTxb.Size = new System.Drawing.Size(141, 25);
            this.lenTxb.TabIndex = 6;
            // 
            // genTextbox
            // 
            this.genTextbox.BackColor = System.Drawing.Color.Black;
            this.genTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genTextbox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.genTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.genTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.genTextbox.Location = new System.Drawing.Point(27, 203);
            this.genTextbox.Name = "genTextbox";
            this.genTextbox.Size = new System.Drawing.Size(288, 25);
            this.genTextbox.TabIndex = 7;
            this.genTextbox.TabStop = false;
            this.genTextbox.Text = "See generated number here";
            this.genTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(28, 318);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(288, 28);
            this.answerLabel.TabIndex = 8;
            this.answerLabel.Text = "See answer here";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.Visible = false;
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // genButton
            // 
            this.genButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.genButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.genButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButton.Font = new System.Drawing.Font("Arial", 11.25F);
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
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.Location = new System.Drawing.Point(25, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select answer base:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // answerBase
            // 
            this.answerBase.BackColor = System.Drawing.SystemColors.WindowText;
            this.answerBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answerBase.Font = new System.Drawing.Font("Arial", 11.25F);
            this.answerBase.ForeColor = System.Drawing.SystemColors.Window;
            this.answerBase.FormattingEnabled = true;
            this.answerBase.Items.AddRange(new object[] {
            "Binary - 2",
            "Octal - 8",
            "Decimal - 10",
            "Hexadecimal - 16"});
            this.answerBase.Location = new System.Drawing.Point(174, 250);
            this.answerBase.Name = "answerBase";
            this.answerBase.Size = new System.Drawing.Size(141, 25);
            this.answerBase.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label4.Location = new System.Drawing.Point(-12, -8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 55);
            this.label4.TabIndex = 12;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.Help;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "RadixConvertPractice";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "v0.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(317, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 15;
            this.button2.Tag = "Show History";
            this.button2.Text = "H";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
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
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

