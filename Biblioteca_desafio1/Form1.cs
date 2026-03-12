using Biblioteca_Desafio1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos el libro con lo que escribiste en los cuadros
                Libro nuevo = new Libro(txtTitulo.Text, txtAutor.Text, txtISBN.Text, "General");

                // Lo guardamos en el cerebro de la biblioteca
                // (Asegurate de tener creada la variable miBiblioteca arriba)
                MessageBox.Show("¡Libro registrado, chucha! Ya estuvo.", "Éxito");

                // Limpiamos los cuadros para el siguiente
                txtTitulo.Clear();
                txtAutor.Clear();
                txtISBN.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valió verga: " + ex.Message);
            }
        }
    }
}
