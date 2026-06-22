namespace EventDrivenProject
{
    partial class Payment
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
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            CardNumTxtBox = new TextBox();
            ExpTxtBox = new TextBox();
            CVCTxtBox = new TextBox();
            NameTxtBox = new TextBox();
            groupBox1 = new GroupBox();
            CalculateTxt = new Label();
            TotalTxt = new Label();
            label1 = new Label();
            PicBoxName = new PictureBox();
            PicBoxCVC = new PictureBox();
            PicBoxExp = new PictureBox();
            PicBoxCardNum = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ConfirmBtn = new Button();
            BackBtn = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxCVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxExp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxCardNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 56);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 0;
            label2.Text = "🎬 Payment Method";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 23);
            label3.TabIndex = 1;
            label3.Text = "CREDIT / DEBIT CARD";
            // 
            // CardNumTxtBox
            // 
            CardNumTxtBox.Location = new Point(25, 84);
            CardNumTxtBox.Multiline = true;
            CardNumTxtBox.Name = "CardNumTxtBox";
            CardNumTxtBox.PlaceholderText = "Card Number";
            CardNumTxtBox.Size = new Size(551, 42);
            CardNumTxtBox.TabIndex = 3;
            CardNumTxtBox.TextChanged += CardNumTxtBox_TextChanged;
            // 
            // ExpTxtBox
            // 
            ExpTxtBox.Location = new Point(25, 141);
            ExpTxtBox.Multiline = true;
            ExpTxtBox.Name = "ExpTxtBox";
            ExpTxtBox.PlaceholderText = "Expiry Date";
            ExpTxtBox.Size = new Size(267, 42);
            ExpTxtBox.TabIndex = 4;
            ExpTxtBox.TextChanged += ExpTxtBox_TextChanged;
            // 
            // CVCTxtBox
            // 
            CVCTxtBox.Location = new Point(323, 141);
            CVCTxtBox.Multiline = true;
            CVCTxtBox.Name = "CVCTxtBox";
            CVCTxtBox.PlaceholderText = "CVC / CVV";
            CVCTxtBox.Size = new Size(253, 42);
            CVCTxtBox.TabIndex = 5;
            CVCTxtBox.TextChanged += CVCTxtBox_TextChanged;
            // 
            // NameTxtBox
            // 
            NameTxtBox.Location = new Point(25, 198);
            NameTxtBox.Multiline = true;
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.PlaceholderText = "Name on card";
            NameTxtBox.Size = new Size(551, 42);
            NameTxtBox.TabIndex = 6;
            NameTxtBox.TextChanged += NameTxtBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(CalculateTxt);
            groupBox1.Controls.Add(TotalTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PicBoxName);
            groupBox1.Controls.Add(PicBoxCVC);
            groupBox1.Controls.Add(PicBoxExp);
            groupBox1.Controls.Add(PicBoxCardNum);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(NameTxtBox);
            groupBox1.Controls.Add(CVCTxtBox);
            groupBox1.Controls.Add(ExpTxtBox);
            groupBox1.Controls.Add(CardNumTxtBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(16, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 307);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // CalculateTxt
            // 
            CalculateTxt.AutoSize = true;
            CalculateTxt.Location = new Point(497, 252);
            CalculateTxt.Name = "CalculateTxt";
            CalculateTxt.Size = new Size(12, 15);
            CalculateTxt.TabIndex = 15;
            CalculateTxt.Text = "-";
            // 
            // TotalTxt
            // 
            TotalTxt.AutoSize = true;
            TotalTxt.Location = new Point(497, 277);
            TotalTxt.Name = "TotalTxt";
            TotalTxt.Size = new Size(12, 15);
            TotalTxt.TabIndex = 14;
            TotalTxt.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 252);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 13;
            label1.Text = "Total:";
            // 
            // PicBoxName
            // 
            PicBoxName.BorderStyle = BorderStyle.Fixed3D;
            PicBoxName.Location = new Point(541, 208);
            PicBoxName.Name = "PicBoxName";
            PicBoxName.Size = new Size(23, 21);
            PicBoxName.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxName.TabIndex = 12;
            PicBoxName.TabStop = false;
            // 
            // PicBoxCVC
            // 
            PicBoxCVC.BorderStyle = BorderStyle.Fixed3D;
            PicBoxCVC.Location = new Point(541, 151);
            PicBoxCVC.Name = "PicBoxCVC";
            PicBoxCVC.Size = new Size(23, 21);
            PicBoxCVC.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxCVC.TabIndex = 11;
            PicBoxCVC.TabStop = false;
            // 
            // PicBoxExp
            // 
            PicBoxExp.BorderStyle = BorderStyle.Fixed3D;
            PicBoxExp.Location = new Point(259, 151);
            PicBoxExp.Name = "PicBoxExp";
            PicBoxExp.Size = new Size(23, 21);
            PicBoxExp.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxExp.TabIndex = 10;
            PicBoxExp.TabStop = false;
            // 
            // PicBoxCardNum
            // 
            PicBoxCardNum.BorderStyle = BorderStyle.Fixed3D;
            PicBoxCardNum.Location = new Point(541, 94);
            PicBoxCardNum.Name = "PicBoxCardNum";
            PicBoxCardNum.Size = new Size(23, 21);
            PicBoxCardNum.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBoxCardNum.TabIndex = 9;
            PicBoxCardNum.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.Mastercard;
            pictureBox2.Location = new Point(515, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Visa;
            pictureBox1.Location = new Point(440, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.Gainsboro;
            ConfirmBtn.FlatStyle = FlatStyle.Popup;
            ConfirmBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmBtn.Location = new Point(531, 394);
            ConfirmBtn.Margin = new Padding(2);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(91, 32);
            ConfirmBtn.TabIndex = 17;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Gainsboro;
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackBtn.Location = new Point(16, 394);
            BackBtn.Margin = new Padding(2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(89, 32);
            BackBtn.TabIndex = 18;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 450);
            Controls.Add(BackBtn);
            Controls.Add(ConfirmBtn);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Payment";
            Text = "Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBoxName).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxCVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxExp).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxCardNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox CardNumTxtBox;
        private TextBox ExpTxtBox;
        private TextBox CVCTxtBox;
        private TextBox NameTxtBox;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox PicBoxName;
        private PictureBox PicBoxCVC;
        private PictureBox PicBoxExp;
        private PictureBox PicBoxCardNum;
        private Button ConfirmBtn;
        private Button BackBtn;
        private Label CalculateTxt;
        private Label TotalTxt;
        private Label label1;
    }
}