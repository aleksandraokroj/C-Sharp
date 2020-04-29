using System;
using System.Linq;

namespace TotoLotek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] tablica = new int[6];
            Random generator = new Random();

            int i = 0;
            while(i<6)
            {
                int liczba = generator.Next(1, 49);
                if(!tablica.Contains(liczba))
                {
                    tablica[i] = liczba;
                    i++;
                }
            }
            Console.WriteLine("Wylosowane liczby to:");
            foreach (int liczbaa in tablica)
            {
                Console.Write("{0} ,", liczbaa);
            }
            Console.ReadKey();
           

        }
    }
}
