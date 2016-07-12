namespace Store.Core.Models.Carts
{
    using Infrastructure.Utils;
    using Contracts;
    using System.Collections.Generic;
    using Infrastructure.Constants;
    using System.Text;
    using System;
    public class Cart : ICart
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
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("                                                                                       ");
            result.AppendLine("                -----------------------------------------------------                  ");
            result.AppendLine("               |                                                     |                 ");
            result.AppendLine("               |     *******        **        *****   *********      |                 ");
            result.AppendLine("               |   *               *  *       *    *  *   *   *      |                 ");
            result.AppendLine("               |   *              ******      *****       *          |                 ");
            result.AppendLine("               |   *             *      *     **          *          |                 ");
            result.AppendLine("               |   *            *        *    * *         *          |                ");
            result.AppendLine("               |     *******   *          *   *  ***      *          |                 ");
            result.AppendLine("               |                                                     |                 ");
            result.AppendLine("                -----------------------------------------------------                  ");
            result.AppendLine("                             S H O P P I N G - C A R T:                                ");
            result.AppendLine("                                                                                       ");
            result.AppendLine("                                 (products in cart)                                    ");
            result.AppendLine("                                                                                       ");
            result.AppendLine("+----------+--------------------------------------------------------------------------+");
            result.AppendLine("|    Id    |                             Name                                         |");
            result.AppendLine("+----------+--------------------------------------------------------------------------+");

            var counter = 0;
            foreach (var product in this.Products)
            {
                counter += 1;
                result.AppendLine($"|{counter,9}|{product.Name,72}|");
                result.AppendLine("+----------+--------------------------------------------------------------------------+");
            }
            return result.ToString();
        }
    }
}
