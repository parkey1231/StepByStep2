using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepByStep.StaticClass
{
   static class HashSet
    {
        public static void DoWork()
        {
            HashSet<string> employees1 = new HashSet<string>(new string[] { "Fred", "Bert", "Harry", "John" });
            HashSet<string> customers1 = new HashSet<string>(new string[] { "John", "Sid", "Harry", "Diana" });

            employees1.Add("James");
            customers1.Add("Francesca");

            Console.WriteLine("\nEmployees");
            foreach (string name in employees1)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nCustomers");
            foreach (string name in customers1)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nCustomer who are the employees:");
            customers1.IntersectWith(employees1);
            foreach (string name in customers1)
            {
                Console.WriteLine(name);
            }
        }
    }
}
