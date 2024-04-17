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
            warehouse.AddProduct(product, quantity);
            Console.WriteLine($"Реєстрація надходження товару {product.Name}, кількість: {quantity}");
        }

        public void RegisterShipment(Product product, int quantity)
        {
            if (warehouse.RemoveProduct(product, quantity))
                Console.WriteLine($"Реєстрація відвантаження товару {product.Name}, кількість: {quantity}");
        }

        public void InventoryReport()
        {
            warehouse.DisplayInventory();
        }
    }

}
