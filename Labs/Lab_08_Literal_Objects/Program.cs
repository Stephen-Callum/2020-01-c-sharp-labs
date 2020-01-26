using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Lab_08_Literal_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var string01 = new String("String");
            var string02 = "String literal";

            //array: fixed length
            //long way
            var arr = new int[5]; // Empty memory space to hold 5 integers
            var arr2 = new int[] { 1, 2, 3, 4, 5 }; //Literally defining numbers

            var lst = new List<int>();
            var lst2 = new List<int>() { 2, 4, 56, 3, 1};

            //random object
            dynamic object01 = new ExpandoObject();
            object01.name = "Fred";
            object01.age = 22;
            Console.WriteLine($"object01 has name {object01.name} and age {object01.age}");

            // or

            var object02 = new
            {
                name = "fred",
                age = 22
            };
            Console.WriteLine($"{object02.name} has age {object02.age}");

            // OOP language: create new OBJECT using LITERAL DATA
            var dog1 = new Dog()
            {
                Name = "Fido",
                Age = 4
            };
            Console.WriteLine($"{dog1.Name} is {dog1.Age}.");
        }
    }

    class Dog
    {
        public string Name;
        public int Age;
    }
}
