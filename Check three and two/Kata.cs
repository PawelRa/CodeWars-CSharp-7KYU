using System.Collections.Generic;

namespace Check_three_and_two
{
    public class Kata
    {
        public static bool CheckThreeAndTwo(string[] array)
        {
            var tempList = new Dictionary<string, int>();

            foreach (var item in array)
            {
                if (tempList.ContainsKey(item))
                {
                    tempList[item]++;
                }
                else { tempList.Add(item, 1); }
            }

            foreach (KeyValuePair<string, int> para in tempList)
            {
                if (para.Value != 2 && para.Value != 3)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
