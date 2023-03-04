using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject : IObservable<User>, IDisposable
    {
        private readonly User _user;
        private IList<IObserver<User>> _observers = new List<IObserver<User>>();

        public Subject(User user)
        {
            _user = user;
        }

        public void Dispose()
        {
            _observers.Clear();
        }

        public IDisposable Subscribe(IObserver<User> observer)
        {
            _observers.Add(observer);
            observer.OnNext(_user);
            return this;
        }

        public void UpdateAge(int age)
        {
            _user.Age = age;
            foreach (IObserver<User> observer in _observers)
            {
                observer.OnNext(_user);
            }
        }

        public void UpdateName(string name)
        {
            _user.Name = name;
            foreach (IObserver<User> observer in _observers)
            {
                observer.OnNext(_user);
            }
        }
    }
}
