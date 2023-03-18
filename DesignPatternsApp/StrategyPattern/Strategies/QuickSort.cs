using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern.Strategies
{
    internal class QuickSort : ISortStrategy
    {
        public int[] Sort(int[] input)
        {
            if (input == null || input.Length <= 1) return input;

            int centerIndex = input.Length / 2;
            int centerValue = input[centerIndex];

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (i == centerIndex) continue;
                if (input[i] <= centerValue) left.Add(input[i]); else right.Add(input[i]);
            }

            List<int> sorted = Sort(left.ToArray()).ToList();
            sorted.Add(centerValue);
            var rightSorted = Sort(right.ToArray()).ToList();
            sorted.AddRange(rightSorted);

            return sorted.ToArray();
        }
    }
}
