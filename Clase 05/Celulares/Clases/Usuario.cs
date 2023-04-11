using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
		private string _numero;

		public string Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}


		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}


		private Celular _celular;

		public Celular Celular
		{
			get { return _celular; }
			set { _celular = value; }
		}

		public void Llamar(int duracion, Usuario destinatario)
		{
			this.Celular.RealizarLlamada(duracion, destinatario.Celular);
		}

		public bool TieneCelularApagado()
		{
			return !this.Celular.EstaPrendido();
		}

	}
}
