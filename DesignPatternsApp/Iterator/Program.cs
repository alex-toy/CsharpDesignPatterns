using Iterator.Iterators;
using Iterator.Models;
using System;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aggregate<Person> persons = new Aggregate<Person>();
            persons[0] = new Person("alex", 54);
            persons[1] = new Person("william", 43);
            persons[2] = new Person("shirley", 30000);

            var iterator = persons.Iterater;

            while (!iterator.IsLast())
            {
                string name = iterator.Current.Name;
                int age = iterator.Current.Age;
                System.Console.WriteLine($"{name} is {age} years old.");
                iterator.Next();
            }

            Console.ReadLine();
        }
    }
}
