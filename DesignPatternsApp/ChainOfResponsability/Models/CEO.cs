using System;

namespace ChainOfResponsability.Models
{
    public class CEO : IManager
    {
        private IManager _manager;

        public void ApproveRequest(ExpenseReport expense)
        {
            if (expense.Amount < 50000) Console.WriteLine($"Expense of {expense.Amount} for {expense.Name} approved by CEO.");
            else Console.WriteLine($"Expense of {expense.Amount} for {expense.Name} not approved by CEO. "); ;
        }

        public void SetSupervisor(IManager manager)
        {
            _manager = manager;
        }
    }
}
