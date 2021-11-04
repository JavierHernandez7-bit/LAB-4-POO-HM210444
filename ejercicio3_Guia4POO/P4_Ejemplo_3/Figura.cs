using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Ejemplo_3
{
    public abstract class Figura
    {
        private double area; // atributo

        // constructor
        
        public Figura(double A)
        {
            area = A;
        }

        // propiedad

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        // método utilizando virtual
        
        public virtual void CalcularArea(Label LR)
        {
            
        }
    }
}
