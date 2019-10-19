using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero=0, resultado = 1, sumatoria=0;
            Console.WriteLine("1.- salir");
            Console.WriteLine("2.- Sumatorio");
            Console.WriteLine("3.- Factorial");

            Console.WriteLine("Escoja el numero del proceso a realizar");
            numero = int.Parse(Console.ReadLine());

            if(numero > 2)
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado = resultado * i;
                }
                Console.WriteLine("El factorial de " + numero + " es:" + resultado);
                Console.WriteLine("Escoja el numero del proceso a realizar");
                numero = int.Parse(Console.ReadLine());

            }
            else
            {
                if(numero!= 1)
                {
                    for (int i = 1; i <= 1; i++)
                    {
                        sumatoria = sumatoria + numero;
                    }
                    Console.WriteLine("Sumatoria del numero es"+sumatoria);
                    Console.ReadLine();
                    Console.WriteLine("Escoja el numero del proceso a realizar");
                    numero = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Salir");
                    Console.ReadKey();
                }
            }
        }
    }
}
