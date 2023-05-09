using Polimorfismo.Excepcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Gastón";
            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Karina";

            Profesor profesor = new Profesor();
            profesor.Nombre = "Nicolás";

            List<Persona> personas = new List<Persona>();
            personas.Add(alumno1);
            personas.Add(profesor);
            personas.Add(alumno2);

            foreach (Persona persona in personas)
            {
                //Console.WriteLine(persona.Saludar("Matias"));
                Console.WriteLine(persona.OtraFormaDeSaludar());
            }


            //List<IVolable> voladores = new List<IVolable>();
            //Murcielago batman = new Murcielago();
            //Avion boing737 = new Avion();

            //voladores.Add(boing737);
            //voladores.Add(batman);


            //Cliente unCliente = new Cliente();
            //DateTime fechaDeNacimiento = new DateTime(2010, 1, 1, 0, 0, 0);


            //try
            //{
            //    unCliente.CargarFechaDeNacimiento(fechaDeNacimiento);
            //}
            //catch (MiExcepcionCliente unaEspecificaDeCliente)
            //{
            //    Console.WriteLine(unaEspecificaDeCliente.Mensaje);
            //}
            //catch (Exception generica)
            //{
            //    Console.WriteLine("Ocurrió un error inesperado");
            //}




            //foreach (IVolable volable in voladores)
            //{
            //    Console.WriteLine(volable.Volar());
            //}




        }
    }
}
