namespace EventDrivenProject
{
    partial class MovieSelect
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
            label1 = new Label();
            pbmovie = new PictureBox();
            label3 = new Label();
            lblmoviename = new Label();
            btnnext = new Button();
            btnprev = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbmovie).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 23);
            label1.TabIndex = 0;
            label1.Text = "🎬 Smart Cinema Booking";
            // 
            // pbmovie
            // 
            pbmovie.Image = Properties.Resources.TheSuperMarioGalaxyMovie_big;
            pbmovie.Location = new Point(192, 70);
            pbmovie.Margin = new Padding(2);
            pbmovie.Name = "pbmovie";
            pbmovie.Size = new Size(350, 338);
            pbmovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pbmovie.TabIndex = 1;
            pbmovie.TabStop = false;
            pbmovie.Click += pbmovie_Click;
            pbmovie.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(268, 441);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 15);
            label3.TabIndex = 5;
            label3.Text = "Double click poster to view details";
            // 
            // lblmoviename
            // 
            lblmoviename.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmoviename.Location = new Point(192, 409);
            lblmoviename.Margin = new Padding(2, 0, 2, 0);
            lblmoviename.Name = "lblmoviename";
            lblmoviename.Size = new Size(350, 22);
            lblmoviename.TabIndex = 6;
            lblmoviename.Text = "Movie Name";
            lblmoviename.TextAlign = ContentAlignment.MiddleCenter;
            lblmoviename.Click += lblmoviename_Click;
            // 
            // btnnext
            // 
            btnnext.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnext.Location = new Point(591, 212);
            btnnext.Margin = new Padding(2);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(61, 44);
            btnnext.TabIndex = 7;
            btnnext.Text = "▶";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnprev
            // 
            btnprev.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnprev.Location = new Point(88, 212);
            btnprev.Margin = new Padding(2);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(61, 44);
            btnprev.TabIndex = 8;
            btnprev.Text = "◀";
            btnprev.UseVisualStyleBackColor = true;
            btnprev.Click += btnprev_Click;
            // 
            // MovieSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 462);
            Controls.Add(btnnext);
            Controls.Add(lblmoviename);
            Controls.Add(label3);
            Controls.Add(btnprev);
            Controls.Add(pbmovie);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MovieSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Cinema Booking - Select Movie";
            Load += MovieSelect_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbmovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pbmovie;
        private Button btnprev;
        private Button btnnext;
        private Label label3;
        private Label label2;
        private Label lblmoviename;
      
    }
}