namespace Number_Pairs
{
    public class Kata
    {
        public static int[] getLargerNumbers(int[] a, int[] b)
        {
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= b[i]) { result[i] = a[i]; } else { result[i] = b[i]; }
            }

            return result;
        }
    }
}
