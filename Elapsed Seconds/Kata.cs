using System;

namespace Elapsed_Seconds
{
    public class Kata
    {
        public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
        {
            var result = endDate - startDate;
            return result.Hours * 360 + result.Minutes * 60 + result.Seconds;
        }
    }
}
