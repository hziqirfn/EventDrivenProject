namespace EventDrivenProject
{
    partial class FormMovieSelection
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
            this.pnlheader = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.pbposter = new System.Windows.Forms.PictureBox();
            this.lvlmoviename = new System.Windows.Forms.Label();
            this.lblhint = new System.Windows.Forms.Label();
            this.pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbposter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.Controls.Add(this.lbltitle);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(962, 60);
            this.pnlheader.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitle.Location = new System.Drawing.Point(12, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(291, 31);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "🎬 Smart Cinema Booking";
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprev.Location = new System.Drawing.Point(131, 198);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(75, 60);
            this.btnprev.TabIndex = 3;
            this.btnprev.Text = "◀";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(725, 198);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 60);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "▶";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // pbposter
            // 
            this.pbposter.Location = new System.Drawing.Point(212, 85);
            this.pbposter.Name = "pbposter";
            this.pbposter.Size = new System.Drawing.Size(500, 270);
            this.pbposter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbposter.TabIndex = 5;
            this.pbposter.TabStop = false;
            this.pbposter.DoubleClick += new System.EventHandler(this.pbposter_DoubleClick);
            // 
            // lvlmoviename
            // 
            this.lvlmoviename.AutoSize = true;
            this.lvlmoviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlmoviename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlmoviename.Location = new System.Drawing.Point(400, 388);
            this.lvlmoviename.Name = "lvlmoviename";
            this.lvlmoviename.Size = new System.Drawing.Size(122, 25);
            this.lvlmoviename.TabIndex = 6;
            this.lvlmoviename.Text = "Movie Name";
            // 
            // lblhint
            // 
            this.lblhint.AutoSize = true;
            this.lblhint.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblhint.Location = new System.Drawing.Point(358, 447);
            this.lblhint.Name = "lblhint";
            this.lblhint.Size = new System.Drawing.Size(209, 16);
            this.lblhint.TabIndex = 7;
            this.lblhint.Text = "Double click poster to view details";
            // 
            // FormMovieSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(962, 525);
            this.Controls.Add(this.lblhint);
            this.Controls.Add(this.lvlmoviename);
            this.Controls.Add(this.pbposter);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.pnlheader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMovieSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Cinema Booking - Select Movie";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbposter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.PictureBox pbposter;
        private System.Windows.Forms.Label lvlmoviename;
        private System.Windows.Forms.Label lblhint;
    }
}