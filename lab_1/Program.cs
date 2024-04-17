using lab_1;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Money priceOfProductA = new Money(100, 50);
        Product productA = new Product("Продукт A", priceOfProductA, 10);

        Warehouse warehouse = new Warehouse();
        warehouse.AddProduct(productA, 14);

        Reporting reporting = new Reporting(warehouse);
        reporting.RegisterArrival(productA, 10);

        warehouse.DisplayInventory();

        productA.ReducePrice(10, 0);
        Console.WriteLine($"Нова ціна Продукта A: {productA.Price}");

        reporting.RegisterShipment(productA, 15);
        reporting.InventoryReport();

        Console.WriteLine($"Остаток Продукта A на складе: {warehouse.Inventory[productA]} шт.");
        Console.WriteLine($"Цена Продукта A: {productA.Price.WholePart}.{productA.Price.CoinsPart:D2} грн.");

        productA.ReducePrice(200, 0);
        Console.WriteLine($"Після спроби знизити ціну: {productA.Price}");
    }
}