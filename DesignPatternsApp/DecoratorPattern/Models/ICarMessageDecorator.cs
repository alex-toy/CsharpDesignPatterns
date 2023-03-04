namespace DecoratorPattern.Models
{
    public interface ICarMessageDecorator : ICar
    {
        void Decorate(string message);
    }
}
