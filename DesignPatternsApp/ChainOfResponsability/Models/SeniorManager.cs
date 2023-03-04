using System;

namespace ChainOfResponsability.Models
{
    public class SeniorManager : IManager
    {
        private IManager _manager;

        public void ApproveRequest(ExpenseReport expense)
        {
            if (expense.Amount < 500) Console.WriteLine($"Expense of {expense.Amount} for {expense.Name} approved by senior manager.");
            else _manager.ApproveRequest(expense);
        }

        public void SetSupervisor(IManager manager)
        {
            _manager = manager;
        }
    }
}
