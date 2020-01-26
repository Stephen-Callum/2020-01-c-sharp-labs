using System;

namespace Lab_17_ValueReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 1;
            //Console.WriteLine($"x before copy = {x}");
            //int y = x;
            //Console.WriteLine($"y = {y}");
            //x = 100;
            //Console.WriteLine($"New x = {x}");
            //Console.WriteLine($"y again = {y}");

            //Console.WriteLine("Array 1");
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine("Array 2");
            //int[] arr2 = arr;
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //arr[3] = 1738;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            int num1 = 1000;
            var dog01 = new Dog();
            dog01.Age = 10;

            Console.WriteLine(num1);
            AddOne(num1);
            Console.WriteLine(num1);

            Console.WriteLine(dog01.Age);
            AddOneYearToDogAge(dog01);
            Console.WriteLine(dog01.Age);

        }

        static void AddOne(int num)
        {
            num += 1;
        }

        static void AddOneYearToDogAge(Dog d)
        {
            d.Age++;
        }

    }

    class Dog
    {
        public int Age { get; set; }
    }
}
