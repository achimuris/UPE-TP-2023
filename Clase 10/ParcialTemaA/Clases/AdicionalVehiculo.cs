using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AdicionalVehiculo
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		private double _precio;

		public double Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}
		private bool _esEnPesos;

		public bool EsEnPesos
		{
			get { return _esEnPesos; }
			set { _esEnPesos = value; }
		}

        public AdicionalVehiculo(string descripcion, double precio, bool esEnPesos)
        {
			this.Nombre = descripcion;
			this.Precio = precio;
			this.EsEnPesos= esEnPesos;
        }

        public override string ToString()
        {
			if (!this.EsEnPesos)
			{
				return Nombre + " USD " + Precio;
			}
            return Nombre + " $ " + Precio;
        }

    }
}
