using System;

namespace Lab_16_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Dog
    {
        public string Name { get; set; }

    }

    class Parent
    {
        private int _hidden;

        public string Exposed { get; set; }

        internal bool isUserLive;       // Visible inside .EXE/DLL but not outside it.

        protected string FamilyName;    // Visible inside of child that inherits from this class

        public void TakeForWalk(Dog d) { Console.WriteLine($"Taking {d.Name} for a walk"); }

    }

    class Child : Parent
    {
        // Cannot put code directly in the class

        // Use constructor but could use any method

        public Child()
        {
            this.FamilyName = "Robertson";
        }
    }
}
