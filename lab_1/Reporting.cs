using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void RegisterArrival(Product product, int quantity)
        {
            Console.WriteLine($"Реєстрація надходження товару: {product.Name}, кількість: {quantity}");
            warehouse.AddProduct(product, quantity);
        }

        public void RegisterShipment(Product product, int quantity)
        {
            Console.WriteLine($"Реєстрація відвантаження товару: {product.Name}, кількість: {quantity}");
            warehouse.RemoveProduct(product, quantity);
        }
    }
}
