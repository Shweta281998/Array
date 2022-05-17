using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class SortAnArrayByParity2
    {
        public int[] SortArrayByParityII(int[] nums)
        {
            int[] arr = new int[nums.Length];
            int p1 = 0, p2 = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    arr[p1] = nums[i];
                    p1 += 2;
                }
                else
                {
                    arr[p2] = nums[i];
                    p2 += 2;
                }
            }
            return arr;
        }
    }
}
