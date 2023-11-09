namespace Alternate_capitalization
{
    public static class Kata
    {
        public static string[] Capitalize(string s)
        {

            string[] result = { "", "" };

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[0] += char.ToUpper(s[i]);
                    result[1] += char.ToLower(s[i]);
                }
                else
                {
                    result[0] += char.ToLower(s[i]);
                    result[1] += char.ToUpper(s[i]);
                }
            }

            return result;
        }
    }
}
