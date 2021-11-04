using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Ejemplo_3
{
    public class Cuadrado:Figura
    {
        private double lado; 

        public Cuadrado(Double A, Double L):base(A)  // Constructor
        {
            lado = L;
        }

        public double Lado // Propiedad
        {
            get { return lado; }
            set { lado = value; }
        }

        // Método sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (Lado * Lado);
            LR.Text = "Area: " + Area;
        }
    }
}
