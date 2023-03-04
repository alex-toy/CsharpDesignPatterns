using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User bob = new User("bob", 32);
            Subject subject = new Subject(bob);

            Observer observer1 = new Observer("O1");
            subject.Subscribe(observer1);

            Observer observer2 = new Observer("O2");
            subject.Subscribe(observer2);

            Observer observer3 = new Observer("O3");
            subject.Subscribe(observer3);

            subject.UpdateAge(23);

            subject.UpdateName("alex");

            Console.ReadLine();
        }
    }
}
