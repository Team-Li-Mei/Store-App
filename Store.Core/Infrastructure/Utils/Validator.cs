namespace Store.Core.Infrastructure.Utils
{
    using System;

    public static class Validator
    {
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
    }
}
