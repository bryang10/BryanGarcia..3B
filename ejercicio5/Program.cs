using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("piramide de asteriscos");
            Console.WriteLine("inserta el nivel de la piramide");
            try
            {
                int nivel = int.Parse(Console.ReadLine());
                int a;
                int espacios;
                for (int i = 1; i <= nivel; i++)
                {
                    StringBuilder final = new StringBuilder();

                    espacios = nivel - i;
                    a = i + (i - 1);
                    for (int i1 = 0; i1 < espacios; i1++)
                        final.Append(" ");

                    for (int i2 = 0; i2 < a; i2++)
                        final.Append("*");

                    Console.WriteLine(final.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EScribe un numero");
            }

            Console.WriteLine("" + "\n" + "Programa creado por Estrada");
            Console.WriteLine("" + "\n" + "Aprieta una tecla para salir");
            Console.ReadKey();
        }
    }
}
