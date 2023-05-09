using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Excepcion
{
    public class Cliente : Persona
    {
        public override string Saludar(string nombreReceptorDeMiSaludo)
        {
            return "Soy cliente";
        }

        private DateTime _fechaNacimiento;



        public void CargarFechaDeNacimiento(DateTime unaFecha)
        {


            //throw new NotImplementedException();



            if ((DateTime.Now.Year -  unaFecha.Date.Year) < 18)
            {
                //Acá deberíamos lanzar una excepción
                throw new MiExcepcionCliente("El cliente en cuestión es menor de 18 años de edad");
            }

            _fechaNacimiento = unaFecha;
        }

    }
}
