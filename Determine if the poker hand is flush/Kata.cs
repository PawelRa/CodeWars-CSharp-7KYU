namespace Determine_if_the_poker_hand_is_flush
{
    public class Kata
    {
        public static bool CheckIfFlush(string[] cards)
        {
            char testMark = cards[0][cards[0].Length - 1];

            for (int i = 1; i < cards.Length; i++)
            {
                if (cards[i][cards[i].Length - 1] != testMark) { return false; }
            }

            return true;
        }
    }
}
