using System.Collections.Generic;

namespace Sum_a_list_but_ignore_any_duplicates
{
    public class Kata
    {
        public static int SumNoDuplicates(int[] arr)
        {
            var tempList = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (tempList.ContainsKey(i))
                {
                    tempList[i]++;
                }
                else { tempList.Add(i, 1); }
            }

            int result = 0;

            foreach (KeyValuePair<int, int> para in tempList)
            {
                // Console.WriteLine("Klucz: {0}, Wartość: {1}", para.Key, para.Value);
                if (para.Value == 1) { result += para.Key; }
            }

            return result;
        }
    }
}
