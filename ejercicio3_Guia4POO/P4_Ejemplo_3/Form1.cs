using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Ejemplo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Figura[] arreglof = new Figura[5];

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txtLado.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A, L);
            cuadrado.CalcularArea(labelCuadrado);
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txtCirculo.Text);
            double A = 0;
            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(label3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inicialización de variables
            double R = double.Parse(textBox1.Text);
            double A = 0;
            double L = double.Parse(textBox1.Text);

            arreglof[0] = new Cuadrado(A, L);
            arreglof[1] = new Cuadrado(A, L + 1);
            arreglof[2] = new Circulo(A, R);
            arreglof[3] = new Circulo(A, R + 1);
            arreglof[4] = new Circulo(A, R + 2);

            arreglof[0].CalcularArea(label5);
            arreglof[1].CalcularArea(label6);
            arreglof[2].CalcularArea(label7);
            arreglof[3].CalcularArea(label8);
            arreglof[4].CalcularArea(label9);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double DiagonalM = double.Parse(textBox2.Text);
            double Diagonalm = double.Parse(textBox3.Text);
            double A = 0;
            Rombo rombo = new Rombo(A, DiagonalM, Diagonalm);
            rombo.CalcularArea(label13);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
