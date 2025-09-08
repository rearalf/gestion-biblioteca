using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_biblioteca
{
    public class Libro
    {
        private int id;
        private string titulo;
        private string autor;
        private int cantidad;

        public Libro(int id, string titulo, string autor, int cantidad)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.cantidad = cantidad;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}
