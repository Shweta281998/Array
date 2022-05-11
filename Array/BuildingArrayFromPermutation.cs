using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class BuildingArrayFromPermutation
    {
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ans[j] = nums[nums[i]];
                j++;
            }
            return ans;
        }
    }
}
