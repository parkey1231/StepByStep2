using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static Genericity.Generic;

using static System.Math;

namespace Genericity
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Queue<int> queue = new Queue<int>(10);
            Queue<string> queue1 = new Queue<string>();
            queue.Enqueer(100);
            queue.Enqueer(22);
            queue.Enqueer(33);
            Console.WriteLine($"{queue.Dequeue()}");
            Console.WriteLine($"{queue.Dequeue()}");
            Console.WriteLine($"{queue.Dequeue()}");

            queue1.Enqueer("a");
            queue1.Enqueer("B");
            queue1.Enqueer("c");
            Console.WriteLine($"{queue1.Dequeue()}");
            Console.WriteLine($"{queue1.Dequeue()}");
            Console.WriteLine($"{queue1.Dequeue()}");

            Console.WriteLine(1%7);
            */
            int a = 10, b = 2;
            Console.WriteLine($"{a},{b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a},{b}");

            string c = "Add", d ="Back";
            Console.WriteLine($"{c},{d}");
            Swap(ref c, ref d);
            Console.WriteLine($"{c},{d}");



        }
    }

    class A<T>
    {
        private T[] data;
        private T Go(T s) 
        {
            T a = s;
            return a; 
        }
        
    }

    class B<T>
    {
        private T[] data;
    }
}
