using System;

namespace Count_the_Ones
{
    public class Kata
    {
        public static int HammingWeight(int x)
        {
            string value = Convert.ToString(x,2);

            int result = 0;

            foreach(var i in value)
            {
               if (i == '1') { result++; }
            }

            return result;
        }
    }
}
