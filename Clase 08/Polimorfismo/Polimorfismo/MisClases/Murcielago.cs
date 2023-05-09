using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Murcielago : Mamifero, IVolable
    {
        public string Volar()
        {
            return "Soy un murcielago y estoy volando";
        }
    }
}