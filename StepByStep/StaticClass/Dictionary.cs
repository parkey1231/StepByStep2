using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepByStep.StaticClass
{

    class Dictionary
    {

        public static void DoWork()
        {
            Dictionary<string, int> ages1 = new Dictionary<string, int>();
            SortedDictionary<string, int> ages2 = new SortedDictionary<string, int>() { { "Dengy", 23 } };
            ages2.Add("John", 51);
            ages2.Add("Diana", 50);
            ages2["James"] = 23;
            ages2["Fee"] = 12;

            
            Console.WriteLine("\nDictionary");
            foreach (KeyValuePair<string, int> element in ages2)
            {
                Console.WriteLine($"{element.Key}-{element.Value}");
            }
            Console.WriteLine("\nSortedDictionary");
            foreach (KeyValuePair<string, int> element in ages2)
            {
                Console.WriteLine($"{element.Key}-{element.Value}");
            }

        }

    }
}
