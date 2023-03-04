namespace Iterator.Iterators
{
    public interface IIterater<T>
    {
        T Next();
        T Current { get; }
        bool IsLast();
    }
}