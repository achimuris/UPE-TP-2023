using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class ObjetoDeMudanza
    {
		private int _alto;

		public int Alto
		{
			get { return _alto; }
			set { _alto = value; }
		}

		private int _ancho;

		public int Ancho
		{
			get { return _ancho; }
			set { _ancho = value; }
		}

		private int _largo;

		public int Largo
		{
			get { return _largo; }
			set { _largo = value; }
		}

		private bool _esFragil;

		public bool EsFragil
		{
			get { return _esFragil; }
			set { _esFragil = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private double _peso;

		public double Peso
		{
			get { return _peso; }
			set { _peso = value; }
		}

		/// <summary>
		/// Este método nos devuelve el volumen del objeto de mudanza
		/// </summary>
		/// <returns></returns>
		public double Dimension()
		{
			return Alto * Largo * Ancho;
		}



	}
}
