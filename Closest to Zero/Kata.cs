using System;

namespace Closest_to_Zero
{
    public class Kata
    {
        public static int? Closest(int[] arr)
        {
            Array.Sort(arr);
            int tempValue = int.MinValue;
            int valueLen = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int tempValueLen = int.MaxValue;

                if (arr[i] < 0)
                {
                    tempValueLen = arr[i] * (-1);
                }

                if (arr[i] == 0) { return 0; }

                if (arr[i] > 0)
                {
                    tempValueLen = arr[i];
                    if (tempValueLen == valueLen && arr[i] != tempValue) { return null; }
                    if (tempValueLen > valueLen) { return tempValue; }
                }

                if (tempValue < valueLen)
                {
                    valueLen = tempValueLen;
                    tempValue = arr[i];
                }
            }

            return tempValue;
        }
    }
}
