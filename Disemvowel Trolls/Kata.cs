using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvowel_Trolls
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            string result = "";

            foreach (char s in str)
            {
                if (Char.ToLower(s) == 'a') { continue; }
                if (Char.ToLower(s) == 'e') { continue; }
                if (Char.ToLower(s) == 'i') { continue; }
                if (Char.ToLower(s) == 'o') { continue; }
                if (Char.ToLower(s) == 'u') { continue; }

                result += s;
            }

            return result;
        }
    }
}
