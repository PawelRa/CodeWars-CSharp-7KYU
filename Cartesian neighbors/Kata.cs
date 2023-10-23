using System.Collections.Generic;

namespace Cartesian_neighbors
{
    public class Kata
    {
        public static IEnumerable<int[]> cartesianNeighbor(int x, int y)
        {

            return new List<int[]>{
              new int[]{ x, y + 1 },
              new int[]{ x + 1, y + 1 },
              new int[]{ x + 1, y },
              new int[]{ x + 1, y - 1 },
              new int[]{ x, y - 1 },
              new int[]{ x - 1, y - 1 },
              new int[]{ x - 1, y },
              new int[]{ x - 1, y + 1 },
            };

        }
    }
}
