using System;

namespace Maksimum4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, max1, max2, max3;
            Console.WriteLine("Podaj pierwszą wartość:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą wartość:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią wartość:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj czwartą wartość:");
            d = Convert.ToInt32(Console.ReadLine());

            max1 = a > b ? a : b;
            max2 = c > d ? c : d;
            max3 = max1 > max2 ? max1 : max2;
      
       
            Console.WriteLine("Wartość maksymalna wynosi {0}", max3);
            Console.ReadKey();




        }
    }
}
