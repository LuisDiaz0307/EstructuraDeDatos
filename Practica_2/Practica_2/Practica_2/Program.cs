using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)//[] para hacer arreglos uni, [,] para arreglos de mas dimensiones
        {
            /*
            Instrucciones : Hacer una aplicación en C# de consola, donde se solicite ingresar nombre de 10 personas,
            al terminar de ingresar esas 10 personas, debe de mostrar una lista con los nombres ingresados.
            */
            string[] Nombres = new string[10];
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.Write($"Escriba aquí el nombre de la persona { i + 1 } :");
                Nombres[i] = Console.ReadLine();
            }
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("El nombre de persona " + (i + 1) + " es: " + Nombres[i]);
            }
            Console.ReadLine();
            
        }
    }
}
// Luis Diaz Practica_2