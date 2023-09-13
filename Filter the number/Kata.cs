using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_the_number
{
    public class Kata
    {
        public static int FilterString(string s)
        {
            string result = "";

            foreach (char c in s)
            {
               if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            
            return Int32.Parse(result);
        }
    }
}
