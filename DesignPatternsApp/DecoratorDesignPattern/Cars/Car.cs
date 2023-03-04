using System;

namespace DecoratorDesignPattern.Cars
{
    public class Car : ICar
    {
        public string GetOptions()
        {
            return "normal car";
        }
    }
}
