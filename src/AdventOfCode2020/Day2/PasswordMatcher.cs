using System.Linq;

namespace AdventOfCode2020.Day2
{
    public class PasswordMatcher
    {
        public int CharMinOccurrencies { get; set; }
        public int CharMaxOccurrencies { get; set; }
        public char CharToCheck { get; set; }
        public string Password { get; set; }

        public static PasswordMatcher CreatePasswordMatcher(int charMinOccurrencies, int charMaxOccurrencies, char charToCheck, string password)
        {
            return new PasswordMatcher
            {
                CharMinOccurrencies = charMinOccurrencies,
                CharMaxOccurrencies = charMaxOccurrencies,
                CharToCheck = charToCheck,
                Password = password
            };
        }

        public bool IsMatchFirst()
        {
            var charToCheckCount = Password.Count(c => c.Equals(CharToCheck));
            return charToCheckCount >= CharMinOccurrencies && charToCheckCount <= CharMaxOccurrencies;
        }

        public bool IsMatchSecond()
        {
            var match1 = Password[CharMinOccurrencies - 1].Equals(CharToCheck);
            var match2 = Password[CharMaxOccurrencies - 1].Equals(CharToCheck);
            return match1 ^ match2;
        }
    }
}
