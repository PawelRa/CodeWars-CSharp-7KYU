using System;

namespace Easy_wallpaper
{
    public class Wallpaper
    {
        public static string WallPaper(double l, double w, double h)
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                "sixteen", "seventeen", "eighteen", "nineteen", "twenty"};

            if (l * w * l == 0)
            {
                return numbers[0];
            }
            int rolls = 10 * 52;

            double lwalls = 2 * (l * h) * 100;
            double hwalls = 2 * (w * h) * 100;
            double sum = lwalls + hwalls;

            double howManyRolls = Math.Ceiling((sum / rolls) * 1.15);

            return numbers[(int)howManyRolls];
        }
    }
}
