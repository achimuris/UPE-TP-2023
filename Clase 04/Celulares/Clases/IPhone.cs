using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class IPhone : Celular
    {
        public override void RealizarLlamada(int duracionLlamada, Celular destino)
        {
            destino.RecibirLlamada(duracionLlamada);
            ActualizarBateria(duracionLlamada);
        }

        private void ActualizarBateria(int duracionLlamada)
        {
            this.PuntosDeBateria -= (duracionLlamada * 0.01);
        }

        public override void RecibirLlamada(int duracionLlamada)
        {
            ActualizarBateria(duracionLlamada);
        }
    }
}
