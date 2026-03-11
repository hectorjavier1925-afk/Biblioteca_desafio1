using System;
using System.Collections.Generic;

namespace Biblioteca_Desafio1
{
    // Clase Usuario aplicando Encapsulamiento (Unidad 2 - POO)
    public class Usuario
    {
        // Propiedades automáticas
        public string Nombre { get; set; }
        public string IDUsuario { get; set; }

        // Esta es la lista que pide la rúbrica para manejar datos
        public List<Libro> LibrosPrestados { get; set; }

        // Constructor para inicializar al chero que presta libros
        public Usuario(string nombre, string idUsuario)
        {
            Nombre = nombre;
            IDUsuario = idUsuario;
            LibrosPrestados = new List<Libro>();
        }

        // Método para que cuando lo mostrés en un cuadrito salga ordenado
        public override string ToString()
        {
            return $"{Nombre} (ID: {IDUsuario}) - Libros en mano: {LibrosPrestados.Count}";
        }
    }
}