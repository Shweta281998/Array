using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public class RunningsumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            int[] arr = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                arr[i] = sum;

            }
            return arr;
        }
    }
}
