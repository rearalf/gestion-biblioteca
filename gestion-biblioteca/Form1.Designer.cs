namespace gestion_biblioteca
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnViewUser = new Button();
            btnViewBook = new Button();
            btnViewBorrow = new Button();
            groupBox1 = new GroupBox();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            btnNewUser = new Button();
            btnSaveUser = new Button();
            txtUserEmail = new TextBox();
            txtUserName = new TextBox();
            txtUserId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvUsers = new DataGridView();
            button2 = new Button();
            label4 = new Label();
            btnClose = new Button();
            btnMinus = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnViewUser
            // 
            btnViewUser.BackColor = Color.White;
            btnViewUser.FlatAppearance.BorderSize = 0;
            btnViewUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnViewUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnViewUser.FlatStyle = FlatStyle.Flat;
            btnViewUser.Image = Properties.Resources.user;
            btnViewUser.Location = new Point(10, 131);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(82, 82);
            btnViewUser.TabIndex = 1;
            btnViewUser.UseVisualStyleBackColor = false;
            // 
            // btnViewBook
            // 
            btnViewBook.BackColor = Color.White;
            btnViewBook.FlatAppearance.BorderSize = 0;
            btnViewBook.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnViewBook.FlatAppearance.MouseOverBackColor = Color.White;
            btnViewBook.FlatStyle = FlatStyle.Flat;
            btnViewBook.Image = Properties.Resources.book;
            btnViewBook.Location = new Point(10, 219);
            btnViewBook.Name = "btnViewBook";
            btnViewBook.Size = new Size(82, 82);
            btnViewBook.TabIndex = 2;
            btnViewBook.UseVisualStyleBackColor = false;
            // 
            // btnViewBorrow
            // 
            btnViewBorrow.BackColor = Color.White;
            btnViewBorrow.FlatAppearance.BorderSize = 0;
            btnViewBorrow.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnViewBorrow.FlatAppearance.MouseOverBackColor = Color.White;
            btnViewBorrow.FlatStyle = FlatStyle.Flat;
            btnViewBorrow.Image = Properties.Resources.bookmark_alt;
            btnViewBorrow.Location = new Point(10, 307);
            btnViewBorrow.Name = "btnViewBorrow";
            btnViewBorrow.Size = new Size(82, 82);
            btnViewBorrow.TabIndex = 3;
            btnViewBorrow.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteUser);
            groupBox1.Controls.Add(btnUpdateUser);
            groupBox1.Controls.Add(btnNewUser);
            groupBox1.Controls.Add(btnSaveUser);
            groupBox1.Controls.Add(txtUserEmail);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtUserId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvUsers);
            groupBox1.Location = new Point(98, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(594, 346);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.White;
            btnDeleteUser.FlatAppearance.BorderColor = Color.White;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnDeleteUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Location = new Point(253, 135);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 10;
            btnDeleteUser.Text = "Eliminar";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.White;
            btnUpdateUser.FlatAppearance.BorderColor = Color.White;
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnUpdateUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Location = new Point(172, 135);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(75, 23);
            btnUpdateUser.TabIndex = 9;
            btnUpdateUser.Text = "Actualizar";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.White;
            btnNewUser.FlatAppearance.BorderColor = Color.White;
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnNewUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Location = new Point(91, 135);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(75, 23);
            btnNewUser.TabIndex = 8;
            btnNewUser.Text = "Nuevo";
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.White;
            btnSaveUser.FlatAppearance.BorderSize = 0;
            btnSaveUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnSaveUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnSaveUser.FlatStyle = FlatStyle.Flat;
            btnSaveUser.ForeColor = SystemColors.ControlText;
            btnSaveUser.Location = new Point(10, 135);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(75, 23);
            btnSaveUser.TabIndex = 7;
            btnSaveUser.Text = "Guardar";
            btnSaveUser.UseVisualStyleBackColor = false;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // txtUserEmail
            // 
            txtUserEmail.BackColor = SystemColors.Window;
            txtUserEmail.BorderStyle = BorderStyle.None;
            txtUserEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserEmail.Location = new Point(135, 82);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(237, 18);
            txtUserEmail.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Window;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(135, 51);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(237, 18);
            txtUserName.TabIndex = 5;
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.FromArgb(224, 224, 224);
            txtUserId.BorderStyle = BorderStyle.None;
            txtUserId.Enabled = false;
            txtUserId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserId.Location = new Point(135, 20);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(237, 18);
            txtUserId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(77, 85);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 1;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 23);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(6, 190);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(582, 150);
            dgvUsers.TabIndex = 11;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.chart_bar_rows;
            button2.Location = new Point(10, 43);
            button2.Name = "button2";
            button2.Size = new Size(82, 82);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(232, 25);
            label4.TabIndex = 0;
            label4.Text = "GESTIÓN DE BIBLIOTECA";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.BackgroundImage = Properties.Resources.x;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatAppearance.MouseOverBackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(663, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(29, 28);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.White;
            btnMinus.BackgroundImage = Properties.Resources.minus;
            btnMinus.BackgroundImageLayout = ImageLayout.None;
            btnMinus.FlatAppearance.BorderColor = Color.White;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnMinus.FlatAppearance.MouseOverBackColor = Color.White;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Location = new Point(628, 12);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(29, 28);
            btnMinus.TabIndex = 10;
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 401);
            Controls.Add(btnMinus);
            Controls.Add(btnClose);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnViewBorrow);
            Controls.Add(btnViewBook);
            Controls.Add(btnViewUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainForm";
            Text = "Gestión de Biblioteca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewUser;
        private Button btnViewBook;
        private Button btnViewBorrow;
        private GroupBox groupBox1;
        private DataGridView dgvUsers;
        private Button button2;
        private TextBox txtUserId;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUserEmail;
        private TextBox txtUserName;
        private Button btnSaveUser;
        private Button btnNewUser;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
        private Label label4;
        private Button btnClose;
        private Button btnMinus;
    }
}
