using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latin_Squares
{
    public class LatinSquare
    {
        public static int[][] MakeLatinSquare(int n)
        {
            int z, i;
            z = i = 0;
            int[][] latinSquare = new int[n][];
            var arr = new int[n];

            for (int x = 0; x < n; x++)
                arr[x] = x + 1;

            latinSquare[z] = new int[n];
            arr.CopyTo(latinSquare[z], 0);
            z++;

            while (i < n - 1)
            {
                for (int x = 0; x < n; x++)
                {
                    int per = arr[x];
                    arr[x] = arr[n - 1];
                    arr[n - 1] = per;
                }

                latinSquare[z] = new int[n];
                arr.CopyTo(latinSquare[z], 0);
                z++;
                i++;
            }
            return latinSquare;
        }
    }
}
