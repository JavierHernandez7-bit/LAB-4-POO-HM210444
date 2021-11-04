using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejercicio2_Guia4POO
{
    public partial class Menú : ejercicio2_Guia4POO.Form1
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void btndocente_Click(object sender, EventArgs e)
        {
            rDocente Docente = new rDocente();
            this.Hide();
            Docente.Show();
        }

        private void btnestudiante_Click(object sender, EventArgs e)
        {
            rEstudiante estudiante = new rEstudiante();
            estudiante.Show();  
        }
    }
}
