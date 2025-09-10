using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gestion_biblioteca
{
    public partial class mainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public mainForm()
        {
            InitializeComponent();

            create_dgvUsers();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MouseDown += new MouseEventHandler(mainForm_MouseDown);
        }

        Biblioteca biblioteca = new Biblioteca();

        private void create_dgvUsers()
        {
            dgvUsers.ColumnCount = 3;
            dgvUsers.Columns[0].Name = "Id";
            dgvUsers.Columns[0].Width = 50;
            dgvUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns[1].Name = "Nombre completo";
            dgvUsers.Columns[1].Width = 225;
            dgvUsers.Columns[2].Name = "Correo";
            dgvUsers.Columns[2].Width = 225;

            DataGridViewColumn columnId = dgvUsers.Columns["Id"];
            columnId.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewColumn columnName = dgvUsers.Columns["Nombre completo"];
            columnName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewColumn columnEmail = dgvUsers.Columns["Correo"];
            columnEmail.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            refrescarUsuariosGrid();
        }

        private void mainForm_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (mainForm.ActiveForm != null)
                mainForm.ActiveForm.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (mainForm.ActiveForm != null)
                mainForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserId.Text.Trim()))
            {
                MessageBox.Show("Para crear un nuevo usuario, deje el campo Id vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                txtUserEmail.Clear();
                txtUserId.Clear();
                txtUserName.Focus();
                return;
            }

            string nombre = txtUserName.Text.Trim();
            string correo = txtUserEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Usuario nuevo = biblioteca.AgregarUsuario(nombre, correo);

                refrescarUsuariosGrid();
                txtUserName.Clear();
                txtUserEmail.Clear();
                MessageBox.Show($"Usuario creado con Id {nuevo.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtUserEmail.Clear();
            txtUserId.Clear();
            txtUserName.Focus();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUserId.Text = row.Cells[0].Value?.ToString();
                txtUserName.Text = row.Cells[1].Value?.ToString();
                txtUserEmail.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void refrescarUsuariosGrid()
        {
            dgvUsers.Rows.Clear();
            foreach (var usuario in biblioteca.ListarUsuarios())
            {
                dgvUsers.Rows.Add(usuario.Id, usuario.Nombre, usuario.Correo);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtUserId.Text.Trim(), out id))
            {
                MessageBox.Show("El Id ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombre = txtUserName.Text.Trim();
            string correo = txtUserEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || int.IsNegative(id))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                biblioteca.ActualizarUsuario(id, nombre, correo);

                refrescarUsuariosGrid();
                txtUserId.Clear();
                txtUserName.Clear();
                txtUserEmail.Clear();
                MessageBox.Show($"Usuario con Id {id} actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtUserId.Text.Trim(), out id))
            {
                MessageBox.Show("El Id ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            biblioteca.EliminarUsuario(id);
            refrescarUsuariosGrid();
            txtUserId.Clear();
            txtUserName.Clear();
            txtUserEmail.Clear();
            MessageBox.Show($"Usuario con Id {id} eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
