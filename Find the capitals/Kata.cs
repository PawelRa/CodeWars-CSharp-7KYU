using System;

namespace Find_the_capitals
{
    public static class Kata
    {
        public static int[] Capitals(string word)
        {
            List<int> tempList = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    tempList.Add(i);
                }
            }

            return tempList.ToArray();
        }
    }
}
