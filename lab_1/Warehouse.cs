using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Warehouse
    {
        public Dictionary<Product, int> Inventory { get; private set; } = new Dictionary<Product, int>();

        public void AddProduct(Product product, int quantity)
        {
            if (Inventory.ContainsKey(product))
                Inventory[product] += quantity;
            else
                Inventory.Add(product, quantity);
            Console.WriteLine($"Товар {product.Name} поповнено на {quantity} шт. Загальна кількість: {Inventory[product]}");
        }

        public bool RemoveProduct(Product product, int quantity)
        {
            if (Inventory.ContainsKey(product) && Inventory[product] >= quantity)
            {
                Inventory[product] -= quantity;
                Console.WriteLine($"Товар {product.Name} зменшено на {quantity} шт. Залишок: {Inventory[product]}");
                return true;
            }
            else
            {
                Console.WriteLine($"Недостатньо товару {product.Name} на складі.");
                return false;
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Складські запаси:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Key.Name}: {item.Value} шт.");
            }
        }
    }

}
