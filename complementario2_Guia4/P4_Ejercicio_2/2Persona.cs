using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Ejercicio_2
{
    public partial class _2Persona : Form
    {
        public _2Persona()
        {
            InitializeComponent();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
