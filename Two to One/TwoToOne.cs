using System;
using System.Linq;

namespace Two_to_One
{
    public class TwoToOne
    {

        public static string Longest(string s1, string s2)
        {
            string result = "";
            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();
            char[] sumArray = s1Array.Concat(s2Array).ToArray();
            Array.Sort(sumArray);

            result += sumArray[0];

            for (int i = 1; i < sumArray.Length; i++)
            {
                if (sumArray[i] != sumArray[i - 1])
                {
                    result += sumArray[i];
                }
            }

            return result;
        }
    }
}
