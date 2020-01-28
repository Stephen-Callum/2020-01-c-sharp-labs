using System;

namespace Lab_29_VariablesContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            string s01 = "hi";

            var s02 = new String("hi");

            // Struct is short for 'structure
            // Used to build our primitive types eg INT, Bool
            // Custom 'Struct'
            // Think about a STRUCT as A Mini-Class
            // Struct is a Value type

            var Point01 = new PointOnGraph(10, 10);

            // STRING FORMATTING
            double num01 = 1.234567;
            double num02 = 7.898989;
            double long01 = 123456789;
            Console.WriteLine($"Here are some numbers");
            Console.WriteLine($"No decimal place {num01,-10:N0}{num02,-10:N0}");
            Console.WriteLine($"1 DP {num01,-10:N1}{num02,-10:N1}");
            Console.WriteLine($"2 DP {num01,-10:N2}{num02,-10:N2}");
            Console.WriteLine($"3 DP {num01,-10:N3}{num02,-10:N3}");
            Console.WriteLine($"Currency {num01,-10:C}{num02,-10:C}");
            Console.WriteLine($"Exponential {long01,-15:E}{long01,-15:E}{long01,-15:E}");

        }
    }

    class SomeClass
    {

    }

    struct PointOnGraph
    {
        public int X;
        public int Y;

        public PointOnGraph(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
