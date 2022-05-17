using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class SumOfUniqueElements
    {
        public int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 1);

                else
                    dict[num]++;
            }
            int sum = 0;
            foreach (var kv in dict)
            {
                if (kv.Value == 1)
                    sum += kv.Key;
            }
            return sum;
        }
    }
}
