using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuple
{
    public static class Calculations
    {
        public static (int Min, int Max) GetMinMax(int[] numbers)
        {
            int min = numbers.Min();
            int max = numbers.Max();
            return (min, max);
        }
        public static (int Num, int Count)[] GetNumberCount(int[] numbers)
        {
            Dictionary<int, int> countDict = new Dictionary<int, int>();

            foreach (int n in numbers)
            {
                if (countDict.ContainsKey(n))
                    countDict[n]++;
                else
                    countDict[n] = 1;
            }

            // Convert dictionary to array of tuples
            return countDict.Select(kvp => (kvp.Key, kvp.Value)).ToArray();
        }
    }
}
