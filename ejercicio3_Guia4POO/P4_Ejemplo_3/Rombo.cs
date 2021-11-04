using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Ejemplo_3
{
    class Rombo:Figura
    {
        double diagonalM, diagonalm;
        public Rombo(double A, double dM, double dm) : base(A)
        {
            diagonalM = dM;
            diagonalm = dm;
        }

        public double DiagonalM
        {
            get { return diagonalM; }
            set { diagonalM = value; }
        }

        public double Diagonalm
        {
            get { return diagonalm; }
            set { diagonalm = value; }
        }

        public override void CalcularArea(Label LR)
        {
            Area = (DiagonalM * Diagonalm)/2;
            LR.Text = "Area: " + Area;
        }
    }
}
