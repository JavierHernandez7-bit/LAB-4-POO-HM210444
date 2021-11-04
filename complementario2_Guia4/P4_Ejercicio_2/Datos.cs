using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Ejercicio_2
{
    class Datos
    {
        private string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private int carnet;
        public int Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        private int nivel;
        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        private string universidad;
        public string Universidad
        {
            get { return universidad; }
            set { universidad = value; }
        }

        private string carrera;
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        private double cum;
        public double Cum
        {
            get { return cum; }
            set { cum = value; }
        }

        private double nota1;
        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        private double nota2;
        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        private double nota3;
        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        private string nombreProyecto;
        public string NombreProyecto
        {
            get { return nombreProyecto; }
            set { nombreProyecto = value; }
        }

        private int horasTotales;
        public int HorasTotales
        {
            get { return horasTotales; }
            set { horasTotales = value; }
        }

        private int horasCompletadas;
        public int HorasCompletadas
        {
            get { return horasCompletadas; }
            set { horasCompletadas = value; }
        }
    }
}
