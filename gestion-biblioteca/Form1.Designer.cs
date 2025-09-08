namespace gestion_biblioteca
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserId = new TextBox();
            txtUserName = new TextBox();
            txtUserEmail = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnViewUser
            // 
            btnViewUser.Image = Properties.Resources.user;
            btnViewUser.Location = new Point(12, 100);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(82, 82);
            btnViewUser.TabIndex = 0;
            btnViewUser.UseVisualStyleBackColor = true;
            // 
            // btnViewBook
            // 
            btnViewBook.Image = Properties.Resources.book;
            btnViewBook.Location = new Point(12, 188);
            btnViewBook.Name = "btnViewBook";
            btnViewBook.Size = new Size(82, 82);
            btnViewBook.TabIndex = 1;
            btnViewBook.UseVisualStyleBackColor = true;
            // 
            // btnViewBorrow
            // 
            btnViewBorrow.Image = Properties.Resources.bookmark_alt;
            btnViewBorrow.Location = new Point(12, 276);
            btnViewBorrow.Name = "btnViewBorrow";
            btnViewBorrow.Size = new Size(82, 82);
            btnViewBorrow.TabIndex = 1;
            btnViewBorrow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUserEmail);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtUserId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(100, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 346);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(683, 150);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.chart_bar_rows;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(82, 82);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 30);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(28, 61);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(95, 92);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 1;
            label3.Text = "Correo:";
            // 
            // txtUserId
            // 
            txtUserId.Enabled = false;
            txtUserId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserId.Location = new Point(153, 27);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(237, 25);
            txtUserId.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Enabled = false;
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(153, 58);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(237, 25);
            txtUserName.TabIndex = 2;
            // 
            // txtUserEmail
            // 
            txtUserEmail.Enabled = false;
            txtUserEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserEmail.Location = new Point(153, 89);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(237, 25);
            txtUserEmail.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnViewBorrow);
            Controls.Add(btnViewBook);
            Controls.Add(btnViewUser);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewUser;
        private Button btnViewBook;
        private Button btnViewBorrow;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox txtUserId;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUserEmail;
        private TextBox txtUserName;
    }
}
