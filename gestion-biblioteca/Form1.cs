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

            gbUsers.Visible = false;
            gbBooks.Visible = false;
            gbLoans.Visible = false;
            gbDashboard.Visible = true;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MouseDown += new MouseEventHandler(mainForm_MouseDown);
        }

        Biblioteca biblioteca = new Biblioteca();

        private int? selectedUserId = null;
        private int? selectedBookId = null;
        private Prestamo? prestamoSeleccionado = null;

        private void create_dgvUsers()
        {
            dgvUsers.ColumnCount = 3;
            dgvUsers.Columns[0].Name = "Id";
            dgvUsers.Columns[0].Width = 50;
            dgvUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns[1].Name = "Nombre completo";
            dgvUsers.Columns[1].Width = 260;
            dgvUsers.Columns[2].Name = "Correo";
            dgvUsers.Columns[2].Width = 260;

            DataGridViewColumn columnId = dgvUsers.Columns["Id"];
            columnId.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewColumn columnName = dgvUsers.Columns["Nombre completo"];
            columnName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewColumn columnEmail = dgvUsers.Columns["Correo"];
            columnEmail.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            refrescarUsuariosGrid();


            dgvBook.ColumnCount = 4;
            dgvBook.Columns[0].Name = "Id";
            dgvBook.Columns[0].Width = 50;
            dgvBook.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns[1].Name = "Titulo";
            dgvBook.Columns[1].Width = 225;
            dgvBook.Columns[2].Name = "Autor";
            dgvBook.Columns[2].Width = 225;
            dgvBook.Columns[3].Name = "Cantidad";
            dgvBook.Columns[3].Width = 100;
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

        private void btnViewDashboard_Click(object sender, EventArgs e)
        {
            gbUsers.Visible = false;
            gbBooks.Visible = false;
            gbLoans.Visible = false;
            gbDashboard.Visible = true;
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            gbUsers.Visible = true;
            gbBooks.Visible = false;
            gbLoans.Visible = false;
            gbDashboard.Visible = false;

        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            gbUsers.Visible = false;
            gbBooks.Visible = true;
            gbLoans.Visible = false;
            gbDashboard.Visible = false;
        }

        private void btnViewBorrow_Click(object sender, EventArgs e)
        {
            gbUsers.Visible = false;
            gbBooks.Visible = false;
            gbLoans.Visible = true;
            gbDashboard.Visible = false;

            dgvUserLoans.ColumnCount = 3;
            dgvUserLoans.Columns[0].Name = "Id";
            dgvUserLoans.Columns[0].Width = 50;
            dgvUserLoans.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUserLoans.Columns[1].Name = "Nombre completo";
            dgvUserLoans.Columns[1].Width = 260;
            dgvUserLoans.Columns[2].Name = "Correo";
            dgvUserLoans.Columns[2].Width = 260;

            DataGridViewColumn columnId = dgvUserLoans.Columns["Id"];
            columnId.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewColumn columnName = dgvUserLoans.Columns["Nombre completo"];
            columnName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewColumn columnEmail = dgvUserLoans.Columns["Correo"];
            columnEmail.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBookLoans.ColumnCount = 4;
            dgvBookLoans.Columns[0].Name = "Id";
            dgvBookLoans.Columns[0].Width = 50;
            dgvBookLoans.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookLoans.Columns[1].Name = "Titulo";
            dgvBookLoans.Columns[1].Width = 225;
            dgvBookLoans.Columns[2].Name = "Autor";
            dgvBookLoans.Columns[2].Width = 225;
            dgvBookLoans.Columns[3].Name = "Cantidad";
            dgvBookLoans.Columns[3].Width = 100;

            dgvLoans.ColumnCount = 5;
            dgvLoans.Columns[0].Name = "Id";
            dgvLoans.Columns[0].Width = 50;
            dgvLoans.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoans.Columns[1].Name = "Usuario";
            dgvLoans.Columns[1].Width = 200;
            dgvLoans.Columns[2].Name = "Libro";
            dgvLoans.Columns[2].Width = 200;
            dgvLoans.Columns[3].Name = "Fecha Préstamo";
            dgvLoans.Columns[3].Width = 100;
            dgvLoans.Columns[4].Name = "Fecha Devolución";
            dgvLoans.Columns[4].Width = 100;

            loanRefreshGrid();
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

        private void refrescarUsuariosGrid()
        {
            dgvUsers.Rows.Clear();
            foreach (var usuario in biblioteca.ListarUsuarios())
            {
                dgvUsers.Rows.Add(usuario.Id, usuario.Nombre, usuario.Correo);
            }
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBookId.Text.Trim()))
            {
                MessageBox.Show("Para crear un nuevo libro, deje el campo Id vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookId.Clear();
                txtTitleBook.Clear();
                txtAuthorBook.Clear();
                txtAmountBook.Clear();
                txtTitleBook.Focus();
                return;
            }

            string titulo = txtTitleBook.Text.Trim();
            string autor = txtAuthorBook.Text.Trim();
            int cantidad;
            if (!int.TryParse(txtAmountBook.Text.Trim(), out cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Libro nuevo = biblioteca.AgregarLibro(titulo, autor, cantidad);
                refrescarLibrosGrid();
                txtBookId.Clear();
                txtTitleBook.Clear();
                txtAuthorBook.Clear();
                txtAmountBook.Clear();
                MessageBox.Show($"Libro creado con Id {nuevo.Id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            txtBookId.Clear();
            txtTitleBook.Clear();
            txtAuthorBook.Clear();
            txtAmountBook.Clear();
            txtTitleBook.Focus();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBook.Rows[e.RowIndex];
                txtBookId.Text = row.Cells[0].Value?.ToString();
                txtTitleBook.Text = row.Cells[1].Value?.ToString();
                txtAuthorBook.Text = row.Cells[2].Value?.ToString();
                txtAmountBook.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtBookId.Text.Trim(), out id))
            {
                MessageBox.Show("El Id ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string titulo = txtTitleBook.Text.Trim();
            string autor = txtAuthorBook.Text.Trim();
            int cantidad;

            if (!int.TryParse(txtAmountBook.Text.Trim(), out cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                biblioteca.ActualizarLibro(id, titulo, autor, cantidad);

                refrescarLibrosGrid();
                txtBookId.Clear();
                txtTitleBook.Clear();
                txtAuthorBook.Clear();
                txtAmountBook.Clear();
                txtTitleBook.Focus();
                MessageBox.Show($"Libro con Id {id} actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtBookId.Text.Trim(), out id))
            {
                MessageBox.Show("El Id ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            biblioteca.EliminarLibro(id);
            refrescarLibrosGrid();
            txtBookId.Clear();
            txtTitleBook.Clear();
            txtAuthorBook.Clear();
            txtAmountBook.Clear();
            txtTitleBook.Focus();
            MessageBox.Show($"Libro con Id {id} eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refrescarLibrosGrid()
        {
            dgvBook.Rows.Clear();
            foreach (var libro in biblioteca.ListarLibros())
            {
                dgvBook.Rows.Add(libro.Id, libro.Titulo, libro.Autor, libro.Cantidad);
            }
        }

        private void dgvUserLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUserLoans.Rows[e.RowIndex];
                selectedUserId = (int)row.Cells[0].Value;
                txtLoanUser.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dgvBookLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookLoans.Rows[e.RowIndex];
                selectedBookId = (int)row.Cells[0].Value;
                txtLoanBook.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            if (selectedUserId == null || selectedBookId == null)
            {
                MessageBox.Show("Seleccione un usuario y un libro antes de registrar el préstamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                biblioteca.RegistrarPrestamo((int)selectedUserId, (int)selectedBookId);
                MessageBox.Show($"Préstamo registrado: Usuario Id {selectedUserId}, Libro Id {selectedBookId}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loanRefreshGrid();
                selectedUserId = null;
                selectedBookId = null;
                txtLoanUser.Clear();
                txtLoanBook.Clear();
                txtLoanId.Clear();
                txtLoanDevotionDate.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loanRefreshGrid()
        {
            dgvUserLoans.Rows.Clear();
            foreach (var usuario in biblioteca.ListarUsuarios())
            {
                dgvUserLoans.Rows.Add(usuario.Id, usuario.Nombre, usuario.Correo);
            }

            dgvBookLoans.Rows.Clear();
            foreach (var libro in biblioteca.ListarLibros())
            {
                dgvBookLoans.Rows.Add(libro.Id, libro.Titulo, libro.Autor, libro.Cantidad);
            }

            dgvLoans.Rows.Clear();
            foreach (var prestamo in biblioteca.ListarPrestamos())
            {
                string returnDate = prestamo.FechaDevolucion.HasValue ? prestamo.FechaDevolucion.Value.ToString("dd/MM/yyyy") : "No devuelto";
                dgvLoans.Rows.Add(prestamo.Id, prestamo.Usuario.Nombre, prestamo.Libro.Titulo, prestamo.FechaPrestamo.ToString("dd/MM/yyyy"), returnDate);
            }

            txtLoanDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnLoanClear_Click(object sender, EventArgs e)
        {
            selectedUserId = null;
            selectedBookId = null;
            txtLoanUser.Clear();
            txtLoanBook.Clear();
            txtLoanId.Clear();
            txtLoanDevotionDate.Clear();

            selectedUserId = null;
            selectedBookId = null;
            prestamoSeleccionado = null;
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoans.Rows[e.RowIndex];

                int prestamoId = Convert.ToInt32(row.Cells[0].Value);
                prestamoSeleccionado = biblioteca.ObtenerPrestamo(prestamoId);

                if (prestamoSeleccionado != null)
                {
                    txtLoanId.Text = prestamoSeleccionado.Id.ToString();
                    txtLoanUser.Text = prestamoSeleccionado.Usuario.Nombre;
                    txtLoanBook.Text = prestamoSeleccionado.Libro.Titulo;
                    txtLoanDate.Text = prestamoSeleccionado.FechaPrestamo.ToString("dd/MM/yyyy");
                    txtLoanDevotionDate.Text = prestamoSeleccionado.FechaDevolucion.HasValue ? prestamoSeleccionado.FechaDevolucion.Value.ToString("dd/MM/yyyy") : "No devuelto";
                }
            }
        }

        private void btnLoanDevotion_Click(object sender, EventArgs e)
        {
            if (prestamoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un préstamo para registrar la devolución.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                biblioteca.RegistrarDevolucion(prestamoSeleccionado.Id);
                MessageBox.Show($"Devolución registrada para el préstamo Id {prestamoSeleccionado.Id}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loanRefreshGrid();
                selectedUserId = null;
                selectedBookId = null;
                prestamoSeleccionado = null;
                txtLoanUser.Clear();
                txtLoanBook.Clear();
                txtLoanId.Clear();
                txtLoanDevotionDate.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la devolución: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
