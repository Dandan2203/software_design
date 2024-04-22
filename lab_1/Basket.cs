using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Basket
    {
        public Dictionary<Product, int> Items { get; private set; } = new Dictionary<Product, int>();

        public void AddProduct(Product product, int quantity)
        {
            if (Items.ContainsKey(product))
                Items[product] += quantity;
            else
                Items.Add(product, quantity);
        }

        public void RemoveProduct(Product product, int quantity)
        {
            if (Items.ContainsKey(product) && Items[product] >= quantity)
            {
                Items[product] -= quantity;
                if (Items[product] == 0)
                    Items.Remove(product);
            }
        }

        public void DisplayContents()
        {
            Console.WriteLine("Вміст кошика:");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Key.Name} - {item.Value} шт., по {item.Key.Price.WholePart}.{item.Key.Price.CoinsPart:D2} кожен");
            }
        }

    }
}
