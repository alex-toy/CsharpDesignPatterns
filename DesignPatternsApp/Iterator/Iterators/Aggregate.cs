using System.Collections.Generic;

namespace Iterator.Iterators
{
    public class Aggregate<T> : IAggregate<T>
    {
        private IIterater<T> _iterater;
        private List<T> _list = new List<T>();

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list.Add(value); }
        }

        public IIterater<T> Iterater
        {
            get
            {
                if (_iterater == null) return new Iterater<T>(this);
                return _iterater;
            }
        }

        public int Count => _list.Count;
    }
}
