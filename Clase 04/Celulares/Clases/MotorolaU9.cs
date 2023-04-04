using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MotorolaU9 : Celular
    {
        private const double PerdidaPorLlamada = 0.25;
        public override void RealizarLlamada(int duracionLlamada, Celular destino)
        {
            ActualizarDuracionBateria(duracionLlamada);
            destino.RecibirLlamada(duracionLlamada);
        }

        private void ActualizarDuracionBateria(int duracionLlamada)
        {
            this.PuntosDeBateria -= PerdidaPorLlamada;
        }

        public override void RecibirLlamada(int duracionLlamada)
        {
            ActualizarDuracionBateria(duracionLlamada);
        }
    }
}
