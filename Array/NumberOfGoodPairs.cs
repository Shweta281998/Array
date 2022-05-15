using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], 1);

                else
                {
                    count += dict[nums[i]];
                    dict[nums[i]]++;
                }
            }
            return count;
        }
    }
}