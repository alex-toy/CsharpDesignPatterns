using System;

namespace ObserverPattern
{
    public interface ISubject
    {
        event Action<User> UserChanged;

        void UpdateUserAge(int age);
    }
}