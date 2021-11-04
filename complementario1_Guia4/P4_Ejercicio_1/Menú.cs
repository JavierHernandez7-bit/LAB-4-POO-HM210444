using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P4_Ejercicio_1
{
    public partial class Menú : P4_Ejercicio_1.Form1
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void btnestudiantes_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            this.Hide();
            estudiante.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Docentes docente = new Docentes();
            this.Hide();
            docente.Show();
        }
    }
}
