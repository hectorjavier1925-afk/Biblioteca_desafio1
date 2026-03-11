using System;
using System.Collections.Generic;
using System.Linq; // Esto es para que podás contar rápido los libros

namespace Biblioteca_Desafio1
{
    public class GestionBiblioteca
    {
        // El Diccionario que pide la rúbrica (Búsqueda rápida por ISBN)
        private Dictionary<string, Libro> inventarioLibros;
        // Lista para manejar a los cheros que prestan libros
        private List<Usuario> listaUsuarios;

        public GestionBiblioteca()
        {
            inventarioLibros = new Dictionary<string, Libro>();
            listaUsuarios = new List<Usuario>();
        }

        // Método para agregar libro al sistema
        public void RegistrarLibro(Libro nuevoLibro)
        {
            if (!inventarioLibros.ContainsKey(nuevoLibro.ISBN))
            {
                inventarioLibros.Add(nuevoLibro.ISBN, nuevoLibro);
            }
        }

        // Método para registrar un usuario
        public void RegistrarUsuario(Usuario nuevoUsuario)
        {
            listaUsuarios.Add(nuevoUsuario);
        }

        // --- ESTO ES PARA LOS GRÁFICOS QUE PIDE LA RÚBRICA ---
        public int TotalLibros() => inventarioLibros.Count;

        public int ConteoDisponibles() => inventarioLibros.Values.Count(l => !l.EstaPrestado);

        public int ConteoPrestados() => inventarioLibros.Values.Count(l => l.EstaPrestado);
    }
}