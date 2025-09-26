Product burger = new Burger { Name = "Cheese Burger", Price = 5.00m, Size = 6, Flavour = "Beef" };
Product camera = new Camera { Name = "DSLR Camera", Price = 1000.00m, Pixel = 24, Brand = "Canon" };

Console.WriteLine($"{burger.Name} Total: {burger.CalculateTotal():C}");
Console.WriteLine($"{camera.Name} Total: {camera.CalculateTotal():C}");