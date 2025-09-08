using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_biblioteca
{
    public class Prestamo
    {
        public Libro Libro { get; private set; }
        public Usuario Usuario { get; private set; }
        public DateTime FechaPrestamo { get; private set; }
        public DateTime? FechaDevolucion { get; private set; }
    }
}
