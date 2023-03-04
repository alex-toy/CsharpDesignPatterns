namespace DecoratorPattern.Models
{
    public interface ICar
    {
        void AddOption(string option);
        void PrintOptions();
    }
}
