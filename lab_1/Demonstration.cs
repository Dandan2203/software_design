using lab_1;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var warehouse = new Warehouse();
        var basket = new Basket();
        var options = new Options(warehouse, basket);
        var reporting = new Reporting(warehouse);

        var bread = new Product("Хліб", new Money(10, 0), 14);
        var milk = new Product("Молоко", new Money(15, 50), 10);

        reporting.RegisterArrival(bread, 10);
        reporting.RegisterArrival(milk, 10);

        options.AddProductToBasket(bread, 12);
        options.AddProductToBasket(bread, 2);
        options.AddProductToBasket(milk, 3);

        basket.DisplayContents();

        options.RemoveProductFromBasket(bread, 1);

        warehouse.PrintChangeLog();
    }
}