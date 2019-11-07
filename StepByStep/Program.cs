using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace StepByStep
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers1 = new List<int> { 1, 3, 4 };
            List<int> numbers2 = new List<int> { 2, 4, 5, 6, 3 };
            int[] array2 = new[] { 13, 33 };
            LinkedList<int> linklist1 = new LinkedList<int>();

            Queue<int> queue1 = new Queue<int>();
            Stack<int> stack1 = new Stack<int>();
            int[] array1;
            numbers1.Add(5);
            numbers1.Insert(1, 10);
            numbers1.Remove(4);
            numbers1.RemoveAt(3);
            numbers1.AddRange(numbers2);
            array1 = numbers1.ToArray();
            int a = numbers1[3];
            foreach (var item in numbers1)
            {
                Console.WriteLine(item);
            }

            foreach (int item in array1)
            {
                linklist1.AddFirst(item);
            }
            foreach (int item in linklist1)
            {
                Console.WriteLine(item);
            }
            for (LinkedListNode<int> node = linklist1.First; node != null; node = node.Next)
            {
                Console.WriteLine(node.Value);
            }
            for (LinkedListNode<int> node = linklist1.Last; node != null; node = node.Previous)
            {
                Console.WriteLine(node.Value);
            }
            */
            //StaticClass.Dictionary.DoWork();
            //StaticClass.HashSet.DoWork();
            //StaticClass.List.DoWork();


            StaticClass.Lambda lambda = new StaticClass.Lambda();
            lambda.DoWork();

            
        }


    }
}
