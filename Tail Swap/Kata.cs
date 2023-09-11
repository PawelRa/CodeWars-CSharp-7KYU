namespace Tail_Swap
{
    public static class Kata
    {
        public static string[] TailSwap(string[] arr)
        {
            string[] fraze1 = arr[0].Split(':');
            string[] fraze2 = arr[1].Split(':');

            // your code here
            return new string[] { $"{fraze1[0]}:{fraze2[1]}", $"{fraze2[0]}:{fraze1[1]}" };
        }
    }
}
