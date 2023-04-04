using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Categoria
    {
		private double _neto;

		public double Neto
		{
			get { return _neto; }
			set { _neto = value; }
		}

	}
}
