using StrategyPattern.Strategies;

namespace StrategyPattern
{
    public class NumberSorter
    {
        private readonly ISortStrategy sortStrategy;

        public NumberSorter(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Sort(int[] input)
        {
            var sorted = sortStrategy.Sort(input);
            foreach (var item in sorted) System.Console.WriteLine(item);
        }
    }
}
