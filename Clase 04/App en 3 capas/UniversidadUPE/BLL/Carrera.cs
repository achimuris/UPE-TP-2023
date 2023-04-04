using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Carrera
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

		public DataTable RetornarCarreras()
		{ 
		
			DAL.Carrera objDAL = new DAL.Carrera();

			return objDAL.DevolverCarreras();
		}
	}
}
