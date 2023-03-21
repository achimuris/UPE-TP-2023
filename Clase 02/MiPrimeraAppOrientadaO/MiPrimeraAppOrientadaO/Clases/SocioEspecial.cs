using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAppOrientadaO
{
    internal class SocioEspecial : Socio
    {

        public SocioEspecial(string nombre, string apellido)
        { 
            Nombre = nombre;
            Apellido = apellido;
        }

        public override double GetMontoCuota()
        {
            return montoDeCuota * 2;
        }
    }
}
