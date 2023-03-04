namespace DecoratorPattern.Models
{
    public class AutomaticCar : ICar
    {
        private IList<string> options = new List<string>();

        public void AddOption(string option)
        {
            options.Add(option);
        }

        public void PrintOptions()
        {
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }
    }
}
