using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace StepByStep
{

    struct ss
    {

    }
    interface Idd
    {
        void te(int a);
    }

    class Sto
    {
        public int method(int a, int b)
        {
            return 4;
        }


    }
    delegate int Dele(int a, int b);

    static class Program
    {
        static void DoWork()
        {
            Student student1 = new Student() { BirthDay = DateTime.Parse("1988-9-20"), ClassCode = 100, ClassName = "A", Grade = 1, StudentCode = 001, StudentName = "Dim" };
            Student student2 = new Student() { BirthDay = DateTime.Parse("1984-11-20"), ClassCode = 101, ClassName = "B", Grade = 2, StudentCode = 009, StudentName = "Tim" };
            Student student3 = new Student() { BirthDay = DateTime.Parse("1984-2-20"), ClassCode = 100, ClassName = "F", Grade = 3, StudentCode = 005, StudentName = "Fred" };
            Student student4 = new Student() { BirthDay = DateTime.Parse("1983-9-20"), ClassCode = 103, ClassName = "D", Grade = 4, StudentCode = 004, StudentName = "John" };
            Student student5 = new Student() { BirthDay = DateTime.Parse("1989-6-20"), ClassCode = 100, ClassName = "E", Grade = 5, StudentCode = 002, StudentName = "Toms" };

            List<Student> studentsList = new List<Student>() { student1, student2, student3, student4, student5 };

            var list001 = studentsList.Where(t => t.ClassCode == 100);
            var list002 = studentsList.Count(t => t.ClassCode == 100);
            var list003 = studentsList.Where(e => e.ClassCode == 100).OrderBy(e => e.StudentCode);

            foreach (var item in list001)
            {
                Console.WriteLine(item.ClassName);
            }

            Console.WriteLine(list002);

            Console.WriteLine(student1.BirthDay);

            foreach (var item in list003)
            {
                Console.WriteLine($"\n{item.StudentName}");
            }

        }

        static void Main(string[] args)
        {

            Sto sto = new Sto();
            Dele dele1 = new Dele(sto.method);
            Dele dele = new Dele(new Sto().method);
            dele += new Dele(sto.method);
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




            DoWork();

            //StaticClass.Dictionary.DoWork();
            //StaticClass.HashSet.DoWork();
            //StaticClass.List.DoWork();

        }
    }
}
