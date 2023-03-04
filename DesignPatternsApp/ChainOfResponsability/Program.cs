using ChainOfResponsability.Models;
using System;

namespace ChainOfResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEO ceo = new CEO();

            BUBoss buBoss = new BUBoss();
            buBoss.SetSupervisor(ceo);

            SeniorManager manager = new SeniorManager();
            manager.SetSupervisor(buBoss);

            ExpenseReport expense = new ExpenseReport("restaurant", 100);
            manager.ApproveRequest(expense);

            ExpenseReport expense2 = new ExpenseReport("monitor", 3000);
            manager.ApproveRequest(expense2);

            ExpenseReport expense3 = new ExpenseReport("instruments", 45000);
            manager.ApproveRequest(expense3);

            ExpenseReport expense4 = new ExpenseReport("office", 60000);
            manager.ApproveRequest(expense4);

            Console.ReadLine();
        }
    }
}
