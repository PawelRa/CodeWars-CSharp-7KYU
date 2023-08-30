using System;
using System.Collections.Generic;
namespace Insert_dashes
{
    public class Kata
    {
        public static string InsertDash(int num)
        {
            string tempVale = num.ToString();
            string result = "";
            result += tempVale[0];

            for (int i = 1; i < tempVale.Length; i++)
            {
                int x = (int)char.GetNumericValue(tempVale[i]);
                int y = (int)char.GetNumericValue(tempVale[i - 1]);
                if (x % 2 == 1 && y % 2 == 1)
                {
                    result += "-";
                }
                result += x;
            }
            return result;
        }
    }
}
