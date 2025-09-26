using override_virtual;
List<Product> products = new List<Product>
        {
            new Product { ProductName = "Water Bottle", Quantity = 2, Price = 10 },
            new Burger { ProductName = "Cheeseburger", Quantity = 2, Price = 50 },
            new Juice { ProductName = "Orange Juice", Quantity = 3, Price = 15 },
            new Cake { ProductName = "Chocolate Cake", Quantity = 1, Price = 40 }
        };

foreach (var item in products)
{
    Console.WriteLine($"{item.ProductName} total: {item.CalculateTotal()}");
}