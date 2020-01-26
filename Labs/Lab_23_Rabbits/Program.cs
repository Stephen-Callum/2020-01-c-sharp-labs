using System;
using System.Collections.Generic;

namespace Lab_23_Rabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bonus : put this into WPF?
            
            // create 100 rabbits
            // give them all ID, Name and Age
            var RabbitList = new List<Rabbit>();
            for (int i = 0; i < 100; i++)
            {
                //Rabbit rb = new Rabbit();
                RabbitList.Add(new Rabbit());
            }

            // Print a sample (every 10 items)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{RabbitList[i].RabbitName} with an ID of {RabbitList[i].RabbitId} is {RabbitList[i].Age} years old.");

            }
            RabbitList.ForEach(item => item.Age++);
            // Create a loop to 'age' the rabbits
            // Iterate 50 times and update all the ages


            // Print a sample (every 10th)
        }

        class Rabbit
        {
            public int RabbitId { get; set; }
            public string RabbitName { get; set; }
            public int Age { get; set; }

            string[] firstNames = new string[] { "Stephen ", "Jordan ", "Ahmed ", "Karim ", "Hassan ", "Tim ", "James ", "Jaime", "Asher", "Phil" };

            Random rand = new Random();
            public Rabbit()
            {
                RabbitName = firstNames[rand.Next(0, firstNames.Length - 1)];

                Age = 0;

                RabbitId = rand.Next(0, 1000);
            }
        }
    }
}
