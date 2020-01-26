using System;

namespace Lab_18_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (var item in args)
            //{
            //    Console.WriteLine($"args is {args}");
            //}

            //int x = 0;

            //while(x < 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //int y = 0;
            //do
            //{
            //    Console.WriteLine($"y is {y}");
            //} while (y < 10);

            for (int i = 1; i <= 100; i++)
            {
                if(!(i%5==0))
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i==90)
                {
                    break;
                }
            }

            //GOTO
            //Console.WriteLine("Start here");
            //goto _a;
            //Console.WriteLine("Never printed");
            //_a:
            //Console.WriteLine("Jumped to this point");
            //Console.WriteLine("Continue execution");

            //Return
            // if in method then exit the loop/method and return value passed.

            DoThis();
            for (int i = 0; i < 100; i++)
            {
                if (i == 5)
                {
                    throw new Exception("Exception thrown: i == 5");
                }
            }
        }

        private static void DoThis()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i == 10)
                {
                    return;
                }
                Console.WriteLine($"In method DoThis - i is {i}");
            }
        }

        // THROW
        // In some bigger applications they want to track when errors occur eg form validatoin

        
    }

}
