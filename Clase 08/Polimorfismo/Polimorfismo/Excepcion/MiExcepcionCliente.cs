using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Excepcion
{
    public class MiExcepcionCliente : Exception
    {
		private string _mensaje;

		public string Mensaje
		{
			get { return _mensaje; }
			set { _mensaje = value; }
		}

        public MiExcepcionCliente(string unMensaje)
        {
            this.Mensaje = unMensaje;
        }

    }
}
