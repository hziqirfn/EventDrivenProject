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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Gainsboro;
            LogoutBtn.FlatStyle = FlatStyle.Popup;
            LogoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.Location = new Point(912, 15);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(127, 53);
            LogoutBtn.TabIndex = 119;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(417, 65);
            label1.TabIndex = 120;
            label1.Text = "Welcome Admin!";
            // 
            // btnViewUsers
            // 
            btnViewUsers.BackColor = Color.Gainsboro;
            btnViewUsers.FlatStyle = FlatStyle.Popup;
            btnViewUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewUsers.Location = new Point(40, 446);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(127, 53);
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
            btnDeleteUsers.Location = new Point(40, 529);
            btnDeleteUsers.Name = "btnDeleteUsers";
            btnDeleteUsers.Size = new Size(127, 53);
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
            btnViewSeats.Location = new Point(912, 446);
            btnViewSeats.Name = "btnViewSeats";
            btnViewSeats.Size = new Size(127, 53);
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
            btnResetSeats.Location = new Point(912, 529);
            btnResetSeats.Name = "btnResetSeats";
            btnResetSeats.Size = new Size(127, 53);
            btnResetSeats.TabIndex = 126;
            btnResetSeats.Text = "Reset Seats";
            btnResetSeats.UseVisualStyleBackColor = false;
            btnResetSeats.Click += btnResetSeats_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 85);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(999, 343);
            dataGridView1.TabIndex = 127;
            // 
            // userTableAdapter1
            // 
            userTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 593);
            Controls.Add(dataGridView1);
            Controls.Add(btnResetSeats);
            Controls.Add(btnViewSeats);
            Controls.Add(btnDeleteUsers);
            Controls.Add(btnViewUsers);
            Controls.Add(label1);
            Controls.Add(LogoutBtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Cinema Booking - Admin";
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
    }
}