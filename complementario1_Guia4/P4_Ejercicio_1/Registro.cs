using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P4_Ejercicio_1
{
    public partial class Registro : P4_Ejercicio_1.Form1
    {
        private List<Datos> datos = new List<Datos>();   // Llamando a la clase datos
        private int edit_indice = -1;

        private void actualizargrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datos;
        }

        private void reseteo() 
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
        }

        public Registro()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dataGridView1.SelectedRows[0];
            int posicion = dataGridView1.Rows.IndexOf(selected);
            edit_indice = posicion;

            Datos valoresdatos = datos[posicion];

            txtCodigo.Text = Convert.ToString(valoresdatos.Codigo);
            txtNombre.Text = valoresdatos.Nombre;
            txtUsuario.Text =valoresdatos.Usuario;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Datos valordatos = new Datos();
            valordatos.Nombre = txtNombre.Text;
            valordatos.Usuario = txtUsuario.Text;
            valordatos.Codigo = int.Parse(txtCodigo.Text);

            if (edit_indice > -1)
            {
                datos[edit_indice] = valordatos;
                edit_indice = -1;
            }
            else
            {
                datos.Add(valordatos);
            }
            actualizargrid();
            reseteo();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
          
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Datos valordatos = new Datos();
            valordatos.Nombre = txtNombre.Text;
            valordatos.Usuario = txtUsuario.Text;
            valordatos.Codigo = int.Parse(txtCodigo.Text);

            if (edit_indice > -1)
            {
                datos[edit_indice] = valordatos;
                edit_indice = -1;
            }
            else
            {
                datos.Add(valordatos);
            }
            actualizargrid();
            reseteo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                datos.RemoveAt(edit_indice);
                edit_indice = -1;
                actualizargrid();
            }
            else
            {
                MessageBox.Show("Dar doble click.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
