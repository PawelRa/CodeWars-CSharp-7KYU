namespace Get_the_Middle_Character
{
    public class Kata
    {
        public static string GetMiddle(string s)
        {
            return s.Length % 2 == 0 ? $"{s[s.Length / 2 - 1].ToString()}{s[s.Length / 2].ToString()}" : s[s.Length / 2].ToString();
        }
    }
}
