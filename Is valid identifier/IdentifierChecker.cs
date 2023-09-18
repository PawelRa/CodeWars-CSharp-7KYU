using System;

namespace Is_valid_identifier
{
    public class IdentifierChecker
    {
        public static bool IsValid(String idn)
        {
            char first = idn[0];
            if (first != '_' && first != '$'&& Char.IsDigit(first)) { return false; }

            for (int i = 1; i < idn.Length; i++)
            {
                if (!(Char.IsLetterOrDigit(idn[i]) || idn[i] == '_' || idn[i] != '$') ){ return false; }

            }
            return true;
        }
    }
}
