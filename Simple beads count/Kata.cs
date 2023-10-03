namespace Simple_beads_count
{
    public static class Kata
    {
        public static int CountRedBeads(int n)
        {
            return n > 1 ? (n - 1) * 2 : 0;
        }
    }
}
