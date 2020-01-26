#define THISISTRUE
using System;

namespace Lab_06_ConditionalCompiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is always printed");
#if DEBUG
            Console.WriteLine("This is debug code");
#else
            Console.WriteLine("This is production code");
#endif

#if THISISTRUE
            Console.WriteLine("This is true");
#endif
        }
    }
}
