using System;

namespace Wyrazenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Podaj wartość x:");
                x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość y:");
                y = int.Parse(Console.ReadLine());

            if (x < 0 && y < 0)
            { z = x * y; }
            else if (x == 0 || y == 0)
            { z = 10; }
            else z = x + y;
           
            Console.WriteLine("Z wynosi: {0}", z);
            Console.ReadKey();

                


        }
    }
}
