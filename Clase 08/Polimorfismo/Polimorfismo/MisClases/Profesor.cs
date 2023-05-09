using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Profesor : Persona
    {
        public override string Saludar(string nombreReceptorDeMiSaludo)
        {
            return "Soy " + 
                this.Nombre + 
                ", encantando en conocerte " + 
                nombreReceptorDeMiSaludo;
        }

        public override string OtraFormaDeSaludar()
        {
            //return base.OtraFormaDeSaludar();
            return "Soy un profesor y saludo distinto";
        }
    }
}