using FlyweightPattern.Factories;
using FlyweightPattern.Models;

namespace FlyweightPattern.Managers
{
    public class CarManager : ICarManager
    {
        private decimal lat = 0;
        private decimal lon = 0;
        private readonly ICar _car;

        public CarManager(ICarFactory carFactory, string type)
        {
            _car = carFactory.GetCar(type);
        }

        public void SetLocation(decimal lat, decimal lon)
        {
            lat = lat;
            lon = lon;
            _car.SetLocation(lat, lon);
        }
    }
}
