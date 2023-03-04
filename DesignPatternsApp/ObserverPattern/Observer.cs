using System;

namespace ObserverPattern
{
    public class Observer : IObserver<User>
    {
        public string Name { get; set; }

        public Observer(string name)
        {
            Name = name;
        }

        public void OnCompleted()
        {
            Console.WriteLine("completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("error");
        }

        public void OnNext(User user)
        {
            Console.WriteLine($"Observer {Name} has observed -> Name : {user.Name} - Age : {user.Age}");
        }
    }
}
