using DecoratorDesignPattern.Models;

namespace DecoratorDesignPattern.Cars.Decorators
{
    public class AutomaticGearDecorator : CarDecorator
    {
        public AutomaticGearDecorator(ICar car) : base(car)
        {
        }

        public override string GetOptions()
        {
            string type = base.GetOptions();
            type += " with automatic gear";
            return type;
        }
    }
}
