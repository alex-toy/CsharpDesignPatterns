namespace DecoratorPattern.Models
{
    public class CarMessageDecorator : ICarMessageDecorator
    {
        private readonly ICar car;

        public CarMessageDecorator(ICar car)
        {
            this.car = car;
        }

        public void AddOption(string option)
        {
            car.AddOption(option);
        }

        public void Decorate(string message)
        {
            car.AddOption(message);
        }

        public void PrintOptions()
        {
            car.PrintOptions();
        }
    }
}
