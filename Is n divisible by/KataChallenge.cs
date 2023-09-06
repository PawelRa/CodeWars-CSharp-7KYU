namespace Is_n_divisible_by
{
    public static class KataChallenge
    {
        public static bool IsDivisible(params int[] list)
        {

            for (int i = 1; i < list.Length; i++)
            {
                if (list[0] % list[i] != 0) return false;
            }

            return true;
        }
    }
}
