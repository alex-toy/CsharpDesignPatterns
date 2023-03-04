namespace Iterator.Iterators
{
    public class Iterater<T> : IIterater<T>
    {
        private readonly IAggregate<T> _aggregate;
        int index = 0;

        public Iterater(IAggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public T Current => _aggregate[index];

        public bool IsLast() => index >= _aggregate.Count;

        public T Next()
        {
            index++;
            return !IsLast() ? _aggregate[index] : default;
        }
    }
}
