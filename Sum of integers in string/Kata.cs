using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_integers_in_string
{
    public class Kata
    {
        public static int SumOfIntegersInString(string s)
        {
            string tempStringValue = "";
            int result = 0;

            foreach (char c in s)
            {
                if (Char.IsNumber(c))
                {
                    tempStringValue += c;
                }
                else
                {
                    if (tempStringValue.Length > 0)
                    {
                        result += Convert.ToInt32(tempStringValue);
                        tempStringValue = "";
                    }

                }
            }
            if (tempStringValue.Length > 0)
            {
                result += Convert.ToInt32(tempStringValue);
                tempStringValue = "";
            }

            return result;
        }
    }
}
