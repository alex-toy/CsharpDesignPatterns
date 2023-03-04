namespace FlyweightPattern.Models
{
    public interface ICar
    {
        //Intrisic data :
        string Color { get; }
        string Engine { get; }

        void SetLocation(decimal lat, decimal lon);
    }
}
