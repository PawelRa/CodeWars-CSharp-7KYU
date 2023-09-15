namespace Two_numbers_are_positive
{
    public static class Kata
    {
        public static bool TwoArePositive(int a, int b, int c)
        {
            int test = 0;
            if (a > 0) { test++; }
            if (b > 0) { test++; }
            if (c > 0) { test++; }

            return test == 2;
        }
    }
}
