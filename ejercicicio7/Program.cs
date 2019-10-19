using System;

namespace ejercicicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine(x + "\t");
                Console.ReadLine();
             
            }
            for (int x = 100; x >=1; x++)
            {
                Console.WriteLine(x + "\t");
                Console.ReadLine();
              
            }
            Console.ReadKey();
        }
    }
}
