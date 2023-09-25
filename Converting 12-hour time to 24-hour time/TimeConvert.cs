namespace Converting_12_hour_time_to_24_hour_time
{
    public class TimeConvert
    {
        public static string Convert12hTo24h(int hours, int minutes, string period)
        {
            if (hours == 12 && period == "am" && minutes > 9)
            { return $"00{minutes}"; }
            else if (hours == 12 && minutes <= 9 && period == "am")
            {
                return $"000{minutes}";
            }

            if (hours == 12 && period == "pm" && minutes > 9) { return $"12{minutes}"; }
            else if (hours == 12 && minutes <= 9 && period == "pm")
            {
                return $"120{minutes}";
            }

            if (period == "am" && hours > 9 && minutes > 9)
            {
                return $"{hours}{minutes}";
            }
            else if (period == "am" && hours <= 9 && minutes > 9)
            {
                return $"0{hours}{minutes}";
            }
            else if (period == "am" && hours > 9 && minutes <= 9)
            {
                return $"{hours}0{minutes}";
            }
            else if (period == "am" && hours <= 9 && minutes <= 9)
            {
                return $"0{hours}0{minutes}";
            }

            if (period == "pm" && minutes > 9)
            {
                return $"{hours + 12}{minutes}";
            }
            else if (period == "pm" && minutes <= 9)
            {
                return $"{hours + 12}0{minutes}";
            }
            return "-1";
        }
    }
}
