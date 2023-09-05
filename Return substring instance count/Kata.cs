using System.Linq;
using System.Text.RegularExpressions;

namespace Return_substring_instance_count
{
    public class Kata
    {
        public static int SubstringCount(string fullText, string searchText)
        {
            return Regex.Matches(fullText, searchText).Count();
        }
    }
}
