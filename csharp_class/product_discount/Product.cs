namespace product_discount
{
    public class Product : IProduct
    {
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice => Price * Quantity;
        public decimal Discount
        {
            get
            {
                decimal discountRate = 0;

                if (Quantity > 20)
                    discountRate = 0.20m; 
                else if (Quantity > 10)
                    discountRate = 0.10m;
                else if (Quantity > 5)
                    discountRate = 0.05m;
              
                return TotalPrice * discountRate;
            }
        }

        // NetTotal = TotalPrice - Discount
        public decimal NetTotal => TotalPrice - Discount;
    }
}
