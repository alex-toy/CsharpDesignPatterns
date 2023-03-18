using System;
using TemplatePattern.templates;

namespace TemplatePattern.Executors
{
    public class ItemValidator : IItemValidator
    {
        public void Validate()
        {
            Console.WriteLine("item validated");
        }
    }
}
