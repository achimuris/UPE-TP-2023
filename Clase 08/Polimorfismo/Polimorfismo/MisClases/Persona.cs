using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public abstract class Persona : Mamifero
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public abstract string Saludar(string nombreReceptorDeMiSaludo);

        public virtual string OtraFormaDeSaludar()
        {
            return "Mi nombre es " + this.Nombre;
        }

    }
}