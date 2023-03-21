using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAppOrientadaO
{
    abstract class Socio
    {

        protected double montoDeCuota = 150;

        // Solo los atributos privados
        private string nombre;


        //Propiedad Nombre
        public string Nombre
        {
            get { return nombre; } //Get
            set { nombre = value; } //Set
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }





        public void Retirar(string libro)
        {
            Console.WriteLine("Invoque al método Retirar");
        }
        public void Pagar(double monto)
        {
            Console.WriteLine(  "Ejecuto el método Pagar()");
        }

        public abstract double GetMontoCuota();
    }
}
