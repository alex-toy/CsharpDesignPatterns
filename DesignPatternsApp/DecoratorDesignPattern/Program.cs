using DecoratorDesignPattern.Cars;
using DecoratorDesignPattern.Cars.Decorators;
using System;

namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car();
            System.Console.WriteLine(car.GetOptions());

            car = new AutomaticGearDecorator(car);
            System.Console.WriteLine(car.GetOptions());

            car = new AirConditioningDecorator(car);
            System.Console.WriteLine(car.GetOptions());

            car = new ABSDecorator(car);
            System.Console.WriteLine(car.GetOptions());

            Console.ReadLine();
        }
    }
}
