using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "Enero" , "Febrero" , "Marzo" , "Abril" , "Mayo" , "Junio" , "Julio" ,
                "Agosto" , "Septiembre" , "Octubre" , "Noviembre" , "Diciembre" };

            Console.Write("Introduzca el número del mes: ");
            int NumMes = 0;
            Int32.TryParse(Console.ReadLine(), out NumMes);

            if (NumMes < 1 || NumMes > 12)
            {
                for (int i = 0; i < 13; i++)
                {
                    Console.WriteLine(mes[i]);
                }
            }
            else
            {
                Console.WriteLine("Seleccione el mes de: " + mes[NumMes - 1]);
                
            }

        }
    }
}