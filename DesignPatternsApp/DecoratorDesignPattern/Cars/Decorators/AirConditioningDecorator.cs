using DecoratorDesignPattern.Models;

namespace DecoratorDesignPattern.Cars.Decorators
{
    public class AirConditioningDecorator : CarDecorator
    {
        public AirConditioningDecorator(ICar car) : base(car)
        {
        }

        public override string GetOptions()
        {
            string type = base.GetOptions();
            type += " with air conditioning";
            return type;
        }
    }
}
