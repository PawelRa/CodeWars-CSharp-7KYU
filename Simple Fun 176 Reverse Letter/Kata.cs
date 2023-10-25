using System.Collections.Generic;

namespace Simple_Fun_176_Reverse_Letter
{
    public class Kata
    {
        public static string ReverseLetter(string str)
        {
            List<char> lettersList = new List<char>();

            foreach (char s in str)
            {
                if (Char.IsLetter(s))
                {
                    lettersList.Add(s);
                }
            }

            lettersList.Reverse();
            string result = String.Join("", lettersList);

            return result;
        }
    }
}
