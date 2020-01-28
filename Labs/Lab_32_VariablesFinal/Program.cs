using System;

namespace Lab_32_VariablesFinal
{
    class Program
    {
        // readonly in class field
        readonly double PII = 3.1315;

        // propert - use get bot set // set with constructor but at no other time
        public DateTime DateOfBirth { get; }

        static void Main(string[] args)
        {
            // const
            const double PI = 3.1415;

            // null
            var emptyString = "";       // box for data but nothing in the box
            string nullString = null;   // points to 'null' element
            Console.WriteLine($"Is an empty string null? {emptyString == nullString}");

            //null coalesce
            //if.. is null ... do this.. else ... do this

            string databaseitem = null;
            string myItem = databaseitem ?? "Invalid value";
            Console.WriteLine(myItem);  // invalid value
            
            databaseitem = "real item";
            myItem = databaseitem ?? "Invalid value";
            Console.WriteLine(myItem);  // real value

            databaseitem = null;
            //can't take length of null so will throw exception
            // null check
            Console.WriteLine(databaseitem?.Length);    // safely returns null

            // Casting and Boxing
            // Casting from one type to another
            double num01 = 1.23;
            int integer01 = (int)num01;     // CAST IS A DANGEROUS OPERATION ==> Cut / truncate data
            Console.WriteLine($"{num01} becomes {integer01}");

            // OK from int to double 1 ==> 1.0 safely
            int integer02 = 12;
            double num02 = integer02;   // implicit cast

            // Boxing cast to general object
            var item01 = 12;
            var item02 = "hi";
            var object01 = (object)item01;
            var object02 = (object)item02;
            // Object is parent of all parents IE TOP OF COMPUTER HIERARCHY
            int getItemBack = (int)object01;

            // nullable types
            // INTEGERS CANNOT BE NULL
            // DOUBLES CANNOT BE NULL
            // BOOLEANS CANNOT BE NULL
            int num03 = default; // 0 (not null)
            // database number which is blank ==> 0 ??? incorrect as it's a value
            int? databaseNumber = null;
            bool? databaseIsAlive = null;
            double? databasePrice = null;
        }
    }
}
