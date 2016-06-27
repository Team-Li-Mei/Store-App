namespace Validation
{
    using System;

    public class InvalidRangeException : ApplicationException
    {
        public InvalidRangeException(int start, string message)
            : base($"{message}\nValue should be a number bigger than {start}.")
        {
        }
    }
}