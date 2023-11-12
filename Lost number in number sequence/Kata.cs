using System;
using System.Collections.Generic;

namespace Lost_number_in_number_sequence
{
    public class Kata
    {
        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            startingList.Sort();
            mixedList.Sort();
            if (startingList.Count == mixedList.Count) { return 0; }
            if (startingList.Count == 1 && (mixedList.Count == 0 || mixedList == null)) return startingList[0];

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (startingList[i] != mixedList[i]) { return startingList[i]; }
            }
            return startingList[startingList.Count - 1];
        }
    }
}