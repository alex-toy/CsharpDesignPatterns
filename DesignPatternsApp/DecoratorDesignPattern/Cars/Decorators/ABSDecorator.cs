using DecoratorDesignPattern.Models;

namespace DecoratorDesignPattern.Cars.Decorators
{
    public class ABSDecorator : CarDecorator
    {
        public ABSDecorator(ICar car) : base(car)
        {
        }

        public override string GetOptions()
        {
            string type = base.GetOptions();
            type += " with ABS break system";
            return type;
        }
    }
}
