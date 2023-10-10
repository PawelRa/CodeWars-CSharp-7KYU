using System;

namespace Consecutive_letters
{
    public class Solution
    {
        public static bool solve(string s)
        {
            if (s.Length == 1) return true;

            char[] chars = s.ToCharArray();
            Array.Sort(chars);

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1]) { return false; }
                if (chars[i] != chars[i - 1]+1) { return false; }
            }

            return true;
        }
    }
}
