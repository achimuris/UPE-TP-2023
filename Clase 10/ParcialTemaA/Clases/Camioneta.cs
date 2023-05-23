using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Camioneta : VehiculoEuropeo, IVehiculoAmericano
    {
        public double CapacidadDeTanqueEnLitros()
        {
            return this.CantidadCombustible * 3.78;
        }

        public double DistanciaEnKM()
        {
            return this.DistanciaRecorrida * 1.609;
        }

        public override double PrecioEnDolar()
        {
            return 150000;
        }

        public double VelocidadMaximaEnKMPorHora()
        {
            return this.VelocidadMaxima * 1.609;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - Distancia en KM {2}  - Vel. Máx. {3} KM", Descripcion, Marca, this.DistanciaEnKM(), this.VelocidadMaximaEnKMPorHora());
        }
    }
}
