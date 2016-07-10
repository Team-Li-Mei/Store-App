namespace Store.Core.Models.Carts
{
    using Store.Core.Contracts;
    using System.Collections.Generic;

    public class Cart
    {
        private List<IProduct> cart;

        public Cart()
        {
            this.cart = new List<IProduct>();
        }

        public List<IProduct> Products
        {
            get
            {
                return new List<IProduct>(this.cart);
            }
        }
        public void AddToCart(IProduct product)
        {
            this.cart.Add(product);
        }
        public bool RemoveFromCart(IProduct product)
        {
            return this.cart.Remove(product);
        }
        public void ClearCart(IProduct product)
        {
            this.cart.Clear();
        }
    }
}
