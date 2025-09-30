using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class BubbleSorts<T> where T : INumber<T>
    {
        public T[] Items { get; private set; }
        public BubbleSorts(T[] items) 
        {
        Items = items;
        }

        public void Sort()
        {
            T temp;
            for (int i = 0; i <= Items.Length - 2; i++)
            {
                for (int j = 0; j <= Items.Length -2; j++)
                {
                    if (Items[j] > Items[j + 1])
                    {
                        temp = Items[j + 1];
                        Items[j + 1] = Items[j];
                        Items[j] = temp;
                    }
                }
            }
        }
    }
}
