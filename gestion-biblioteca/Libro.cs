using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_biblioteca
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private int anio;
        private int cantidad;

        public Libro(string titulo, string autor, string genero, int anio, int cantidad)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.cantidad = cantidad;
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
        public int Anio 
        { 
            get { return anio; } 
            set { anio = value; } 
        }
        public int Cantidad 
        { 
            get { return cantidad; } 
            private set { cantidad = value; } 
        }

        public string MostrarInfo()
        {
            return $"{titulo} - {autor} ({anio}) | Disponibles: {cantidad}";
        }

        public bool Prestar()
        {
            if (cantidad > 0)
            {
                cantidad--;
                return true;
            }
            return false;
        }

        public void Devolver()
        {
            cantidad++;
        }
    }
}
