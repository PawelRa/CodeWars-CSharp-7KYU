namespace Vowel_Count
{
    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            foreach (var s in str)
            {
                if (s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u') { vowelCount++; }
            }
            return vowelCount;
        }
    }
}
