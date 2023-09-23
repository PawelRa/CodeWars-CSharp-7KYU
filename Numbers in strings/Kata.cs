using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers_in_strings
{
    public static class Kata
    {
        public static int Solve(string s)
        {
            List<int> list = new List<int>();
            string tempNumberString = "";

            foreach (char item in s)
            {
                if (Char.IsNumber(item))
                {
                    tempNumberString += item;
                }
                else
                {
                    if (tempNumberString.Length > 0)
                    {
                        list.Add(Convert.ToInt32(tempNumberString));
                        tempNumberString = "";
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (tempNumberString.Length > 0)
            {
                list.Add(Convert.ToInt32(tempNumberString));
                tempNumberString = "";
            }

            return list.Max();
        }
    }
}
