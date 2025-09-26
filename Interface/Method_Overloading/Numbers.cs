using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Numbers
    {
        public int[] NumberItem { get; set; }
        public virtual void Print(int count)
        {
            foreach (int item in NumberItem)
            {
                if (item > count)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
