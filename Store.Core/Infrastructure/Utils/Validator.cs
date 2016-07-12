namespace Store.Core.Infrastructure.Utils
{
    using System;
    using System.Text.RegularExpressions;

    public static class Validator
    {
        public static void CheckIfIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void CheckIfDecimalRange(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void CheckIfDoubleRange(double value, double min, double max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringLengthIsValid(string text, int max, int min = 0, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void CheckIfPriceIsValid(decimal price, string message = null)
        {
            if (price <= 0)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void CheckIfIsExpired(DateTime expirationDate, string message = null)
        {
            if (expirationDate <= DateTime.Now)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void CheckSymbols(string value, string pattern, string message)
        {
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            if (!regex.IsMatch(value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}

