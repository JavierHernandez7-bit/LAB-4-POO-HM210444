using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P4_Ejercicio_2
{
    public partial class _5Ingenieria : P4_Ejercicio_2._4Universitario
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
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCarnet.Clear();
            txtNivel.Clear();
            txtUniversidad.Clear();
            txtCarrera.Clear();
            txtCum.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNombreProyecto.Clear();
            txtHorasTotales.Clear();
            txtHorasCompletadas.Clear();
        }

        public _5Ingenieria()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selected = dataGridView1.SelectedRows[0];
            int posicion = dataGridView1.Rows.IndexOf(selected);
            edit_indice = posicion;

            Datos valoresdatos = datos[posicion];

            txtNombres.Text = valoresdatos.Nombres;
            txtApellidos.Text = valoresdatos.Apellidos;
            txtCarnet.Text = Convert.ToString(valoresdatos.Carnet);
            txtNivel.Text = Convert.ToString(valoresdatos.Nivel);
            txtUniversidad.Text = valoresdatos.Universidad;
            txtCarrera.Text = valoresdatos.Carrera;
            txtCum.Text = Convert.ToString(valoresdatos.Cum);
            txtNota1.Text = Convert.ToString(valoresdatos.Nota1);
            txtNota2.Text = Convert.ToString(valoresdatos.Nota2);
            txtNota3.Text = Convert.ToString(valoresdatos.Nota3);
            txtNombreProyecto.Text = valoresdatos.NombreProyecto;
            txtHorasTotales.Text = Convert.ToString(valoresdatos.HorasTotales);
            txtHorasCompletadas.Text = Convert.ToString(valoresdatos.HorasCompletadas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos valordatos = new Datos();
            valordatos.Nombres = txtNombres.Text;
            valordatos.Apellidos = txtApellidos.Text;
            valordatos.Carnet = int.Parse(txtCarnet.Text);
            valordatos.Nivel = int.Parse(txtNivel.Text);
            valordatos.Universidad = txtUniversidad.Text;
            valordatos.Carrera = txtCarrera.Text;
            valordatos.Cum = int.Parse(txtCum.Text);
            valordatos.Nota1 = int.Parse(txtNota1.Text);
            valordatos.Nota2 = int.Parse(txtNota2.Text);
            valordatos.Nota3 = int.Parse(txtNota3.Text);
            valordatos.NombreProyecto = txtNombreProyecto.Text;
            valordatos.HorasTotales = int.Parse(txtHorasTotales.Text);
            valordatos.HorasCompletadas = int.Parse(txtHorasCompletadas.Text);

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

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Datos valordatos = new Datos();
            valordatos.Nombres = txtNombres.Text;
            valordatos.Apellidos = txtApellidos.Text;
            valordatos.Carnet = int.Parse(txtCarnet.Text);
            valordatos.Nivel = int.Parse(txtNivel.Text);
            valordatos.Universidad = txtUniversidad.Text;
            valordatos.Carrera = txtCarrera.Text;
            valordatos.Cum = int.Parse(txtCum.Text);
            valordatos.Nota1 = int.Parse(txtNota1.Text);
            valordatos.Nota2 = int.Parse(txtNota2.Text);
            valordatos.Nota3 = int.Parse(txtNota3.Text);
            valordatos.NombreProyecto = txtNombreProyecto.Text;
            valordatos.HorasTotales = int.Parse(txtHorasTotales.Text);
            valordatos.HorasCompletadas = int.Parse(txtHorasCompletadas.Text);

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
    }
}
