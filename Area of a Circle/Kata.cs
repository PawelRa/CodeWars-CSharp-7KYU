using System;

namespace Area_of_a_Circle
{
    public static class Kata
    {
        public static double CalculateAreaOfCircle(string radius)
        {
            double result = 0;

            var isDouble = double.TryParse(radius, out result);

            if (!isDouble || result <= 0 || radius.Contains(","))
            {
                throw new ArgumentException();
            } 

            Console.WriteLine(isDouble);

            return  Math.Round(Math.PI*result*result,2);
        }
    }
}
