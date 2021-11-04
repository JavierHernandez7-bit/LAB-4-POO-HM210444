using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1_Guia4POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suma suma = new Suma();
            txtresultado.Text = suma.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resta resta = new Resta();
            txtresultado.Text = resta.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicacion multiplicacion = new Multiplicacion();
            txtresultado.Text = multiplicacion.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtv1.Clear();
            txtv2.Clear();
            txtresultado.Clear();
        }
    }
}
