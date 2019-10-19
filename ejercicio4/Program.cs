using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;
            double precio = 0; 
            double total=0;

            do
            {
                Console.WriteLine("Introdusca cantidad vendida en entero positivo:");
                cant = int.Parse(Console.ReadLine());
                if (cant != 0)
                {
                    Console.WriteLine("Introdusca precio :");
                    cant = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("es igual a:" + total = total + (cant * precio));

            } while (cantidad != 0);
            Console.WriteLine("el total es"+total);
            Console.ReadKey();
        }
    }
}
