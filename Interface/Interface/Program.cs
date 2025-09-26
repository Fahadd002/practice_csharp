using Interface;

ShoppingCart cart = new ShoppingCart();

// Add Camera
cart.Products[cart.ProductCount++] = new Camera
{
    Name = "Canon EOS 90D",
    Price = 1000m,
    Discount = 10m
};

// Add Toothpaste
cart.Products[cart.ProductCount++] = new Toothpaste
{
    Name = "Colgate Fresh",
    Price = 5m,
    Discount = 0m
};

// Add Laptop
cart.Products[cart.ProductCount++] = new Laptop
{
    Name = "Dell XPS 13",
    Price = 1200m,
    Discount = 12m
};

// Show cart items
cart.ShowCartItem();
