using System;

namespace Ones_and_Zeros
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            string number = "";

            foreach (int i in BinaryArray)
            {
                number += i;
            }

            return Convert.ToInt32(number, 2);
        }
    }
}
