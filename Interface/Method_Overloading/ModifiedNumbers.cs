using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class ModifiedNumbers: Numbers
    {
        //public override void Print(int count)
        //{
        //    base.Print(count); // used parent's method
        //}
        public new void Print(int count)// Same name similer to parent class method but here with new keyword it's only child class method
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
