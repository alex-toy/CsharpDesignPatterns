namespace PrototypePattern.Models
{
    public class User : IUser
    {
        private string name;
        private int age;
        private string address;


        public string Name { get { return name;  } }
        public int Age { set { age = value; } }
        public string Address { get { return address; } }

        public User(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
