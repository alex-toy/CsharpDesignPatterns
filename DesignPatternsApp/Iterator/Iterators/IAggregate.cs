using Iterator.Iterators;

namespace Iterator
{
    public interface IAggregate<T>
    {
        T this[int index] { get; set; }

        int Count { get; }
        IIterater<T> Iterater { get; }
    }
}