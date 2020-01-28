using System;
using System.Diagnostics;
using System.Threading;
namespace Lab_30_StopwatchDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();

            s.Start();
            Thread.Sleep(1000);
            int bigNumber = 1_000;
            int total = 0;
            for (int i = 0; i < bigNumber; i++)
            {
                total += i;
                for (int j = 0; j < bigNumber; j++)
                {
                    total += i;
                    for (int k = 0; k < bigNumber; k++)
                    {
                        total += i;
                    }
                }
            }
            s.Stop();
            Console.WriteLine(s.Elapsed);   // HH:MM:SS.1234567
            Console.WriteLine(s.ElapsedMilliseconds);   // 10-3 seconds
            Console.WriteLine(s.ElapsedTicks);  // 10-7 seconds

            var date01 = new DateTime();
            Console.WriteLine($"default date is {date01}");

            var date02 = DateTime.Today;    // MIDNIGHT
            var date03 = DateTime.Now;      // NOW

            var date04 = new DateTime(2019, 12, 12, 05, 05, 00);    // LITERAL y m d h m s

            // Change time
            var tomorrow = date02.AddDays(1);
            var nextWeek = date02.AddDays(7);
            var timeSpan = nextWeek - date02;
            Console.WriteLine(timeSpan.ToString());

            // Printing Date
            Console.WriteLine(tomorrow.ToShortDateString());
            Console.WriteLine(tomorrow.ToLongDateString());
            Console.WriteLine(tomorrow.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(tomorrow.ToString("dd-mm-yyyy HH:mm:ss"));
            Console.WriteLine(tomorrow.ToString("dd-mm-yy HH:mm:ss"));
            Console.WriteLine(tomorrow.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(tomorrow.ToString("dd-MM-yyyy HH:mm:ss"));
        }
    }
}
