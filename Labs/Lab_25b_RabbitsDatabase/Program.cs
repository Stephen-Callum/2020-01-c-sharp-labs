using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_25b_RabbitsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RabbitTable> rabbits = new List<RabbitTable>();
            using(var db = new RabbitDatabaseEntities1())
            {
                rabbits = db.RabbitTables.ToList();
            }

            foreach (var item in rabbits)
            {
                Console.WriteLine($"{item.RabbitName} has an ID of{item.RabbitID} and an age of {item.RabbitAge} years old.");
            }
        }
    }
}