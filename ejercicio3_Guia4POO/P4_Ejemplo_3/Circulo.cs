using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Ejemplo_3
{
    public class Circulo:Figura
    {
        private double radio;

        public Circulo(double A, double R) : base(A)
        { 
            radio = R; 
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        // Método sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area = (3.1416 * (Radio * Radio));
            LR.Text = "Area: " + Area;
        }
    }
}
