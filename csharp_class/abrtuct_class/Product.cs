public abstract class Product
{
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }

    public abstract decimal CalculateTotal();
}

public class Burger : Product
{
    public int Size { get; set; }
    public string Flavour { get; set; } = default!;

    public override decimal CalculateTotal()
    {
        if (Size > 5)
            return Price * 1.2m;
        else
            return Price;
    }
}

public class Camera : Product
{
    public int Pixel { get; set; }
    public string Brand { get; set; } = default!;

    public override decimal CalculateTotal()
    {
        if (Pixel > 20)
            return Price + 200;
        else
            return Price;
    }
}
