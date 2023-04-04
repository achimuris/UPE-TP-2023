using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Empresa
    {
        public double CalcularSueldo(Empleado unEmpleado, int cantidadDeAusentes)
        { 
            double sueldoEmpleado = 0;

            sueldoEmpleado = unEmpleado.Categoria.Neto * 1.1;


            return sueldoEmpleado;
        }
    }
}
