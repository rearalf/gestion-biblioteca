using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_biblioteca
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string correo;

        public Usuario(int id, string nombre, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
