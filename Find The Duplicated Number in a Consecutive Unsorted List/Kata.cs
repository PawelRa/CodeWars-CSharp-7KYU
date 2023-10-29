using System.Collections.Generic;
using System.Linq;

namespace Find_The_Duplicated_Number_in_a_Consecutive_Unsorted_List
{
    public class Kata
    {
        public static int FindDup(int[] arr)
        {
            Dictionary<int, int> arrList = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (arrList.ContainsKey(i))
                {
                    arrList[i]++;
                }
                else
                {
                    arrList.Add(i, 1);
                }
            }

            return arrList.First(x => x.Value > 1).Key;
        }
    }
}