namespace ChainOfResponsability.Models
{
    public class ExpenseReport 
    {
        public string Name;
        public int Amount;

        public ExpenseReport(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
