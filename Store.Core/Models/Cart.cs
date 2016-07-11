namespace Store.Core.Models.Carts
{
    using Infrastructure.Utils;
    using Contracts;
    using System.Collections.Generic;
    using Infrastructure.Constants;
    
    public class Cart
    {
        private IList<IProduct> products;

        public Cart()
        {
            this.products = new List<IProduct>();
        }

        public IList<IProduct> Products { get { return this.products; } }

        public void AddToCart(IProduct product)
        {
            Validator.CheckIfNull(product, GeneralConstants.ProductCannotBeNull);
            this.products.Add(product);
        }

        public bool RemoveFromCart(IProduct product)
        {
            Validator.CheckIfNull(product, GeneralConstants.ProductCannotBeNull);
            return this.products.Remove(product);
        }

        public void ClearCart(IProduct product)
        {
            this.products.Clear();
        }
    }
}
