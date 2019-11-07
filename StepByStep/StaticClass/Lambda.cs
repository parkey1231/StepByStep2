using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepByStep.StaticClass
{
    public class Lambda
    {
        List<Person> personnel = new List<Person>()
        {
            new Person(){ID= 1,Name ="John",Age =51},
            new Person(){ID= 2,Name ="Sid",Age =20},
            new Person(){ID= 3,Name ="Fred",Age =30},
            new Person(){ID= 4,Name ="Paul",Age =51}

        };
      
        public void DoWork()
        {
            Person match = personnel.Find(p => p.ID == 3);
            double avg = personnel.Average((p) => { return p.Age; });
            int count = personnel.Count(p => { return p.Age > 25 && p.Age < 40; });
            Console.WriteLine(count);
            Console.WriteLine(avg);
            Person person = personnel.Find((Person p) => { return p.ID == 3; });
            Console.WriteLine($"ID :{match.ID} \nName: {match.Name}\nAge: {match.Age}");



        }
    }

    struct Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
