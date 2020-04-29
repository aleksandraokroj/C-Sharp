using System;

namespace Zamiana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz słowo");
            string text = Console.ReadLine();
            char[] text2 = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                text2[i] = text[i];
            }
            char słowo;
            słowo = text[text.Length - 1];
            text2[text.Length - 1] = text[0];
            text2[0] = słowo;

            foreach(char litera in text2){

                Console.Write(litera);
            }

            Console.ReadKey();



            

        }
    }
}
