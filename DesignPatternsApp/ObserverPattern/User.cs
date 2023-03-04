namespace ObserverPattern
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name = null, int age = 0)
        {
            Name = name;
            Age = age;
        }
    }
}
