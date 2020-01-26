using System;

namespace Lab_07_Args_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (string item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
