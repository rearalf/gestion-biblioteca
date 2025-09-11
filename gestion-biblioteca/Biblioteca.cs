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
        /* 
         * Usuarios
         */
        private List<Usuario> usuarios = new List<Usuario>();

        private Dictionary<int, Usuario> usuariosDict = new Dictionary<int, Usuario>();
        private Dictionary<int, int> userIdToRow = new Dictionary<int, int>();
        
        private int nextRowIndex = 0;
        private int nextUsuarioId = 1;
        private int maxUsuarios;
        
        public Biblioteca(int maxUsuarios = 100, int maxLibros = 100)
        {
            this.maxUsuarios = maxUsuarios;
            this.maxLibros = maxLibros;
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

        public void ActualizarUsuario(int id, string nombre, string correo)
        {
            if (!usuariosDict.ContainsKey(id)) throw new KeyNotFoundException("Usuario no encontrado");
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre inválido");
            if (string.IsNullOrWhiteSpace(correo)) throw new ArgumentException("Correo inválido");
            Usuario usuario = usuariosDict[id];
            usuario.Nombre = nombre;
            usuario.Correo = correo;
        }

        public void EliminarUsuario(int id)
        {
            if (!usuariosDict.ContainsKey(id)) throw new KeyNotFoundException("Usuario no encontrado");
            Usuario usuario = usuariosDict[id];
            usuarios.Remove(usuario);
            usuariosDict.Remove(id);
            userIdToRow.Remove(id);
            nextRowIndex--;
        }


        /*
         * Libros
         */
        private List<Libro> libros = new List<Libro>();
        private Dictionary<int, Libro> librosDict = new Dictionary<int, Libro>();
        private Dictionary<int, int> libroIdToRow = new Dictionary<int, int>();

        private int nextRowLibroIndex = 0;
        private int nextLibroId = 1;
        private int maxLibros;

        public Libro AgregarLibro(string titulo, string autor, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("Título inválido");
            if (string.IsNullOrWhiteSpace(autor)) throw new ArgumentException("Autor inválido");
            if (cantidad < 0) throw new ArgumentException("Cantidad inválida");
            if (nextRowLibroIndex >= maxLibros) throw new InvalidOperationException($"Máximo de libros alcanzado. La cantidad máxima es de {maxLibros}.");
            int id = nextLibroId++;
            Libro nuevoLibro = new Libro(id, titulo, autor, cantidad);
            libros.Add(nuevoLibro);
            librosDict[id] = nuevoLibro;
            libroIdToRow[id] = nextRowLibroIndex++;
            return nuevoLibro;
        }

        public List<Libro> ListarLibros()
        {
            return libros;
        }

        public void ActualizarLibro(int id, string titulo, string autor, int cantidad)
        {
            if (!librosDict.ContainsKey(id)) throw new KeyNotFoundException("Libro no encontrado");
            if (string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("Título inválido");
            if (string.IsNullOrWhiteSpace(autor)) throw new ArgumentException("Autor inválido");
            if (cantidad < 0) throw new ArgumentException("Cantidad inválida");
            Libro libro = librosDict[id];
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Cantidad = cantidad;
        }

        public void EliminarLibro(int id)
        {
            if (!librosDict.ContainsKey(id)) throw new KeyNotFoundException("Libro no encontrado");
            Libro libro = librosDict[id];
            libros.Remove(libro);
            librosDict.Remove(id);
            libroIdToRow.Remove(id);
            nextRowLibroIndex--;
        }

        /*
         * Préstamos
         */
        private List<Prestamo> prestamos = new List<Prestamo>();
        private Dictionary<int, Prestamo> prestamosDict = new Dictionary<int, Prestamo>();
        private int nextPrestamoId = 1;

        public Prestamo RegistrarPrestamo(int usuarioId, int libroId)
        {
            if (!usuariosDict.ContainsKey(usuarioId)) throw new KeyNotFoundException("Usuario no encontrado");

            if (!librosDict.ContainsKey(libroId)) throw new KeyNotFoundException("Libro no encontrado");

            Usuario usuario = usuariosDict[usuarioId];
            Libro libro = librosDict[libroId];

            if (libro.Cantidad <= 0) throw new InvalidOperationException("No hay copias disponibles de este libro.");

            int prestamoId = nextPrestamoId++;
            Prestamo nuevoPrestamo = new Prestamo(prestamoId, usuario, libro);
            
            prestamos.Add(nuevoPrestamo);
            prestamosDict[prestamoId] = nuevoPrestamo;
            libro.Cantidad--;

            return nuevoPrestamo;
        }

        public List<Prestamo> ListarPrestamos()
        {
            return prestamos;
        }
    }
}
