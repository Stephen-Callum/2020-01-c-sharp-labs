using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_20_ListQueueStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 10, 20, 30, 40, 50 };
            list.Add(50);
            list.Add(60);
            list.Insert(0, 5);

            list.ForEach(item => Console.WriteLine(item));

            // Queue
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(queue.Peek()); 
            }

            // Stack

            var stack = new Stack<int>(100);
            
            for (int i = 0; i < 100; i++)
            {
                var rand = new Random();
                stack.Push(rand.Next(1,100));
            }

            Console.WriteLine(string.Join(',', stack));

            // Dictionary
            var d = new Dictionary<int, string>();
            d.Add(1, "hi");
            d.Add(2, "there");
            d.Add(3, "people");

            foreach (var item in d)
            {
                Console.WriteLine($"Key {item.Key} has value {item.Value}");
            }

            // Sometimes have to deal with collections of generic objects
            var arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("hi");
            arrayList.Add(new object());

            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} is of type {item.GetType()}");
            }
            Console.WriteLine((int)arrayList[0] + 100);
            Console.WriteLine((string)arrayList[1] + 100);
        }
    }
}
