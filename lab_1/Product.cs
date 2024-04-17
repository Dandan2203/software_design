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
        public Money Price { get; private set; }
        public int Quantity { get; set; }

        public Product(string name, Money price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ReducePrice(int whole, int coins)
        {
            Money newPrice = new Money(Price.WholePart - whole, Price.CoinsPart - coins);
            if (newPrice.WholePart >= 0 && (newPrice.WholePart > 0 || newPrice.CoinsPart >= 0))
            {
                Price = newPrice;
            }
            else
                Console.WriteLine("Неможливо знизити ціну: нова ціна менша 0.");
        }
    }

}
