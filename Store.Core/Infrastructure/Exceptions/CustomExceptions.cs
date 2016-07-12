namespace Store.Core.Exceptions
{
    using System;
    using Store.Core.Infrastructure.Constants;

    public class NegativPriceAplicationException : Exception
    {
        public NegativPriceAplicationException() : base(GeneralConstants.NegativPrice)
        {
            //new ("Negativ price is forbidden");
        }


    }
}