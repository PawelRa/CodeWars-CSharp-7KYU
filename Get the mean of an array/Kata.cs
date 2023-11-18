using System;
using System.Linq;

namespace Get_the_mean_of_an_array
{
    public class Kata
    {
        public static int GetAverage(int[] marks)
        {
            return (int)Math.Floor(marks.Average());
        }
    }
}
