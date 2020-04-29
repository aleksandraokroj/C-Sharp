using System;

namespace zdaniazamiana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz zdanie");
            string[] text = Console.ReadLine().Split(" ");
            string[] text2 = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                text2[i] = text[i];
            }
            string słowo;
            słowo = text[text.Length - 1];
            text2[text.Length - 1] = text[0];
            text2[0] = słowo;

            foreach(string litera in text2){

                Console.Write(litera);
            }

            Console.ReadKey();

        }
    }
}
