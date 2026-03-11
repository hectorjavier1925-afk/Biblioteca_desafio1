using System;

namespace Biblioteca_Desafio1
{
    // Clase que representa un Libro (Aplicando POO - Unidad 2)
    public class Libro
    {
        // Propiedades con Encapsulamiento
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Categoria { get; set; }
        public bool EstaPrestado { get; set; }

        // Constructor: Para inicializar el libro cuando se crea
        public Libro(string titulo, string autor, string isbn, string categoria)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Categoria = categoria;
            EstaPrestado = false; // Por defecto, el libro entra disponible
        }

        // Método para mostrar info (Opcional, ayuda a la depuración)
        public override string ToString()
        {
            string estado = EstaPrestado ? "[Prestado]" : "[Disponible]";
            return $"{Titulo} - {Autor} ({ISBN}) {estado}";
        }
    }
}