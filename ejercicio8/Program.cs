using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero entero");
            int numero = Convert.ToInt32(Console.ReadLine());

            int doble = 0;
            int triple = 0;

            for(int a = 1; a <=numero; a++)
            {
                Console.Write(a);
                Console.Write(" ");
                
                doble = doble + 2;

                if(doble>numero)
                {
                    Console.Write(" ");

                }
                else
                {
                    Console.Write(doble);

                }
                Console.Write(" ");
                triple = triple + 3;
                if(triple>numero)
                {
                    Console.Write(" ");

                }
                else
                {
                    Console.Write(triple);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
