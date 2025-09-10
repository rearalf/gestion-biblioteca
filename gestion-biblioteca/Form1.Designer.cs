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
            btnViewUser.Location = new Point(11, 175);
            btnViewUser.Margin = new Padding(3, 4, 3, 4);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(94, 109);
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
            btnViewBook.Location = new Point(11, 292);
            btnViewBook.Margin = new Padding(3, 4, 3, 4);
            btnViewBook.Name = "btnViewBook";
            btnViewBook.Size = new Size(94, 109);
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
            btnViewBorrow.Location = new Point(11, 409);
            btnViewBorrow.Margin = new Padding(3, 4, 3, 4);
            btnViewBorrow.Name = "btnViewBorrow";
            btnViewBorrow.Size = new Size(94, 109);
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
            groupBox1.Location = new Point(112, 57);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(679, 461);
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
            btnDeleteUser.Location = new Point(291, 157);
            btnDeleteUser.Margin = new Padding(3, 4, 3, 4);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(86, 31);
            btnDeleteUser.TabIndex = 10;
            btnDeleteUser.Text = "Eliminar";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.White;
            btnUpdateUser.FlatAppearance.BorderColor = Color.White;
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnUpdateUser.FlatAppearance.MouseOverBackColor = Color.White;
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Location = new Point(199, 157);
            btnUpdateUser.Margin = new Padding(3, 4, 3, 4);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(86, 31);
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
            btnNewUser.Location = new Point(106, 157);
            btnNewUser.Margin = new Padding(3, 4, 3, 4);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(86, 31);
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
            btnSaveUser.Location = new Point(13, 157);
            btnSaveUser.Margin = new Padding(3, 4, 3, 4);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(86, 31);
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
            txtUserEmail.Location = new Point(171, 91);
            txtUserEmail.Margin = new Padding(3, 4, 3, 4);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(271, 22);
            txtUserEmail.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Window;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(171, 61);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(271, 22);
            txtUserName.TabIndex = 5;
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.FromArgb(224, 224, 224);
            txtUserId.BorderStyle = BorderStyle.None;
            txtUserId.Enabled = false;
            txtUserId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserId.Location = new Point(171, 31);
            txtUserId.Margin = new Padding(3, 4, 3, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(271, 22);
            txtUserId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(99, 91);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 1;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(11, 61);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 31);
            label1.Name = "label1";
            label1.Size = new Size(29, 23);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(6, 211);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(665, 242);
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
            button2.Location = new Point(11, 57);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 109);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(295, 32);
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
            btnClose.Location = new Point(758, 16);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 37);
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
            btnMinus.Location = new Point(718, 16);
            btnMinus.Margin = new Padding(3, 4, 3, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(33, 37);
            btnMinus.TabIndex = 10;
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 535);
            Controls.Add(btnMinus);
            Controls.Add(btnClose);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnViewBorrow);
            Controls.Add(btnViewBook);
            Controls.Add(btnViewUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "Gestión de Biblioteca";
            MouseDown += mainForm_MouseDown;
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
