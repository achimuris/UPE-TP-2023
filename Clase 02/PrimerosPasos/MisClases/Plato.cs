using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClases
{
    public class Plato
    {
        private int _cantidadDeIngredientes;

        public int CantidadDeIngredientes
        {
            get { return _cantidadDeIngredientes; }
            set { _cantidadDeIngredientes = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public const double PrecioBase = 150;



        /// <summary>
        /// Devuelve el precio que se calcula según la cantidad de ingredientes.
        /// Si la cantidad de ingredientes es mayor a 3, cada ingrediente se cobra 20 pesos.
        /// Si es menor , cada uno se cobra 30 pesos.
        /// </summary>
        /// <returns></returns>
        public double GetPrecio()
        {
            double precioPorCadaIngredienteExtra;

            if (this.CantidadDeIngredientes >= 3)
            {
                precioPorCadaIngredienteExtra = 20;
            }
            else
            {
                precioPorCadaIngredienteExtra = 30;
            }

            return PrecioBase + (this.CantidadDeIngredientes * precioPorCadaIngredienteExtra);


        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Plato() { }

        /// <summary>
        /// Otro constructor
        /// </summary>
        /// <param name="elNombre"></param>
        /// <param name="cantidadDeIngredientes"></param>
        public Plato(string elNombre, int cantidadDeIngredientes)
        {
            this.Nombre = elNombre;
            this.CantidadDeIngredientes=cantidadDeIngredientes; 
        
        }
    }
}
