using System;

namespace Compare_Strings_by_Sum_of_Chars
{
    public static class Kata
    {
        public static bool Compare(string s1, string s2)
        {
            int s1Sum = 0;
            int s2Sum = 0;

            if (!string.IsNullOrEmpty(s1) && s1.Length >= 1)
            {
                foreach (char c in s1)
                {
                    if (char.IsLetter(c))
                    {
                        s1Sum += (int)(Char.ToUpper(c));
                    }
                    else
                    {
                        s1Sum = 0;
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(s2) && s2.Length >= 1)
            {

                foreach (char c in s2)
                {
                    if (char.IsLetter(c))
                    {
                        s2Sum += (int)(Char.ToUpper(c));
                    }
                    else
                    {
                        s2Sum = 0;
                        break;
                    }
                }

            }

            return s1Sum == s2Sum;
        }
    }
}
