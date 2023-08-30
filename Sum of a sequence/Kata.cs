using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_a_sequence
{
    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
        {
            if (start > end)
            {
                return 0;
            }

            int result = 0;

            for (int i = start; i <= end; i = i + step)
            {
                result += i;
            }

            return result;
        }
    }
}
