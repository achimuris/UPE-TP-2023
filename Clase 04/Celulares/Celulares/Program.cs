using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Celulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario juliana = new Usuario();
            juliana.Nombre = "Juliana";
            juliana.Celular = new MotorolaU9();

            Usuario catalina = new Usuario();
            catalina.Nombre = "Cata";
            catalina.Celular = new IPhone();


            catalina.Celular.RecargarBateria();
            juliana.Celular.RecargarBateria();


            juliana.Llamar(180, catalina);

            Console.WriteLine("¿Tiene el celular prendido?: " + juliana.Celular.EstaPrendido());
            Console.WriteLine("Porcentaje de bateria del celular de Juliana: " + juliana.Celular.PuntosDeBateria);


            Console.WriteLine("¿Tiene el celular prendido?: " + catalina.Celular.EstaPrendido());
            Console.WriteLine("Porcentaje de bateria del celular de Catalina: " + catalina.Celular.PuntosDeBateria);

        }
    }
}
