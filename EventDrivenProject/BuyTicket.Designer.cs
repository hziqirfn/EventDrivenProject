namespace EventDrivenProject
{
    partial class BuyTicket
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            showDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            showTimeBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            hallNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            HallType = new DataGridViewTextBoxColumn();
            totalSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hallBindingSource = new BindingSource(components);
            dataGridView3 = new DataGridView();
            cinemaNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cinemaBindingSource = new BindingSource(components);
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label18 = new Label();
            label19 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label20 = new Label();
            label21 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showTimeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hallBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cinemaBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 94);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(182, 35);
            label1.TabIndex = 0;
            label1.Text = "🎬 Buy Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 308);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 3;
            label2.Text = "Select Date";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 517);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 4;
            label3.Text = "Select Experiences";
            label3.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { showDateDataGridViewTextBoxColumn, startTimeDataGridViewTextBoxColumn, endTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = showTimeBindingSource;
            dataGridView1.Location = new Point(28, 360);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(681, 133);
            dataGridView1.TabIndex = 5;
            dataGridView1.Visible = false;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // showDateDataGridViewTextBoxColumn
            // 
            showDateDataGridViewTextBoxColumn.DataPropertyName = "ShowDate";
            showDateDataGridViewTextBoxColumn.HeaderText = "ShowDate";
            showDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            showDateDataGridViewTextBoxColumn.Name = "showDateDataGridViewTextBoxColumn";
            showDateDataGridViewTextBoxColumn.ReadOnly = true;
            showDateDataGridViewTextBoxColumn.Width = 255;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            startTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            startTimeDataGridViewTextBoxColumn.Width = 240;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            endTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            endTimeDataGridViewTextBoxColumn.Width = 240;
            // 
            // showTimeBindingSource
            // 
            showTimeBindingSource.DataSource = typeof(models.ShowTime);
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { hallNameDataGridViewTextBoxColumn, HallType, totalSeatsDataGridViewTextBoxColumn });
            dataGridView2.DataSource = hallBindingSource;
            dataGridView2.Location = new Point(28, 561);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(681, 133);
            dataGridView2.TabIndex = 6;
            dataGridView2.Visible = false;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // hallNameDataGridViewTextBoxColumn
            // 
            hallNameDataGridViewTextBoxColumn.DataPropertyName = "HallName";
            hallNameDataGridViewTextBoxColumn.HeaderText = "HallName";
            hallNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            hallNameDataGridViewTextBoxColumn.Name = "hallNameDataGridViewTextBoxColumn";
            hallNameDataGridViewTextBoxColumn.ReadOnly = true;
            hallNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // HallType
            // 
            HallType.DataPropertyName = "HallType";
            HallType.HeaderText = "HallType";
            HallType.MinimumWidth = 8;
            HallType.Name = "HallType";
            HallType.ReadOnly = true;
            HallType.Width = 250;
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.HeaderText = "TotalSeats";
            totalSeatsDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalSeatsDataGridViewTextBoxColumn.Name = "totalSeatsDataGridViewTextBoxColumn";
            totalSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            totalSeatsDataGridViewTextBoxColumn.Width = 200;
            // 
            // hallBindingSource
            // 
            hallBindingSource.DataSource = typeof(models.Hall);
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { cinemaNameDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn });
            dataGridView3.DataSource = cinemaBindingSource;
            dataGridView3.Location = new Point(28, 160);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(681, 133);
            dataGridView3.TabIndex = 8;
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;
            // 
            // cinemaNameDataGridViewTextBoxColumn
            // 
            cinemaNameDataGridViewTextBoxColumn.DataPropertyName = "CinemaName";
            cinemaNameDataGridViewTextBoxColumn.HeaderText = "CinemaName";
            cinemaNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            cinemaNameDataGridViewTextBoxColumn.Name = "cinemaNameDataGridViewTextBoxColumn";
            cinemaNameDataGridViewTextBoxColumn.ReadOnly = true;
            cinemaNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.MinimumWidth = 8;
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.ReadOnly = true;
            locationDataGridViewTextBoxColumn.Width = 600;
            // 
            // cinemaBindingSource
            // 
            cinemaBindingSource.DataSource = typeof(models.Cinema);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 108);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 7;
            label4.Text = "Select Cinema";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 718);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(421, 97);
            label5.Name = "label5";
            label5.Size = new Size(198, 23);
            label5.TabIndex = 16;
            label5.Text = "Double click the selection";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(1, 11);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 17;
            label6.Text = "Cinema Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(1, 69);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 18;
            label7.Text = "Location:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(97, 69);
            label8.MaximumSize = new Size(200, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 25);
            label8.TabIndex = 19;
            label8.Text = "......";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(142, 11);
            label9.MaximumSize = new Size(200, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 25);
            label9.TabIndex = 20;
            label9.Text = "......";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(715, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 168);
            panel2.TabIndex = 21;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(715, 360);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 133);
            panel3.TabIndex = 22;
            panel3.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(1, 94);
            label18.Name = "label18";
            label18.Size = new Size(96, 25);
            label18.TabIndex = 21;
            label18.Text = "End Time:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F);
            label19.Location = new Point(100, 94);
            label19.MaximumSize = new Size(200, 0);
            label19.Name = "label19";
            label19.Size = new Size(36, 25);
            label19.TabIndex = 22;
            label19.Text = "......";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(1, 11);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 17;
            label10.Text = "Show Date:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(109, 11);
            label11.MaximumSize = new Size(200, 0);
            label11.Name = "label11";
            label11.Size = new Size(36, 25);
            label11.TabIndex = 20;
            label11.Text = "......";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(1, 54);
            label12.Name = "label12";
            label12.Size = new Size(106, 25);
            label12.TabIndex = 18;
            label12.Text = "Start Time:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(105, 54);
            label13.MaximumSize = new Size(200, 0);
            label13.Name = "label13";
            label13.Size = new Size(36, 25);
            label13.TabIndex = 19;
            label13.Text = "......";
            // 
            // panel4
            // 
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label21);
            panel4.Location = new Point(716, 561);
            panel4.Name = "panel4";
            panel4.Size = new Size(351, 133);
            panel4.TabIndex = 23;
            panel4.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(1, 94);
            label14.Name = "label14";
            label14.Size = new Size(101, 25);
            label14.TabIndex = 21;
            label14.Text = "Total Seat:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.Location = new Point(108, 94);
            label15.MaximumSize = new Size(200, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 25);
            label15.TabIndex = 22;
            label15.Text = "......";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(1, 11);
            label16.Name = "label16";
            label16.Size = new Size(106, 25);
            label16.TabIndex = 17;
            label16.Text = "Hall Name:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(112, 11);
            label17.MaximumSize = new Size(200, 0);
            label17.Name = "label17";
            label17.Size = new Size(36, 25);
            label17.TabIndex = 20;
            label17.Text = "......";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.Location = new Point(1, 54);
            label20.Name = "label20";
            label20.Size = new Size(97, 25);
            label20.TabIndex = 18;
            label20.Text = "Hall Type:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F);
            label21.Location = new Point(104, 54);
            label21.MaximumSize = new Size(200, 0);
            label21.Name = "label21";
            label21.Size = new Size(36, 25);
            label21.TabIndex = 19;
            label21.Text = "......";
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(904, 718);
            button2.Name = "button2";
            button2.Size = new Size(150, 52);
            button2.TabIndex = 24;
            button2.Text = "Select Seat";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BuyTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 782);
            Controls.Add(button2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(dataGridView3);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "BuyTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Cinema Booking - Buy Ticket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showTimeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hallBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cinemaBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private BindingSource showTimeBindingSource;
        private DataGridView dataGridView3;
        private BindingSource cinemaBindingSource;
        private Label label4;
        private BindingSource hallBindingSource;
        private DataGridViewTextBoxColumn showDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private Button button1;
        private DataGridViewTextBoxColumn cinemaNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private Label label5;
        private DataGridViewTextBoxColumn hallNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn HallType;
        private DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Panel panel3;
        private Label label18;
        private Label label19;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel4;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label20;
        private Label label21;
        private Button button2;
    }
}