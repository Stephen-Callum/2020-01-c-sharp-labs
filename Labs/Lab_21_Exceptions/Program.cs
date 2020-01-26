using System;

namespace Lab_21_Exceptions
{
    class Program
    {
        static long num = 9;
        static void Main(string[] args)
        {
            //var bigNumber = int.MaxValue;
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(bigNumber + 1);
            //checked
            //{
            //    Console.WriteLine(bigNumber +1);
            //}

            //Method1(Program.num);
            int x = 10;
            int y = 20;
            int a = 0;
            // unhandled
            try
            {
                int z = x / y;
                double d = x / y;
                Console.WriteLine($"{x} / {y} = {z} and {d}");
                int trouble = y / a;
            }
            catch (Exception e) // handled
            {
                Console.WriteLine("Divide by zero");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
                //throw;
            }
            finally
            {

            }
        }

        public static void Method1(long num)
        {
            //Console.WriteLine("Crash me");
            num *= 2;
            Method1(num);
        }
    }
}
