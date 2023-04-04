using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Celular
    {
        protected const int PuntosMaximoDeBateria = 5;

		private double _puntosDeBateria;

		public double PuntosDeBateria
		{
			get { return _puntosDeBateria; }
			set { _puntosDeBateria = value; }
		}

        public Celular()
        {
            //this.PuntosDeBateria = PuntosMaximoDeBateria;
        }

        public bool EstaPrendido()
		{
			if (this.PuntosDeBateria==0)
			{
				return false;
			}

			return true;
		}

		public void RecargarBateria()
		{
			//Ponemos al máximo la batería del celular
			this.PuntosDeBateria = PuntosMaximoDeBateria;
		}

		public abstract void RealizarLlamada(int duracionLlamada, Celular destino);

		public abstract void RecibirLlamada(int duracionLlamada);


	}
}
