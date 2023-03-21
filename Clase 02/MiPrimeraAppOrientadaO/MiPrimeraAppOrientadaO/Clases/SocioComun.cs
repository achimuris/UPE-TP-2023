using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAppOrientadaO
{
    internal class SocioComun : Socio
    {

        //Constructor de la clase SocioComun
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public SocioComun() 
        { 
        }


        /// <summary>
        /// Constructor con más detalle
        /// </summary>
        /// <param name="unNombre">Le paso paso el nombre</param>
        /// <param name="unApellido">Le paso el apellido</param>
        public SocioComun(string unNombre, string unApellido)
        { 
            Nombre = unNombre;
            Apellido = unApellido;
        }



        /// <summary>
        /// Este método se encarga de devolver el monto de la cuota de un socio común.
        /// </summary>
        /// <returns>Devuelve un tipo double que representa el monto de la cuota</returns>
        public override double GetMontoCuota()
        {
            return 80; 
        }
    }
}
