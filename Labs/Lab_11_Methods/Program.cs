using System;
using System.Diagnostics;
using System.IO;

namespace Lab_11_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis();
            DoThis(100);
            DoThis("Hi");
            DoThis("hi", 100, true, DateTime.Now);
            DoThis("hi", 100, true, DateTime.Now, 10, 100000);
            DoThis(x: "hi", y: 100, z: true, time:DateTime.Now);
        }

        static void DoThis() { Console.WriteLine("No parameters"); }
        static void DoThis(int x) { Console.WriteLine($"Int {x}"); }
        static void DoThis(string x) { Console.WriteLine($"string {x}"); }
        static void DoThis(string x, int y, bool z, DateTime time) { Console.WriteLine($"{x}{y}{z}{time}"); }
        static void DoThis(string x, int y, bool z, DateTime time, int optional1 = 100, int opt2 = 1000) { 
            Console.WriteLine($"{x}{y}{z}{time}{optional1}{opt2}");
            string csvoutput = $"{x,-5}, {y,-5}, {z,-10}, {time,-25}, {optional1,-15}, {opt2}";
            File.AppendAllText("output.csv", csvoutput);

            //view as spreadsheet
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", "output.csv");

        }
    }
}
