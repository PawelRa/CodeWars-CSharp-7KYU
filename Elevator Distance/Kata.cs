namespace Elevator_Distance
{
    public static class Kata
    {
        public static int ElevatorDistance(int[] array)
        {
            int result = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    result += array[i] - array[i - 1];
                }
                else
                {
                    result += array[i - 1] - array[i];
                }
            }

            return result;
        }
    }
}
