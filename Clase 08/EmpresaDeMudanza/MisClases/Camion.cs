﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Camion : MedioDeTransporte
    {
        public Camion(string patente) 
        {
            this.Patente = patente;
        }
    }
}
