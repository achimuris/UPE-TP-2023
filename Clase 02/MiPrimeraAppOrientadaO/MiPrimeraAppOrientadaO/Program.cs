using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAppOrientadaO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaro una variable del tipo SocioComun
            SocioComun objSocioComun;

            //Instancio un SocioComun
            objSocioComun = new SocioComun();

            objSocioComun.Nombre = "Andrés";

            Console.WriteLine(  objSocioComun.Nombre);

            //objSocioComun.Retirar("Un libro");

            //objSocioComun.Pagar(1010.15);


            SocioComun otroSocioComun = new SocioComun("Nicolás", "Garrido");

            Console.WriteLine( "El total de la cuota es: " + objSocioComun.GetMontoCuota());
            Console.WriteLine("El monto de la cuota de otro socio común es: " + 
                otroSocioComun.GetMontoCuota() +
                " y mi nombre es: " + 
                otroSocioComun.Nombre);


            SocioEspecial objSocioEspecial;
            objSocioEspecial = new SocioEspecial("Gustavo", "Pascual");

            List<Socio> listaDeSocios = new List<Socio>();

            Console.WriteLine("Cantidad de elementos antes de agregar: " + listaDeSocios.Count());
            //Agrego un socio común
            listaDeSocios.Add(objSocioComun);
            Console.WriteLine( "Cantidad de elementos después de agregar un objeto: " + listaDeSocios.Count()); 
            listaDeSocios.Add(otroSocioComun);
            Console.WriteLine("Cantidad de elementos después de otro objeto: " + listaDeSocios.Count());

            listaDeSocios.Add(objSocioEspecial);
            Console.WriteLine("Cantidad de elementos después de agregar un socio especial: " + listaDeSocios.Count());


            foreach (Socio unSocio in listaDeSocios)
            {
                //if (unSocio.GetType().Name == "SocioEspecial")
                //{
                //    Console.WriteLine("Es un socio especial " + unSocio.Nombre);
                //}
                //else
                //{
                    Console.WriteLine(unSocio.Nombre);
                //}
                
            }

//            listaDeSocios.Clear();
            listaDeSocios.RemoveAt(0);
            Console.WriteLine( "Vuelve a imprimir la lista de socios" );
            foreach (Socio unSocio in listaDeSocios)
            {
                Console.WriteLine(unSocio.Nombre);
            }

            listaDeSocios.Remove(objSocioEspecial);

            Console.WriteLine("Vuelve a imprimir la lista de socios");
            foreach (Socio unSocio in listaDeSocios)
            {
                Console.WriteLine(unSocio.Nombre);
            }

            Console.ReadKey();

        }
    }
}
