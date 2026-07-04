namespace EventDrivenProject
{
    partial class AdminPanel
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
            LogoutBtn = new Button();
            label1 = new Label();
            btnViewUsers = new Button();
            btnDeleteUsers = new Button();
            btnViewSeats = new Button();
            btnResetSeats = new Button();
            dataGridView1 = new DataGridView();
            userTableAdapter1 = new EventDrivenProject.DataSet1TableAdapters.UserTableAdapter();
            HallIdTxtBox = new TextBox();
            label2 = new Label();
            BookedBtn = new Button();
            AvailableBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            AvailableCountTxt = new Label();
            BookedCountTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Gainsboro;
            LogoutBtn.FlatStyle = FlatStyle.Popup;
            LogoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.Location = new Point(700, 11);
            LogoutBtn.Margin = new Padding(2);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(89, 32);
            LogoutBtn.TabIndex = 119;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 45);
            label1.TabIndex = 120;
            label1.Text = "Welcome Admin!";
            // 
            // btnViewUsers
            // 
            btnViewUsers.BackColor = Color.Gainsboro;
            btnViewUsers.FlatStyle = FlatStyle.Popup;
            btnViewUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewUsers.Location = new Point(64, 343);
            btnViewUsers.Margin = new Padding(2);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(89, 32);
            btnViewUsers.TabIndex = 122;
            btnViewUsers.Text = "View Users";
            btnViewUsers.UseVisualStyleBackColor = false;
            btnViewUsers.Click += btnViewUsers_Click_1;
            // 
            // btnDeleteUsers
            // 
            btnDeleteUsers.BackColor = Color.Gainsboro;
            btnDeleteUsers.FlatStyle = FlatStyle.Popup;
            btnDeleteUsers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteUsers.Location = new Point(64, 407);
            btnDeleteUsers.Margin = new Padding(2);
            btnDeleteUsers.Name = "btnDeleteUsers";
            btnDeleteUsers.Size = new Size(89, 32);
            btnDeleteUsers.TabIndex = 123;
            btnDeleteUsers.Text = "Delete Users";
            btnDeleteUsers.UseVisualStyleBackColor = false;
            btnDeleteUsers.Click += btnDeleteUsers_Click_1;
            // 
            // btnViewSeats
            // 
            btnViewSeats.BackColor = Color.Gainsboro;
            btnViewSeats.FlatStyle = FlatStyle.Popup;
            btnViewSeats.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewSeats.Location = new Point(330, 365);
            btnViewSeats.Margin = new Padding(2);
            btnViewSeats.Name = "btnViewSeats";
            btnViewSeats.Size = new Size(89, 32);
            btnViewSeats.TabIndex = 125;
            btnViewSeats.Text = "View Seats";
            btnViewSeats.UseVisualStyleBackColor = false;
            btnViewSeats.Click += btnViewSeats_Click_1;
            // 
            // btnResetSeats
            // 
            btnResetSeats.BackColor = Color.Gainsboro;
            btnResetSeats.FlatStyle = FlatStyle.Popup;
            btnResetSeats.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetSeats.Location = new Point(330, 407);
            btnResetSeats.Margin = new Padding(2);
            btnResetSeats.Name = "btnResetSeats";
            btnResetSeats.Size = new Size(89, 32);
            btnResetSeats.TabIndex = 126;
            btnResetSeats.Text = "Reset Seats";
            btnResetSeats.UseVisualStyleBackColor = false;
            btnResetSeats.Click += btnResetSeats_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(699, 269);
            dataGridView1.TabIndex = 127;
            // 
            // userTableAdapter1
            // 
            userTableAdapter1.ClearBeforeFill = true;
            // 
            // HallIdTxtBox
            // 
            HallIdTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HallIdTxtBox.Location = new Point(177, 367);
            HallIdTxtBox.Name = "HallIdTxtBox";
            HallIdTxtBox.PlaceholderText = "Enter Hall Id";
            HallIdTxtBox.Size = new Size(100, 29);
            HallIdTxtBox.TabIndex = 128;
            HallIdTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 343);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 129;
            label2.Text = "Hall Id";
            // 
            // BookedBtn
            // 
            BookedBtn.BackColor = Color.Gainsboro;
            BookedBtn.FlatStyle = FlatStyle.Popup;
            BookedBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookedBtn.Location = new Point(455, 407);
            BookedBtn.Margin = new Padding(2);
            BookedBtn.Name = "BookedBtn";
            BookedBtn.Size = new Size(89, 32);
            BookedBtn.TabIndex = 130;
            BookedBtn.Text = "View Booked";
            BookedBtn.UseVisualStyleBackColor = false;
            BookedBtn.Click += BookedBtn_Click;
            // 
            // AvailableBtn
            // 
            AvailableBtn.BackColor = Color.Gainsboro;
            AvailableBtn.FlatStyle = FlatStyle.Popup;
            AvailableBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableBtn.Location = new Point(455, 367);
            AvailableBtn.Margin = new Padding(2);
            AvailableBtn.Name = "AvailableBtn";
            AvailableBtn.Size = new Size(89, 32);
            AvailableBtn.TabIndex = 131;
            AvailableBtn.Text = "View Available";
            AvailableBtn.UseVisualStyleBackColor = false;
            AvailableBtn.Click += AvailableBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(575, 411);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 132;
            label3.Text = "Booked :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(575, 370);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 133;
            label4.Text = "Available :";
            // 
            // AvailableCountTxt
            // 
            AvailableCountTxt.AutoSize = true;
            AvailableCountTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableCountTxt.Location = new Point(661, 370);
            AvailableCountTxt.Name = "AvailableCountTxt";
            AvailableCountTxt.Size = new Size(16, 21);
            AvailableCountTxt.TabIndex = 134;
            AvailableCountTxt.Text = "-";
            // 
            // BookedCountTxt
            // 
            BookedCountTxt.AutoSize = true;
            BookedCountTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookedCountTxt.Location = new Point(661, 411);
            BookedCountTxt.Name = "BookedCountTxt";
            BookedCountTxt.Size = new Size(16, 21);
            BookedCountTxt.TabIndex = 135;
            BookedCountTxt.Text = "-";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookedCountTxt);
            Controls.Add(AvailableCountTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AvailableBtn);
            Controls.Add(BookedBtn);
            Controls.Add(label2);
            Controls.Add(HallIdTxtBox);
            Controls.Add(dataGridView1);
            Controls.Add(btnResetSeats);
            Controls.Add(btnViewSeats);
            Controls.Add(btnDeleteUsers);
            Controls.Add(btnViewUsers);
            Controls.Add(label1);
            Controls.Add(LogoutBtn);
            Name = "AdminPanel";
            Text = "AdminPanel";
            Load += AdminPanel_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogoutBtn;
        private Label label1;
        private Button btnViewUsers;
        private Button btnDeleteUsers;
        private Button btnViewSeats;
        private Button btnResetSeats;
        private DataGridView dataGridView1;
        private DataSet1TableAdapters.UserTableAdapter userTableAdapter1;
        private TextBox HallIdTxtBox;
        private Label label2;
        private Button BookedBtn;
        private Button AvailableBtn;
        private Label label3;
        private Label label4;
        private Label AvailableCountTxt;
        private Label BookedCountTxt;
    }
}