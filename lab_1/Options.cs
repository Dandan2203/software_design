using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Options
    {
        private Warehouse warehouse;
        private Basket basket;

        public Options(Warehouse warehouse, Basket basket)
        {
            this.warehouse = warehouse;
            this.basket = basket;
        }

        public void AddProductToBasket(Product product, int quantity)
        {
            if (warehouse.Products.TryGetValue(product, out int availableQuantity) && availableQuantity >= quantity)
            {
                basket.AddProduct(product, quantity);
                warehouse.RemoveProduct(product, quantity);
            }
            else
                Console.WriteLine($"Недостатньо товару на складі: {product.Name}");
        }

        public void RemoveProductFromBasket(Product product, int quantity)
        {
            if (basket.Items.TryGetValue(product, out int basketQuantity) && basketQuantity >= quantity)
            {
                basket.RemoveProduct(product, quantity);
                warehouse.AddProduct(product, quantity);
            }
            else
                Console.WriteLine($"Недостатньо товару у кошику: {product.Name}");
        }
    }
}