using FlyweightPattern.Models;

namespace FlyweightPattern.Factories
{
    public class CarFactory : ICarFactory
    {
        private readonly IDictionary<string, ICar> cars = new Dictionary<string, ICar>();

        public ICar GetCar(string type)
        {
            if (cars.ContainsKey(type)) return cars[type];
            ICar? car = CreateCar(type);
            cars.Add(type, car);
            return car;
        }

        private ICar CreateCar(string type)
        {
            return type switch
            {
                "bmw" => new BMWCar("V8", "red"),
                "audi" => new BMWCar("V6", "blue"),
                _ => throw new ArgumentException("Invalid choice!"),
            };
        }
    }
}
