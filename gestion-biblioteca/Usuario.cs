using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_biblioteca
{
    public class Usuario
    {
        private string nombre;
        private int idUsuario;
        private string correo;
        private string telefono;
        private List<Prestamo> prestamos;

        public Usuario(string nombre, int idUsuario, string correo, string telefono)
        {
            this.nombre = nombre;
            this.idUsuario = idUsuario;
            this.correo = correo;
            this.telefono = telefono;
            this.prestamos = new List<Prestamo>();
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int IdUsuario { get { return idUsuario; } }
        public List<Prestamo> Prestamos { get { return prestamos; } }

        public string MostrarInfo()
        {
            return $"{nombre} | ID: {idUsuario} | Correo: {correo} | Tel: {telefono}";
        }

        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }
    }
}
