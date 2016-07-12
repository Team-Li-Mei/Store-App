namespace Store.Core.Exceptions
{
    using System;

    public class NegativPriceAplicationException : Exception
    {
        public NegativPriceAplicationException() : base("Negativ price is forbidden")
        {
            //new ("Negativ price is forbidden");
        }

  
    }
}