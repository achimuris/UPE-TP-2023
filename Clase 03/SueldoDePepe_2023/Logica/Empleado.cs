using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Empleado
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}


		private string _cuil;

		public string Cuil
		{
			get { return _cuil; }
			set { _cuil = value; }
		}


		private Categoria _categoria;

		public Categoria Categoria
		{
			get { return _categoria; }
			set { _categoria = value; }
		}


        public Empleado(Categoria unaCategoria, string unNombre, string unApellido)
        {
			this.Categoria = unaCategoria;
			this.Nombre = unNombre;
			this.Apellido = unApellido;
        }



    }
}
