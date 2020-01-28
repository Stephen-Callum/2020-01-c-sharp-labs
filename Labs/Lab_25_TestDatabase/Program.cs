using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_25_TestDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wrap database call in 'using' statement
            // Using ==> Clean up code afterwards even
            // If system failure
            // Creates new instance of database

            // Create empty list to put data in.
            List<TestTable> itemList = new List<TestTable>();
            using (var db = new testdatabaseEntities())
            {
                // List of items = (Call the database),
                //                  Extract TestTable Data
                //                  Convert output to list type
                itemList = db.TestTables.ToList();
            }
            
            // FOREACH.. print items
            foreach (var item in itemList)
            {
                Console.WriteLine($"{item.TestName} has an ID of{item.TestTableID} and an age of {item.TestAge} years old.");
            }
        }
    }
}
