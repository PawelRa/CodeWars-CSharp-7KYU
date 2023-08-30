namespace Regex_validate_PIN_code
{
    public class Kata
    {
        public static bool ValidatePin(string pin)
        {
            if (pin.Length != 4 && pin.Length != 6) { return false; }
            foreach (char c in pin)
            {
                if (!char.IsDigit(c)) return false;
            }

            return true;
        }
    }
}
