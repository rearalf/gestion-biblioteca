using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gestion_biblioteca
{
    public class Biblioteca
    {
        private List<Usuario> usuarios = new List<Usuario>();

        private Dictionary<int, Usuario> usuariosDict = new Dictionary<int, Usuario>();
        private Dictionary<int, int> userIdToRow = new Dictionary<int, int>();

        private int nextRowIndex = 0;
        private int nextUsuarioId = 1;
        private int maxUsuarios;

        public Biblioteca(int maxUsuarios = 100)
        {
            this.maxUsuarios = maxUsuarios;
        }

        public Usuario AgregarUsuario(string nombre, string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre inválido");
            if (string.IsNullOrWhiteSpace(correo)) throw new ArgumentException("Correo inválido");
            if (nextRowIndex >= maxUsuarios) throw new InvalidOperationException("Máximo de usuarios alcanzado.");

            int id = nextUsuarioId++;
            Usuario nuevoUsuario = new Usuario(id, nombre, correo);

            usuarios.Add(nuevoUsuario);
            usuariosDict[id] = nuevoUsuario;
            userIdToRow[id] = nextRowIndex++;
            return nuevoUsuario;
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }


    }
}
