using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Empleado
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}



		private double _toleranciaPeso;

		public double ToleranciaPeso
		{
			get { return _toleranciaPeso; }
			set { _toleranciaPeso = value; }
		}

		public void SubirObjeto(ObjetoDeMudanza objeto, MedioDeTransporte dondeLoSubo)
		{
			if (objeto.Peso > this.ToleranciaPeso)
			{
				throw new ExcepcionPorPeso(string.Format("El empleado {0} no puede soportar {1} ya que tolera hasta {2}", this.Nombre, objeto.Peso, this.ToleranciaPeso));
            }

			dondeLoSubo.Subir(objeto);
		
		}


        public void BajarObjeto(ObjetoDeMudanza objeto, MedioDeTransporte dondeLoBajo)
        {

        }

        public override string ToString()
        {
			return this.Nombre + " " + this.ToleranciaPeso + "KG";
        }

    }
}
