using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class CountEqualAndDivisiblePairsInArray
    {
        //Brute-force
        public int CountPairs(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && (i * j) % k == 0)
                        count++;
                }
            }
            return count;
        }

        //optimize
        public int CountPairs1(int[] nums, int k)
        {
            int count = 0;
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], new List<int>() { i });

                else
                {
                    List<int> list = dict[nums[i]];
                    foreach (var item in list)
                    {
                        if (item * i % k == 0)
                        {
                            count++;
                        }
                    }
                    dict[nums[i]].Add(i);
                }
            }
            return count;
        }
    }
}

