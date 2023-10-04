using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_sheet_column_numbers
{
    public class ExcelToNumber
    {
        public static long TitleToNumber(string title)
        {
            //  long result = (title.Length - 1) * 26;
            long result = 0;
            char[] chars = title.Reverse().ToArray();

            for (int i = 1; i < chars.Length; i++)
            {
                result += chars[i] % 32 * 26 * i;
            }

            return result + (chars[0] % 32);
        }
    }
}
