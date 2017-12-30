using System;

namespace Common.Functions.GetRandomAlphaNumericString
{
    public static class StringGenerator
    {
        private const string AlphaNumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private const byte AlphaNumericCharsLength = 62; // == AlphaNumericChars.Length

        public static string Random(byte length)
            => new string(GetRandomChars(length));

        private static char[] GetRandomChars(byte length)
        {
            var rng = new Random();
            var chars = new char[length];
            for (var i = byte.MinValue; i < length; i++)
                chars[i] = NextChar(rng);
            return chars;
        }

        private static char NextChar(Random rng)
            => AlphaNumericChars[rng.Next(AlphaNumericCharsLength)];
    }
}
