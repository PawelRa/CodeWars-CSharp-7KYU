using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograms
{
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                int value = str.Count(x => x == str[i]);
                if (value > 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
