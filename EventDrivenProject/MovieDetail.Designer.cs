namespace EventDrivenProject
{
    partial class MovieDetail
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
            Hallidlabel = new Label();
            label2 = new Label();
            label1 = new Label();
            lblmoviename = new Label();
            lblgenre = new Label();
            lblduration = new Label();
            lbldescription = new Label();
            pictureBox1 = new PictureBox();
            lblrelease = new Label();
            lbltxtrelease = new Label();
            lbltxtdescription = new Label();
            lbltxtduration = new Label();
            lbltextgenre = new Label();
            lbltxtmoviename = new Label();
            btnbuyticket = new Button();
            btnback = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Hallidlabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 56);
            panel1.TabIndex = 1;
            // 
            // Hallidlabel
            // 
            Hallidlabel.AutoSize = true;
            Hallidlabel.Font = new Font("Segoe UI", 10F);
            Hallidlabel.Location = new Point(675, 20);
            Hallidlabel.Margin = new Padding(2, 0, 2, 0);
            Hallidlabel.Name = "Hallidlabel";
            Hallidlabel.Size = new Size(32, 19);
            Hallidlabel.TabIndex = 18;
            Hallidlabel.Text = "text";
            Hallidlabel.Click += Hallidlabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(613, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 18;
            label2.Text = "Hall ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 0;
            label1.Text = "🎬 Movie Detail\r\n";
            // 
            // lblmoviename
            // 
            lblmoviename.AutoSize = true;
            lblmoviename.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblmoviename.Location = new Point(264, 81);
            lblmoviename.Margin = new Padding(2, 0, 2, 0);
            lblmoviename.Name = "lblmoviename";
            lblmoviename.Size = new Size(99, 19);
            lblmoviename.TabIndex = 5;
            lblmoviename.Text = "Movie Name:";
            // 
            // lblgenre
            // 
            lblgenre.AutoSize = true;
            lblgenre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblgenre.Location = new Point(264, 113);
            lblgenre.Margin = new Padding(2, 0, 2, 0);
            lblgenre.Name = "lblgenre";
            lblgenre.Size = new Size(53, 19);
            lblgenre.TabIndex = 6;
            lblgenre.Text = "Genre:";
            // 
            // lblduration
            // 
            lblduration.AutoSize = true;
            lblduration.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblduration.Location = new Point(264, 147);
            lblduration.Margin = new Padding(2, 0, 2, 0);
            lblduration.Name = "lblduration";
            lblduration.Size = new Size(71, 19);
            lblduration.TabIndex = 6;
            lblduration.Text = "Duration:";
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbldescription.Location = new Point(263, 216);
            lbldescription.Margin = new Padding(2, 0, 2, 0);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new Size(89, 19);
            lbldescription.TabIndex = 6;
            lbldescription.Text = "Description:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 71);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblrelease
            // 
            lblrelease.AutoSize = true;
            lblrelease.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblrelease.Location = new Point(262, 182);
            lblrelease.Margin = new Padding(2, 0, 2, 0);
            lblrelease.Name = "lblrelease";
            lblrelease.Size = new Size(99, 19);
            lblrelease.TabIndex = 8;
            lblrelease.Text = "Release Date:";
            // 
            // lbltxtrelease
            // 
            lbltxtrelease.AutoSize = true;
            lbltxtrelease.Font = new Font("Segoe UI", 10F);
            lbltxtrelease.Location = new Point(365, 182);
            lbltxtrelease.Margin = new Padding(2, 0, 2, 0);
            lbltxtrelease.Name = "lbltxtrelease";
            lbltxtrelease.Size = new Size(32, 19);
            lbltxtrelease.TabIndex = 13;
            lbltxtrelease.Text = "text";
            lbltxtrelease.Click += lbltxtrelease_Click;
            // 
            // lbltxtdescription
            // 
            lbltxtdescription.Font = new Font("Segoe UI", 10F);
            lbltxtdescription.Location = new Point(365, 216);
            lbltxtdescription.Margin = new Padding(2, 0, 2, 0);
            lbltxtdescription.Name = "lbltxtdescription";
            lbltxtdescription.Size = new Size(307, 77);
            lbltxtdescription.TabIndex = 10;
            lbltxtdescription.Text = "text";
            lbltxtdescription.Click += lbltxtdescription_Click;
            // 
            // lbltxtduration
            // 
            lbltxtduration.AutoSize = true;
            lbltxtduration.Font = new Font("Segoe UI", 10F);
            lbltxtduration.Location = new Point(365, 147);
            lbltxtduration.Margin = new Padding(2, 0, 2, 0);
            lbltxtduration.Name = "lbltxtduration";
            lbltxtduration.Size = new Size(32, 19);
            lbltxtduration.TabIndex = 11;
            lbltxtduration.Text = "text";
            lbltxtduration.Click += lbltxtduration_Click;
            // 
            // lbltextgenre
            // 
            lbltextgenre.AutoSize = true;
            lbltextgenre.Font = new Font("Segoe UI", 10F);
            lbltextgenre.Location = new Point(365, 113);
            lbltextgenre.Margin = new Padding(2, 0, 2, 0);
            lbltextgenre.Name = "lbltextgenre";
            lbltextgenre.Size = new Size(32, 19);
            lbltextgenre.TabIndex = 12;
            lbltextgenre.Text = "text";
            lbltextgenre.Click += lbltextgenre_Click;
            // 
            // lbltxtmoviename
            // 
            lbltxtmoviename.AutoSize = true;
            lbltxtmoviename.Font = new Font("Segoe UI", 10F);
            lbltxtmoviename.Location = new Point(365, 81);
            lbltxtmoviename.Margin = new Padding(2, 0, 2, 0);
            lbltxtmoviename.Name = "lbltxtmoviename";
            lbltxtmoviename.Size = new Size(32, 19);
            lbltxtmoviename.TabIndex = 9;
            lbltxtmoviename.Text = "text";
            lbltxtmoviename.Click += lbltxtmoviename_Click;
            // 
            // btnbuyticket
            // 
            btnbuyticket.BackColor = Color.Gainsboro;
            btnbuyticket.FlatStyle = FlatStyle.Popup;
            btnbuyticket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbuyticket.Location = new Point(594, 335);
            btnbuyticket.Margin = new Padding(2);
            btnbuyticket.Name = "btnbuyticket";
            btnbuyticket.Size = new Size(132, 32);
            btnbuyticket.TabIndex = 16;
            btnbuyticket.Text = "Buy Ticket Now";
            btnbuyticket.UseVisualStyleBackColor = false;
            btnbuyticket.Click += btnbuyticket_Click;
            // 
            // btnback
            // 
            btnback.BackColor = Color.Gainsboro;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnback.Location = new Point(276, 328);
            btnback.Margin = new Padding(2);
            btnback.Name = "btnback";
            btnback.Size = new Size(89, 32);
            btnback.TabIndex = 17;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // MovieDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 375);
            Controls.Add(btnback);
            Controls.Add(btnbuyticket);
            Controls.Add(lbltxtrelease);
            Controls.Add(lbltxtdescription);
            Controls.Add(lbltxtduration);
            Controls.Add(lbltextgenre);
            Controls.Add(lbltxtmoviename);
            Controls.Add(lblrelease);
            Controls.Add(pictureBox1);
            Controls.Add(lbldescription);
            Controls.Add(lblduration);
            Controls.Add(lblgenre);
            Controls.Add(lblmoviename);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MovieDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Cinema Booking - Movie Detail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblmoviename;
        private Label lblgenre;
        private Label lblduration;
        private Label lbldescription;
        private PictureBox pictureBox1;
        private Label lblrelease;
        private Label lbltxtrelease;
        private Label lbltxtdescription;
        private Label lbltxtduration;
        private Label lbltextgenre;
        private Label lbltxtmoviename;
        private Button btnbuyticket;
        private Button btnback;
        private Label Hallidlabel;
        private Label label2;
    }
}