using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_the_minimum
{
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count < 1) return new List<int>();

            int min = numbers.Min();
            int minIndex = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == min)
                {
                    minIndex = i;
                    break;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == minIndex) { continue; }
                else
                {
                    result.Add(numbers[i]);
                }
            }

            return result;
        }
    }
}
