﻿namespace Trimming_a_string
{
    public class TrimStringKata
    {
        public static string TrimString(string phrase, int len)
        {
            if (phrase.Length <= len) { return phrase; }
            if (len <= 3) { return $"{phrase.Substring(0, len)}..."; }

            return $"{phrase.Substring(0, len - 3)}...";
        }
    }
}
