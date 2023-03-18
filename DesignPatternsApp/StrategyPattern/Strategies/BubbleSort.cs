namespace StrategyPattern.Strategies
{
    public class BubbleSort : ISortStrategy
    {
        public int[] Sort(int[] input)
        {
            var output = input;
            var length = output.Length;
            for (int i = length; i > 2; i--)
            {
                for(int j = 0; j < i-1; j++)
                {
                    if (output[j] > output[j+1])
                    {
                        int temp = output[j];
                        output[j] = output[j+1];
                        output[j+1] = temp;
                    }
                }
            }

            return output;
        }
    }
}
