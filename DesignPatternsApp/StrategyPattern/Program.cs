using StrategyPattern.Strategies;
using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = new int[] { 1, 22, 3, 7, 54, 43, 65, 32, 39, 83, 37, 47 };

            var quickSorter = new NumberSorter(new QuickSort());
            var bubbleSorter = new NumberSorter(new BubbleSort());

            quickSorter.Sort(items);
            //bubbleSorter.Sort(items);

            Console.ReadLine();
        }
    }
}
