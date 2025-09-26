using product_discount;

Product product = new Product();

Console.Write("Enter product price: ");
product.Price = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter quantity: ");
product.Quantity = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\n--- Bill Summary ---");
Console.WriteLine($"Price per unit : {product.Price:C}");
Console.WriteLine($"Quantity       : {product.Quantity}");
Console.WriteLine($"Total Price    : {product.TotalPrice:C}");
Console.WriteLine($"Discount       : {product.Discount:C}");
Console.WriteLine($"Net Total      : {product.NetTotal:C}");