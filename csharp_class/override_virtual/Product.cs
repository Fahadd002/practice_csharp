using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_virtual
{
    public class Product
    {
        public string ProductName { get; set; } = default!;
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual decimal CalculateTotal()
        {
            return Price * Quantity;
        }
    }


    public class Burger : Product
    {
        private decimal _discount = 0.9m; 

        public override decimal CalculateTotal()
        {
            return Price * Quantity * _discount;
        }
    }
    public class Juice : Product
    {
        private decimal _taxRate = 1.08m; // 8% tax

        public override decimal CalculateTotal()
        {
            return Price * Quantity * _taxRate;
        }
    }

    public class Cake : Product
    {
        private decimal _decorationCost = 5.0m;

        public override decimal CalculateTotal()
        {
            return (Price * Quantity) + _decorationCost;
        }
    }
}
