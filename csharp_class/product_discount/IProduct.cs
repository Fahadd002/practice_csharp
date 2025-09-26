using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_discount
{
    public interface IProduct
    {
        decimal Price { get; set; }
        decimal Quantity { get; set; }
        decimal TotalPrice { get; }
        decimal Discount { get;}
        decimal NetTotal { get; }
    }
}
