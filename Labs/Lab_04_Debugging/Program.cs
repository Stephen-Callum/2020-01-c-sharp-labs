using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Lab_04_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("../log.dat", "");
            int x = 10;
            x += 10;
            int y = x * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Trace.WriteLine($"Your numnber is {i}");
                Debug.WriteLineIf(i == 6, "Hey, i is 6!!!");
                
                // Use @ symbol to provide clean string literal
                File.AppendAllText(@"C:\logs\log.dat", $"\nLogging i={i} at {DateTime.Now}");
                Thread.Sleep(1000);
            }

            // Print file
            var logFilePath = @"C:\logs\log.dat";
            Console.WriteLine("\n\nPrinting contents of log file\n\n");
            Console.WriteLine(File.ReadAllText(logFilePath));
        }
    }
}
