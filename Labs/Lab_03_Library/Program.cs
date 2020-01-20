using System;
using Lab_03_Library_Files;

namespace Lab_03_Use_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // OOP : to use a class you create a new instance to communicate with the class
            var myInstance = new MyClass();

            Console.WriteLine(myInstance.DoubleUp(10));

            var constant = myInstance.GravitationalConstant;
            Console.WriteLine(constant);

            Console.WriteLine("Now reference static items");
            Console.WriteLine(MyClass.TripleUp(10));
            Console.WriteLine(MyClass.NaturalLogE);
        }
    }
}
