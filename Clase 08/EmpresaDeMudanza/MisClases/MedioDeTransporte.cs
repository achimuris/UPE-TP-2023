using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public abstract class MedioDeTransporte
    {
		private string _patente;

		public string Patente
		{
			get { return _patente; }
			set { _patente = value; }
		}

		private List<ObjetoDeMudanza> _objetosFragiles = new List<ObjetoDeMudanza>();

		public List<ObjetoDeMudanza> ObjetosFragiles
		{
			get { return _objetosFragiles; }
			set { _objetosFragiles = value; }
		}

		private List<ObjetoDeMudanza> _objetosNoFragiles = new List<ObjetoDeMudanza>();

		public List<ObjetoDeMudanza> ObjetoNoFragiles
		{
			get { return _objetosNoFragiles; }
			set { _objetosNoFragiles = value; }
		}


		public void Subir(ObjetoDeMudanza objetoDeMudanza)
		{ 
			this.ObjetosFragiles.Add(objetoDeMudanza);	
		}

        public void Bajar(ObjetoDeMudanza objetoDeMudanza)
        {

        }




    }
}
