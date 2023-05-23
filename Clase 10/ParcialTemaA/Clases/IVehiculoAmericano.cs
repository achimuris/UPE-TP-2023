﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IVehiculoAmericano
    {
        double CapacidadDeTanqueEnLitros();
        double DistanciaEnKM();
        double VelocidadMaximaEnKMPorHora();
    }
}
