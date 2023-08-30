using System.Collections.Generic;
using System.Linq;

namespace Sum_of_Minimums
{
    class Kata
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            List<int> result = new List<int>();

            for (int x = 0; x < numbers.GetLength(0); x++)
            {
                int min = int.MaxValue;
                for (int y = 0; y < numbers.GetLength(1); y++)
                {
                    if (numbers[x, y] < min) { min = numbers[x, y]; }
                }
                result.Add(min);
            }

            return result.Sum();
        }
    }
}
