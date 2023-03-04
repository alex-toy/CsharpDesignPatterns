namespace FacadePattern.Models
{
    public class InventoryService : IInventoryService
    {
        public string[] Get()
        {
            return new[] { "book", "pen" };
        }
    }
}
