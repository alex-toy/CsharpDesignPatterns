using DecoratorDesignPattern.Cars;

namespace DecoratorDesignPattern.Models
{
    public class CarDecorator : ICar
    {
        private ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetOptions()
        {
            return _car.GetOptions();
        }
    }
}
