using System;

namespace MnozenieMacierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=3, M=3, K=2;
            int[,] macierzA = new int[N, K];
            int[,] macierzB = new int[K, M];
            int[,] macierzC = new int[N, M];
            Console.WriteLine("Podaj elementy macierzy A"); 
            for (int i =0; i<N; i++)
            {
                for (int j=0; j<K; j++)
                {
                    Console.Write("A[{0},{1}]", i + 1, j + 1);
                    macierzA[i, j] = int.Parse(Console.ReadLine());
                        }
            }
            Console.WriteLine("Podaj elementy macierzy B");
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("A[{0},{1}]", i + 1, j + 1);
                    macierzB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i=0; i<N; i++)
            {
                for (int j=0; j<M; j++)
                {
                    for (int k=0; k<K; k++)
                    {
                        macierzC[i, j] = macierzA[i, k] * macierzB[k, i];
                    }
                }

            }

           Console.WriteLine("Wynikiem mnożenia podanych macierzy jest macierz:");
            for (int i = 0; i < macierzC.GetLength(0); i++)
            {
                for (int j = 0; j < macierzC.GetLength(1); j++)
                {
                    Console.Write("{0,10}, ", macierzC[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();





        }
    }
}
