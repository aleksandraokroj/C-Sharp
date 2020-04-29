using System;

namespace SumaIloczyn2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n, k, a, iloczyn, suma;
            iloczyn = 1;
            suma = 0;
            Console.WriteLine("Podaj wartość zmiennej n:");
            n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartość zmiennej k:");
            k = Convert.ToUInt32(Console.ReadLine());
            a = k;
            for (int i = 0; i < n; i++)
            {
                suma += a;
                checked
                {
                    iloczyn *= a;
                }
                a += k;

            }
            Console.WriteLine("suma=" + suma);
            Console.WriteLine("iloczyn=" + iloczyn);
            Console.ReadKey();

        }
    }
}
