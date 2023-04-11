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


		public DataTable RetonarMaterias(int idMateria)
		{ 
			DAL.Carrera objDal = new DAL.Carrera();

			return objDal.DevolverMaterias(idMateria);
		}

        public bool AgregarMateria(string nombre, int idCarrera)
        {
            DAL.Carrera objDal = new DAL.Carrera();

			if (string.IsNullOrWhiteSpace(nombre))
			{
				throw new Exception("Usted no puede añadir una materia sin un nombre");
			}

			return objDal.AgregarMateria(nombre, idCarrera);

        }
    }
}
