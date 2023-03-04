using FlyweightPattern.Models;

namespace FlyweightPattern.Factories
{
    public interface ICarFactory
    {
        ICar GetCar(string type);
    }
}