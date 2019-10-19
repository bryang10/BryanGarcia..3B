using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Ingresa n° entero para realizar rombo:");
            int rombo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rombo; i++)
            {
                for (int j = 1; j <= rombo - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = rombo - 1; i >= 1; i++)
            {
                for (int j = 1; j <= rombo - i; j ++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }

    }

}