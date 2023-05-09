using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Alumno : Persona
    {
        public override string Saludar(string nombreReceptorDeMiSaludo)
        {
            return "Hola " + 
                nombreReceptorDeMiSaludo + 
                " mi nombre es " + 
                this.Nombre;
        }
    }
}