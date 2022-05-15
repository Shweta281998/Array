using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class CountNumberOfPairWithabsoluteDifferenceK
    {
        //brute force
        public int CountKDifference1(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k && i < j)
                        count++;
                }
            }
            return count;
        }
        public int CountKDifference(int[] nums, int k)
        {
            int res = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item - k))
                    res += dict[item - k];
                if (dict.ContainsKey(item + k))
                    res += dict[item + k];
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            return res;
        }
    }
}
