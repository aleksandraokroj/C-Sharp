using System;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            int liczba = int.Parse(Console.ReadLine());

            int silnia = 1;
            for (int i= 1; i <= liczba; i++)
            {
                silnia *= i;
            }
            Console.WriteLine("Silnia dla liczby"+ liczba +"to"+ silnia);




            Console.ReadLine();

        }
    }
}
