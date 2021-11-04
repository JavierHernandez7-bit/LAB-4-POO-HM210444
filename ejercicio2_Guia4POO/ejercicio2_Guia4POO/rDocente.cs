using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejercicio2_Guia4POO
{
    public partial class rDocente : ejercicio2_Guia4POO.Registro
    {
        public rDocente()
        {
            InitializeComponent();
        }

       // private void rDocente(object sender, FormClosedEventArgs e)//LA ULTIMA PARTE DE LA PAG 16 INICIO DE LA 17
        //{
          //  rEstudiante rDocente = new rEstudiante();
          //  this.Hide();
          //  rDocente.Show();
       // }

        private void rDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
