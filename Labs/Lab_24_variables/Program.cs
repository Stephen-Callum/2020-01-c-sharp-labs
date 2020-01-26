using System;

namespace Lab_24_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // decimals
            // float
            //var num3 = 200.0f;      // 32 bits
            ////double
            //var num4 = 200.0;       // default: 64 bits long
            //// decimal
            //var num5 = 200.0m;      // 128 bits precision (use for money)

            //  OVERFLOW
            // Care!!  INTEGERS WILL TAKE WRONG
            //         DECIMALS WILL TRUNCATE
            // INTEGERS
            int bigNumber = int.MaxValue;
            Console.WriteLine(bigNumber);
            bigNumber *= 10;
            Console.WriteLine(bigNumber);
            checked
            {
                // check for big numbers and throw an exception
            }

            //  DECIMALS - they truncate
            var num6 = 1.23456789012345678901234567890123456789012345678901;
            Console.WriteLine($"long number prints as {num6}");

            // EXPONENTIAL VALUES
            Console.WriteLine($"Max double value is {double.MaxValue}");

            // Care with deciaml equivalents
            double num7 = 0.1;
            double num8 = 0.2;
            if (Math.Abs(num7 + num8) == 0.3)
            {
                Console.WriteLine("numbers match");
                
            }Console.WriteLine(num7+num8);

            // 0.1 ie decimals stored non-precisely in binary
            // Solution
            if (Math.Abs(num8 - num7) < 0.00001)
            {
                Console.WriteLine("Numbers match to 5DP");
            }

            // char
            char char01 = 'f';  // single quote
            Console.WriteLine(char01);
            Console.WriteLine((int)char01);     // f = 102 (in ASCII)
            // other way
            Console.WriteLine((char)103);       // ASCII num 103 = g

            // string
            // string is ARRAY OF CHARS
            string myName = "Phil";
            foreach (var item in myName)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < myName.Length; i++)
            {
                Console.WriteLine(myName[i]);
            }

            // bit
            //bool isAwake = true;

            // byte
            // 8 bits
            //byte byte01 = 0;    // min
            //byte byte02 = 255;  // max      numbers RGB
            //byte byte03 = 0b_1010_1010;     // Binary literal 1010 represents decimal 10 hex A
            //byte byte04 = 0xAA;             // 0x - what follows is hex
            //byte byte05 = 0x10;             // 0x = What follows is hex (Decimal 16)

            // pause till MONDAY
        }
    }
}
