﻿namespace PrototypePattern.Models
{
    public class User : IUser
    {
        private string name;
        private int age;
        private string address;

        public string Name => name;
        public int Age => age;
        public string Address => address;

        private User() { }


        public class UserBuilder
        {
            private readonly User user;

            public UserBuilder()
            {
                user = new User();
            }

            public UserBuilder WithName(string name)
            {
                user.name = name;
                return this;
            }

            public UserBuilder WithAge(int age)
            {
                user.age = age;
                return this;
            }

            public UserBuilder WithAddress(string address)
            {
                user.address = address;
                return this;
            }

            public User Build()
            {
                return user;
            }
        }
    }
}
