using System;

namespace Lab_19_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int arraySum = 0;

            foreach (var item in arr)
            {
                arraySum += item;
            }

            Console.WriteLine(arraySum);

            int[,] _2Darr = new int[10,10];

            int k = 0;

            Console.WriteLine(_2Darr.Length);

            for (int i = 0; i < _2Darr.GetLength(0); i++)
            {
                for (int j = 0; j < _2Darr.GetLength(1); j++)
                {
                    _2Darr[i, j] = k;
                    k++;
                }
            }

            for (int i = 0; i < _2Darr.GetLength(0); i++)
            {
                for (int j = 0; j < _2Darr.GetLength(1); j++)
                {
                    Console.Write(_2Darr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
