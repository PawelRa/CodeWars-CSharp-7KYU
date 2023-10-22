using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_remove_duplicates
{
    public class Solution
    {
        public static int[] solve(int[] arr)
        {
            var testValue = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (testValue.ContainsKey(item))
                {
                    continue;
                }
                else
                {
                    testValue[item] = 1;
                }
            }

            return new List<int>(testValue.Keys).ToArray();
        }
    }
}
