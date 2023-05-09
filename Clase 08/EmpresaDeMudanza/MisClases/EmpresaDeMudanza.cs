using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class EmpresaDeMudanza : IDisposable
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _sitioWeb;

		public string SitioWeb
		{
			get { return _sitioWeb; }
			set { _sitioWeb = value; }
		}
		private string _telefono;

		public string Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}

		private List<Empleado> _empleados = new List<Empleado>();

		public List<Empleado> Empleados
		{
			get { return _empleados; }
			set { _empleados = value; }
		}

		

        public EmpresaDeMudanza(List<Empleado> losEmpleados)
        {
			this.Empleados = losEmpleados;
        }

        private List<MedioDeTransporte> _mediosDeTransporte = new List<MedioDeTransporte>();

		public List<MedioDeTransporte> MediosDeTransportes
		{
			get { return _mediosDeTransporte; }
			set { _mediosDeTransporte = value; }
		}

        public void Dispose()
        {
			this.Empleados = null;
        }
    }
}
