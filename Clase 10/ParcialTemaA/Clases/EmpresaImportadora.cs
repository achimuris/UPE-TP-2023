using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class EmpresaImportadora
    {
		private double _cotizacionDelDia;

		public double CotizacionDelDia
		{
			get { return _cotizacionDelDia; }
			set { _cotizacionDelDia = value; }
		}
		private string _razonSocial;

		public string RazonSocial
		{
			get { return _razonSocial; }
			set { _razonSocial = value; }
		}

		private List<VehiculoEuropeo> _vehiculosEuropeos = new List<VehiculoEuropeo>();

		public List<VehiculoEuropeo> Vehiculos
		{
			get { return _vehiculosEuropeos; }
			set { _vehiculosEuropeos = value; }
		}


        public EmpresaImportadora()
        {
			this.Vehiculos.Add(new Automovil()
			{
				CantidadCombustible = 5,
				Descripcion="500",
				Marca = "Fiat",
				DistanciaRecorrida= 0,
				VelocidadMaxima=50
			});

            this.Vehiculos.Add(new Automovil()
            {
                CantidadCombustible = 10,
                Descripcion = "A6",
                Marca = "Audi",
                DistanciaRecorrida = 0,
                VelocidadMaxima = 120
            });

            this.Vehiculos.Add(new Camioneta()
            {
                CantidadCombustible = 15,
                Descripcion = "Ranger",
                Marca = "Ford",
                DistanciaRecorrida = 5000,
                VelocidadMaxima = 80
            });

			this.RazonSocial = "Mi Empresa Importadora S.R.L.";

			this.CotizacionDelDia = 500;


			this.Adicionales.Add(new AdicionalVehiculo("SW Update", 1500, false));
            this.Adicionales.Add(new AdicionalVehiculo("Alarma", 5000, true));
            this.Adicionales.Add(new AdicionalVehiculo("Vidrio", 1500, true));
            this.Adicionales.Add(new AdicionalVehiculo("Balizas", 1000, true));
            this.Adicionales.Add(new AdicionalVehiculo("Luces", 7500, true));

        }

		private List<AdicionalVehiculo> _adicionales = new List<AdicionalVehiculo>();

		public List<AdicionalVehiculo> Adicionales
		{
			get { return _adicionales; }
			set { _adicionales = value; }
		}


		public double CalcularPrecio(VehiculoEuropeo unCoche)
		{
			double precioEnPesos = this.CotizacionDelDia * unCoche.PrecioEnDolar();
			double valorDeAdicionales = 0;

			foreach (AdicionalVehiculo unAdicional in unCoche.Adicionales)
			{
				if (!unAdicional.EsEnPesos)
				{
					valorDeAdicionales += unAdicional.Precio * this.CotizacionDelDia;
				}
				else
				{
					valorDeAdicionales += unAdicional.Precio;
				}
			}


			return precioEnPesos + valorDeAdicionales;
		}

	}
}
