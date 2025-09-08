using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_biblioteca
{
    public class Prestamo
    {
        public int Id { get; private set; }
        public Libro Libro { get; private set; }
        public Usuario Usuario { get; private set; }
        public DateTime FechaPrestamo { get; private set; }
        public DateTime? FechaDevolucion { get; private set; }

        public Prestamo(int id, Usuario usuario, Libro libro)
        {
            Id = id;
            Usuario = usuario;
            Libro = libro;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = null;
        }
    }
}
