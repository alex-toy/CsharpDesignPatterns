namespace FlyweightPattern.Models
{
    public class BMWCar : ICar
    {
        public string Engine { get; private set; }
        public string Color { get; private set; }

        public BMWCar(string engine, string color)
        {
            Engine = engine;
            Color = color;
        }

        public void SetLocation(decimal lat, decimal lon)
        {
            Console.WriteLine($"Current location of car {Engine} {Color} is {lat}, {lon}");
        }
    }
}
