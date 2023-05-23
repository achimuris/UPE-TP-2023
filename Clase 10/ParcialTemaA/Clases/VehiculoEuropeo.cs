using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class VehiculoEuropeo
    {

		private List<AdicionalVehiculo>	 _adicionales = new List<AdicionalVehiculo>();

		public List<AdicionalVehiculo> Adicionales
		{
			get { return _adicionales; }
			set { _adicionales = value; }
		}



		private double _cantidadCombustible;

		public double CantidadCombustible
		{
			get { return _cantidadCombustible; }
			set { _cantidadCombustible = value; }
		}

		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

        public override string ToString()
        {
			return string.Format("{0} - {1} - {2} - {3}", Descripcion, Marca, DistanciaRecorrida, VelocidadMaxima);
        }

        private double _distanciaRecorrida;

		public double DistanciaRecorrida
		{
			get { return _distanciaRecorrida; }
			set { _distanciaRecorrida = value; }
		}
		private string _marca;

		public string Marca
		{
			get { return _marca; }
			set { _marca = value; }
		}
		private double _velocidadMaxima;

		public double VelocidadMaxima
		{
			get { return _velocidadMaxima; }
			set { _velocidadMaxima = value; }
		}

		public abstract double PrecioEnDolar();


	}
}
