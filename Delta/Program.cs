using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            try
            {
                Console.WriteLine("Podaj wartość zmiennej a:");
                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    throw new Exception();
                }
                Console.WriteLine("Podaj wartość zmiennej b:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wartość zmiennej c:");
                c = Convert.ToDouble(Console.ReadLine());
                delta =( b * b) - (4 * a * c);
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki: x1={0}, x2={1}", x1, x2);
                }
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine("Równanie ma jeden pierwiastek: x={0}", x1);
                    }
                    else
                    { Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych"); }
                }


            }
            catch
            { Console.WriteLine("zmienna musi być różna od 0"); }
            Console.ReadKey();
        }
    }
}
