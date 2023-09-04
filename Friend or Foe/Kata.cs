using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend_or_Foe
{
    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> list = new List<string>();

            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    list.Add(name);
                }
            }

            return list;
        }
    }
}
