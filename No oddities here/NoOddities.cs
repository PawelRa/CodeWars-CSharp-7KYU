using System.Collections.Generic;

namespace No_oddities_here
{
    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            List<int> result = new List<int>();

            foreach (int value in values)
            {
                if (value % 2 == 0)
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }
    }
}
