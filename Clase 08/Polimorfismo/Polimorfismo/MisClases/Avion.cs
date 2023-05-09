using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    public class Avion : IVolable
    {
        public string Volar()
        {
            return "Soy un avión y estoy volando";
        }
    }
}