using System;

namespace Lab_31_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum good for items not changing
            //daysofweek
            //months of year
            var fruit01 = Fruit.Apple;
            Console.WriteLine(fruit01);
            Console.WriteLine((int)fruit01);
            Console.WriteLine($"How many fruits? {(int)Fruit.Count}");

            // enums can be used in powers of to to generate codes
            // read = 1     write = 2       execute = 4
        }
    }

    enum Fruit
    {
        Apple, Pear, Lemon, Strawberry, Count
    }

    enum Vegetables
    {
        onion=10, leek, potato, turnip
    }

    enum Permissions
    {
        read=1,write=2,execute=4
    }
}
