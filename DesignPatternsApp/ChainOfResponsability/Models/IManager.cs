namespace ChainOfResponsability.Models
{
    public interface IManager
    {
        void ApproveRequest(ExpenseReport expense);
        void SetSupervisor(IManager manager);
    }
}
