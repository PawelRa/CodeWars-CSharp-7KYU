namespace Deodorant_Evaporator
{
    public class Evaporator
    {

        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            int result = 0;
            double test = (content * threshold) / 100;

            for (int i = 0; content > test; i++)
            {
                result++;
                content = content - ((content * evap_per_day) / 100);
            }

            return result;
        }
    }
}
