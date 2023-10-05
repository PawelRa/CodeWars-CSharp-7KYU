using System;
using System.Linq;

namespace Excel_sheet_column_numbers
{
    public class ExcelToNumber
    {
        public static long TitleToNumber(string title)
        {
            long result = 0;
            char[] chars = title.Reverse().ToArray();

            
            for (int i = 1; i <= chars.Length-1; i++)
            {
                long level = (long)Math.Pow(26,i);
                result += level * (chars[i] % 32);
            }



            return result + (chars[0] % 32);
        }
    }
}
