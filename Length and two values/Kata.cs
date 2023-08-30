using System.Collections.Generic;

namespace Length_and_two_values
{
    public class Kata
    {
        public static object[] Alternate(int n, object firstValue, object secondValue)
        {
            if (n == 0)
            {
                return new object[0];
            }
            List<object> result = new List<object>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                { result.Add(firstValue); }
                else
                { result.Add(secondValue); }
            }

            return result.ToArray();
        }
    }
}
