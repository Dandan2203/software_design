using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Warehouse
    {
        public Dictionary<Product, int> Products { get; private set; } = new Dictionary<Product, int>();
        private List<string> ChangeLog = new List<string>();

        public void AddProduct(Product product, int quantity)
        {
            if (Products.ContainsKey(product))
                Products[product] += quantity;
            else
                Products.Add(product, quantity);
            ChangeLog.Add($"Товар {product.Name} поповнено на {quantity} одиниць.");
        }

        public void RemoveProduct(Product product, int quantity)
        {
            if (Products.ContainsKey(product) && Products[product] >= quantity)
            {
                Products[product] -= quantity;
                ChangeLog.Add($"Товар {product.Name} видалено на {quantity} одиниць.");
            }
        }

        public void PrintChangeLog()
        {
            foreach (string log in ChangeLog)
            {
                Console.WriteLine(log);
            }
        }
    }

}
