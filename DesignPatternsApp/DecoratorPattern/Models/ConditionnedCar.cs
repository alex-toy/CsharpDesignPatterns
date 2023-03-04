namespace DecoratorPattern.Models
{
    public class ConditionnedCar
    {
        private IList<string> options = new List<string>();

        public void AddOption(string option)
        {
            options.Add(option);
        }

        public void PrintOption()
        {
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }
    }
}
