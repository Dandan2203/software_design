using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, Money price, int quantity = 1)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ReducePrice(int whole, int coins)
        {
            Money newPrice = new Money(Price.WholePart - whole, Price.CoinsPart - coins);
            if (newPrice.WholePart < 0 || (newPrice.WholePart == 0 && newPrice.CoinsPart < 0))
            {
                Console.WriteLine("Зменшення ціни неможливе: нова ціна нижча від нуля.");
            }
            else
            {
                Price = newPrice;
            }
        }
    }

}
