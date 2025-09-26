using Interface;

public class ShoppingCart
{
    public IProduct[] Products { get; set; }
    public int ProductCount { get; set; }

    public ShoppingCart(int size = 10)
    {
        Products = new IProduct[size]; // initialize array
        ProductCount = 0;
    }

    public void ShowCartItem()
    {
        var total = 0m;
        for (int i = 0; i < ProductCount; i++)
        {
            var item = Products[i];
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, After Discount: {item.CalculateDiscount()}");
            total += item.CalculateDiscount();
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine($"Total = {total}");
    }
}