using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_modifier
{
    public class Calculations
    {
        public int Sum(params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }

        // IN: readonly input parameter
        public int Square(in int number)
        {
            // number = number * number; // ❌ Not allowed
            return number * number;
        }

        // OUT: must assign a value before method ends
        public void GetDouble(int input, out int result)
        {
            result = input * 2;
        }

        // REF: input and output; must be initialized before calling
        public void Increment(ref int number)
        {
            number += 1;
        }
    }
}
