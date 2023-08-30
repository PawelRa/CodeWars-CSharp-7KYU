using System;

namespace Changing_letters
{
    public static class Kata
    {
        public static string Swap(string s)
        {
            string result = "";

            foreach (char c in s)
            {
                switch (c)
                {
                    case 'a':
                        result += 'A';
                        break;
                    case 'e':
                        result += 'E';
                        break;
                    case 'i':
                        result += 'I';
                        break;
                    case 'o':
                        result += 'O';
                        break;
                    case 'u':
                        result += 'U';
                        break;
                    default:
                        result += c;
                        break;
                }
            }
            return result;
        }
    }
}
