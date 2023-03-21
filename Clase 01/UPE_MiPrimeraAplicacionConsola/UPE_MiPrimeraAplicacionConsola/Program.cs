using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPE_MiPrimeraAplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int nota4;
            float promedio;
            int resultado;
            ushort cantidadDeNotas = 4;

            IngresoDeNotas(out nota1, out nota2, out nota3, out nota4);
            CalculoDeNotas(nota1, nota2, nota3, nota4, out promedio, out resultado, cantidadDeNotas);
            ImprimirPromedio(promedio);
            ImprimirPromedio(10);

            Console.ReadKey();
        }

        private static void ImprimirPromedio(float promedio)
        {
            Console.WriteLine("El promedio es: " + promedio);

            Console.WriteLine("Escriba cualquier caracter para salir");
        }

        private static void CalculoDeNotas(int nota1, int nota2, int nota3, int nota4, out float promedio, out int resultado, ushort cantidadDeNotas)
        {
            resultado = (nota1 + nota2 + nota3 + nota4);

            promedio = ((float)resultado / cantidadDeNotas);
        }

        private static void IngresoDeNotas(out int nota1, out int nota2, out int nota3, out int nota4)
        {
            Console.WriteLine("Ingrese la nota 1");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 4");
            nota4 = int.Parse(Console.ReadLine());
        }
    }
}
