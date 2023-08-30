using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_the_exam
{
    public static class Kata
    {
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int score = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    score += 4;
                    continue;
                }

                if (arr2[i] == "")
                {
                    continue;
                }
                if (arr1[i] != arr2[i])
                {
                    score -= 1; continue;
                }
            }
            return score <= 0 ? 0 : score;
        }
    }
}
