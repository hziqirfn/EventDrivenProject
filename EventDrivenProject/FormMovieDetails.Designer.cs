namespace EventDrivenProject
{
    partial class FormMovieDetails
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
            this.lblmoviename = new System.Windows.Forms.Label();
            this.lblgenre = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.pbposter = new System.Windows.Forms.PictureBox();
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
            this.pnlheader.Size = new System.Drawing.Size(800, 60);
            this.pnlheader.TabIndex = 3;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitle.Location = new System.Drawing.Point(12, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(197, 31);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "🎬 Movie Details";
            // 
            // lblmoviename
            // 
            this.lblmoviename.AutoSize = true;
            this.lblmoviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoviename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmoviename.Location = new System.Drawing.Point(281, 91);
            this.lblmoviename.Name = "lblmoviename";
            this.lblmoviename.Size = new System.Drawing.Size(102, 20);
            this.lblmoviename.TabIndex = 7;
            this.lblmoviename.Text = "Movie Name";
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblgenre.Location = new System.Drawing.Point(281, 144);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(55, 20);
            this.lblgenre.TabIndex = 8;
            this.lblgenre.Text = "Genre";
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblduration.Location = new System.Drawing.Point(281, 188);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(73, 20);
            this.lblduration.TabIndex = 9;
            this.lblduration.Text = "Duration";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldescription.Location = new System.Drawing.Point(281, 237);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(95, 20);
            this.lbldescription.TabIndex = 10;
            this.lbldescription.Text = "Description";
            // 
            // pbposter
            // 
            this.pbposter.Location = new System.Drawing.Point(37, 86);
            this.pbposter.Name = "pbposter";
            this.pbposter.Size = new System.Drawing.Size(207, 265);
            this.pbposter.TabIndex = 4;
            this.pbposter.TabStop = false;
            // 
            // FormMovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblgenre);
            this.Controls.Add(this.lblmoviename);
            this.Controls.Add(this.pbposter);
            this.Controls.Add(this.pnlheader);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormMovieDetails";
            this.Text = "Movie Details";
            this.Load += new System.EventHandler(this.FormMovieDetails_Load);
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbposter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pbposter;
        private System.Windows.Forms.Label lblmoviename;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lbldescription;
    }
}