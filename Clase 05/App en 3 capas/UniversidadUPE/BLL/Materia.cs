using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Materia
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private Carrera carrera;

		public Carrera Carrera
		{
			get { return carrera; }
			set { carrera = value; }
		}

	}
}
