using System.Linq;

namespace Odd_or_Even
{
    public class Kata
    {
        public static string OddOrEven(int[] array)
        {
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}
